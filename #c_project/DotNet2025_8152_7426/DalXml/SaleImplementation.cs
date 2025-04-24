using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        static string XMLDATAPATHP = @"..\xml\products.xml";
        static string XMLDATAPATH = @"..\xml\sales.xml";
        static XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        static XmlSerializer serializerP = new XmlSerializer(typeof(List<Product>));
        public int Create(Sale item)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(XMLDATAPATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            List<Product> products = new List<Product>();
            using (FileStream fileStream = new FileStream(XMLDATAPATHP, FileMode.Open))
            {
                products= serializerP.Deserialize(fileStream) as List<Product?>;
            }
            Sale s = null;
            Product p = products.FirstOrDefault(i => i._code == item._code);
            if (p != null)
            {
                s = item with { _id = Config.getSaleMaxCode };
                sales.Add(s);
            }
            else
                throw new dalTheEntityDoesNotExist("The product in the sale does not exist.");
            using (FileStream fileStream = new FileStream(XMLDATAPATH, FileMode.Create))
            {
                serializer.Serialize(fileStream, sales);
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return s._id;
        }

        public void Delete(int id)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(XMLDATAPATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            Sale s = Read(id);
            sales.Remove(s);
            using (FileStream fileStream = new FileStream(XMLDATAPATH, FileMode.Create))
            {
                serializer.Serialize(fileStream, sales);
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        }

        public Sale? Read(int id)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(XMLDATAPATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            Sale s = sales.FirstOrDefault(i => i._id == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return s ?? throw new dalTheEntityDoesNotExist("The sale does not exist");
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(XMLDATAPATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            Sale? s = sales.FirstOrDefault(i => filter(i) == true);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return s ?? throw new dalTheEntityDoesNotExist("The product not exist");
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(XMLDATAPATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            if (filter != null)
            {
                List<Sale?> Sales = sales.Where(i => filter(i) == true).ToList();
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
                return Sales;
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
            return new List<Sale?>(sales);
        }

        public void Update(Sale item)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
            Delete(item._id);
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(XMLDATAPATH, FileMode.Open))
            {
                sales = serializer.Deserialize(fileStream) as List<Sale?>;
            }
            List<Product> products = new List<Product>();
            using (FileStream fileStream = new FileStream(XMLDATAPATHP, FileMode.Open))
            {
                products = serializerP.Deserialize(fileStream) as List<Product?>;
            }
            Sale s = null;
            Product p = products.FirstOrDefault(i => i._code == item._code);
            if (p != null)
            {
                s = item with { _id = item._id };
                sales.Add(s);
            }
            else
                throw new dalTheEntityDoesNotExist("The product in the sale does not exist.");
            using (FileStream fileStream = new FileStream(XMLDATAPATH, FileMode.Create))
            {
                serializer.Serialize(fileStream, sales);
            }
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        }
    }
}
