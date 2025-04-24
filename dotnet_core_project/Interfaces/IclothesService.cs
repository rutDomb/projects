using שיעור_3.Models;
using System.Collections.Generic;
using System.Linq;


namespace שיעור_3.Interfaces
{
    public interface IclothesService
    {
    List<Sclothes> GetAll(int userId);
    Sclothes Get(int id);

    void POST(Sclothes newClothes);

    void PUT(Sclothes newItem);

    void Delete(int id);

    void DeleteAll(int userId);

    int Count { get;}

    
    }
}
