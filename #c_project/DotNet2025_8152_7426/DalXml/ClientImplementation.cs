using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using DalApi;
using DO;
using Tools;

namespace Dal;

internal class ClientImplementation : IClient
{
    XElement xmlClient = XElement.Load(XMLDATAPATH);
    private const String XMLCLIENT = "clients.xml";
    private const string ARRAYOFCLIENT = "ArrayOfClient";
    private const string CLIENT= "Client";
    private const string ID="id";
    private const string USERNAME = "userName";
    private const string ADDRESS = "address";
    private const string PHONE = "phone";
    static string XMLDATAPATH= @"..\xml\clients.xml";
    public int Create(Client item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        List<Client>? client = new List<Client>();
        if(xmlClient.Descendants(ID).Any(c =>int.Parse(c.Value) == item._id))
            throw new dalTheCodeAlreadyExists("The client already exists");
        XElement newClient = new XElement(CLIENT,
        new XElement(ID, item._id),
        new XElement(USERNAME, item._userName),
        new XElement(ADDRESS, item._address),
        new XElement(PHONE, item._phone));
        xmlClient.Add(newClient);
        xmlClient.Save(XMLDATAPATH);         
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return item._id;

    }

    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Client c = Read(id);
        XElement idxml = xmlClient.Descendants(ID).Single(c => int.Parse(c.Value) == id);
        XElement clientxml = idxml.Parent;
        clientxml.Remove();
        xmlClient.Save(XMLDATAPATH);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
    }

    public Client? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        XElement idxml = xmlClient.Descendants(ID).Single(c => int.Parse(c.Value) == id);
        XElement clientxml = idxml.Parent;
        Client client = new Client()
        {
            _id = int.Parse(clientxml.Element(ID).Value),
            _userName = clientxml.Element(USERNAME).Value,
            _address = clientxml.Element(ADDRESS).Value,
            _phone = int.Parse(clientxml.Element(PHONE).Value)
        };
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return client ?? throw new dalTheEntityDoesNotExist("The client not exist");
    }

    public Client? Read(Func<Client, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        List<Client?> clients = xmlClient.Element(CLIENT).Elements().Where(c1 => filter(new Client()
        {
            _id = int.Parse(c1.Element(ID).Value),
            _userName = c1.Element(USERNAME).Value,
            _address = c1.Element(ADDRESS).Value,
            _phone = int.Parse(c1.Element(PHONE).Value)
        }) == true).Select(c=> new Client()
        {
            _id = int.Parse(c.Element(ID).Value),
            _userName = c.Element(USERNAME).Value,
            _address = c.Element(ADDRESS).Value,
            _phone = int.Parse(c.Element(PHONE).Value)
        }).ToList();
        Client? c=clients.FirstOrDefault();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return c ?? throw new dalTheEntityDoesNotExist("The client not exist");
    }


    public List<Client?> ReadAll(Func<Client, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");

        var clients = xmlClient.Descendants(CLIENT)
            .Select(c =>
            {
                int id;
                int phone;
                string userName = c.Element(USERNAME)?.Value;
                string address = c.Element(ADDRESS)?.Value;
                if (int.TryParse(c.Element(ID)?.Value, out id) &&
                    int.TryParse(c.Element(PHONE)?.Value, out phone))
                {
                    return new Client()
                    {
                        _id = id,
                        _userName = userName,
                        _address = address,
                        _phone = phone
                    };
                }
                return null; 
            })
            .ToList();
        if (filter != null)
        {
            clients = clients.Where(client => client != null && filter(client)).ToList();
        }

        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
        return clients;
    }


    public void Update(Client item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start");
        Delete(item._id);
        Create(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End");
    }
}
