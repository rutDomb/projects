using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Order : Form
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        static BO.Order order = new BO.Order();
        
        public Order(int id)
        {
            try
            {
                InitializeComponent();
                order.IsPreferredClient = s_bl.Client.IsExist(id);
                totalPrice.Text = 0.ToString();
                List<Product> list = s_bl.Product.ReadAll();
                foreach (var item in list)
                {
                    nameProduct.Items.Add(item.Name);
                }
            }
            catch(Exception ex)
{
                MessageBox.Show(ex.Message);
            }
        }



        private void addToOrder_Click(object sender, EventArgs e)
        {
            try 
            {
                int amount1;
                int code = 0;
                Product product=null;
                List<Product> list = s_bl.Product.ReadAll();
                foreach (Product item in list)
                {
                    if (item.Name == nameProduct.Text)
                    {
                        product = item;
                        code = item.Code;
                    }

                }
                ProductInOrder p = order.ListProductInOrder.FirstOrDefault(p => p.NameProduct == nameProduct.Text);
                if (p != null)
                {
                    amount1 = p.Quantity;
                    if (amount.Value + amount1 <= product.QuantityInStock)
                    {
                        ShoppingCart.Items.Remove($"שם מוצר: {nameProduct.Text} כמות: {amount1}");
                        ShoppingCart.Items.Add($"שם מוצר: {nameProduct.Text} כמות: {amount.Value + amount1}");
                    }
                }
                else
                {
                    if (amount.Value <= product.QuantityInStock)
                        ShoppingCart.Items.Add($"שם מוצר: {nameProduct.Text} כמות: {amount.Value}");
                }    
                s_bl.Order.AddProductToOrder(order, code, (int)amount.Value);
                s_bl.Order.CalcTotalPrice(order);
                totalPrice.Text = order.TotalPrice.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toOrder_Click(object sender, EventArgs e)
        {
            try 
            {
                s_bl.Order.DoOrder(order);
                MessageBox.Show("ההזמנה בוצעה הצלחה!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                List<Product> list = s_bl.Product.ReadAll();
                int code = 0;
                salesOfProduct.Items.Clear();
                Product p1 = null;
                foreach (Product item in list)
                {
                    if (item.Name == nameProduct.Text)
                    {
                        code = item.Code;
                        p1 = item;
                    }

                }
                ProductInOrder p = new ProductInOrder(p1.Code, p1.Name, p1.Price, (int)amount.Value, null, p1.Price);
                s_bl.Order.SearchSaleForProduct(p, order.IsPreferredClient);
                if (p.ListSaleInProduct != null)
                {
                    foreach (SaleInProduct item in p.ListSaleInProduct)
                    {
                        salesOfProduct.Items.Add(item.ToStringProperty());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void totalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
