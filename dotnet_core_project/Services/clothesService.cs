using שיעור_3.Models;
using שיעור_3.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using שיעור_3.Services;




namespace שיעור_3.Services{


public class ShopClothesService : IclothesService
{
    List<Sclothes> Clothes;
    private string fileName;
    
    public ShopClothesService()
    {

        fileName=Path.Combine("data","clothes.json");
        using (var jsonFile=File.OpenText(fileName))
        {
            Clothes = JsonSerializer.Deserialize<List<Sclothes>>(jsonFile.ReadToEnd(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            // Clothes=JsonSerializer.Deserialize<List<Sclothes>>(jsonFile.ReadToEnd(),
            // new JsonSerializerOptions
            // {
            //      PropertyNameCaseInsensitive = true
            // });
        }
    }

   private void saveToFile()
   {
      File.WriteAllText(fileName,JsonSerializer.Serialize(Clothes));
   }

   public List<Sclothes> GetAll (int userId) 
   {
        return Clothes.FindAll(t=>t.UserId==userId);
   }

    public  Sclothes Get(int id) => Clothes.FirstOrDefault(p => p.Id == id);
    public void POST(Sclothes newClothes)
    {
        int maxId = Clothes.Max(p => p.Id);
        newClothes.Id = ++maxId;
        // newClothes.UserId=
        Clothes.Add(newClothes);
        saveToFile();
    }

    public void PUT(Sclothes newItem)
    {
            var index = Clothes.FindIndex(p => p.Id == newItem.Id);
            if(index ==-1)
                return;
            Clothes[index] = newItem;
            saveToFile();
    }   
    public void Delete(int id)
    {
        var cloth = Get(id);
            if(cloth is null)
                return;
        Clothes.Remove(cloth);
        saveToFile();
    } 

    public void DeleteAll(int userId)
    {
        Clothes.RemoveAll(item => item.UserId == userId);
        saveToFile();
    }

    public int Count =>  Clothes.Count();
}
}



public static class ClothUtils
{
    public static void AddCloth(this IServiceCollection services)
    {
        services.AddSingleton<IclothesService,ShopClothesService>();
    }
}