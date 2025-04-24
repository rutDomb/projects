using שיעור_3.Models;
using System.Collections.Generic;
using System.Linq;

namespace שיעור_3.Interfaces
{
    public interface IuserSevice
    {
    List<User> GetAll();
    User Get(int id);

    void POST(User newUser);

    void PUT(User newUser);

    void Delete(int id);

    int Count { get;}

    int ExistUser(string name, string password);
    }

   

}