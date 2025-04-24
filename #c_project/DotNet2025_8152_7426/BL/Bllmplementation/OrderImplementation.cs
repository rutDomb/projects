using System;

using BlApi;



namespace Bllmplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int code, int quantity)
    {
            DO.Product product = _dal.Product.Read(code);
            BO.ProductInOrder p = order.ListProductInOrder.FirstOrDefault(p => p.Id == code);
            if (p != null)
            {
                 if(p.Quantity + quantity<=product._QuantityInStock)
                 {                 
                     order.ListProductInOrder.Remove(p);
                     p.Quantity += quantity;
                     order.ListProductInOrder.Add(p);
                 }
                 else
                 {
                      throw new BO.BlNotEnoughInStock("אזל מהמלאי");
                 }
            }
            else
            {
                if (quantity <= product._QuantityInStock)
                {
                    p = new BO.ProductInOrder(product._code, product._name, product._price, quantity, new List<BO.SaleInProduct>(), 0);
                    order.ListProductInOrder.Add(p);
                }
                else
                {
                    throw new BO.BlNotEnoughInStock("אזל מהמלאי");
                }
            }
            SearchSaleForProduct(p,order.IsPreferredClient);
            CalcTotalPriceForProduct(p);
            CalcTotalPrice(order);
        return p.ListSaleInProduct;
    }

    public void CalcTotalPrice(BO.Order order)
    {
        order.TotalPrice = (from p in order.ListProductInOrder
                            select p.TotalPrice).Sum();
    }

    public void CalcTotalPriceForProduct(BO.ProductInOrder product)
    {
        DO.Product p = _dal.Product.Read(product.Id);
        if(product.ListSaleInProduct==null)
        {      
            product.TotalPrice = p._price * product.Quantity;
        }
        else
        {
            int count = product.Quantity;
            List<BO.SaleInProduct> sales = new List<BO.SaleInProduct>();
            foreach (BO.SaleInProduct sale in product.ListSaleInProduct)
            {
                if(count>=sale.QuantityForSale)
                {
                    int amount = count / sale.QuantityForSale;
                    product.TotalPrice += amount * sale.Price;
                    count -= sale.QuantityForSale * amount;
                    sales.Add(sale);
                }
                if (count == 0)
                    break;
            }
            product.ListSaleInProduct = sales;
            product.TotalPrice += count * p._price;       
        }
    }

    public void DoOrder(BO.Order order)
    {
        foreach (BO.ProductInOrder p in order.ListProductInOrder)
        {
            DO.Product p1 = _dal.Product.Read(p.Id);
            BO.Product p2=BO.Tools.ConvertDOProductToBOProduct(p1);
            p2.QuantityInStock -= p.Quantity;
            p1 = BO.Tools.ConvertBOProductToDOProduct(p2);
            _dal.Product.Update(p1);
        }
    }

    public void SearchSaleForProduct(BO.ProductInOrder p, bool IsPreferredClient)
    {
        p.ListSaleInProduct = _dal.Sale.ReadAll(s => s._code == p.Id
                              && DateTime.Now >= s._dateStart && s._dateFinifh >= DateTime.Now
                              && p.Quantity>=s._amountForSale
                              && (IsPreferredClient == true||s._isForEveryone==true))
                              .Select(s=>new BO.SaleInProduct()
                              {
                                  Id = s._id,
                                  QuantityForSale = s._amountForSale,
                                  Price = s._priceForSale ?? 0,
                                  IsForEveryone = s._isForEveryone ?? false

                              }).ToList();

        p.ListSaleInProduct.OrderBy(s => s.Price / s.QuantityForSale);

    }
}
