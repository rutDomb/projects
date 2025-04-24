using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;
    public class ProductInOrder
    {
       public int Id { get; init; }
       public string NameProduct { get; set; }
       public double BasePrice { get; set; }
       public int Quantity { get; set; }
       public List<BO.SaleInProduct> ListSaleInProduct { get; set; }
       public double TotalPrice { get; set; }

       public ProductInOrder(int id,string nameProduct,double basePrice,int quantity, List<BO.SaleInProduct> listSaleInProduct, double totalPrice)
       {
          this.Id = id;
          this.NameProduct = nameProduct;
          this.BasePrice = basePrice;
          this.Quantity = quantity;
          this.ListSaleInProduct = listSaleInProduct;
          this.TotalPrice = totalPrice;
       }
}
