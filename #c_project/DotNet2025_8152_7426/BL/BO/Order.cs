using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;
    public class Order
    {
      public bool IsPreferredClient { get; set; }
      public List<BO.ProductInOrder> ListProductInOrder{ get; set; }
      public double TotalPrice { get; set; }

      public Order()
      {
        this.ListProductInOrder = new List<ProductInOrder>();
      }
}
