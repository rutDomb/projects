using שיעור_3.Models;
using שיעור_3.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using שיעור_3.Services;



namespace שיעור_3.Services
{
    public class userService : IuserSevice
    {
        List<User> Users;
        int nextId = 3;

        private string fileName;

        public userService()
        {
            fileName = Path.Combine("data", "users.json");
            using (var jsonFile = File.OpenText(fileName))
            {

                Users = JsonSerializer.Deserialize<List<User>>(jsonFile.ReadToEnd(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
        }


        private void saveToFile()
        {
            File.WriteAllText(fileName, JsonSerializer.Serialize(Users));
        }

        public List<User> GetAll() => Users;

        public User Get(int id) => Users.FirstOrDefault(u => u.Id == id);
        public void POST(User newUser)
        {
            Users.Add(newUser);
            saveToFile();
        }

        public void PUT(User newUser)
        {
            var index = Users.FindIndex(p => p.Password == newUser.Password);
            if (index == -1)
                return;
            Users[index] = newUser;
            saveToFile();
        }
        public void Delete(int id)
        {
            var user = Get(id);
            if (user is null)
                return;
            Users.Remove(user);
            saveToFile();
        }

        public int Count { get => Users.Count(); }

        public int ExistUser(string name, string password)
        {
            User exitUser = Users.FirstOrDefault(u => u.Username.Equals(name) && u.Password.Equals(password));
            if (exitUser != null)
                return exitUser.Id;
            return -1;
        }
    }

}


public static class UserUtils
{
    public static void AddUser(this IServiceCollection services)
    {
        services.AddSingleton<IuserSevice, userService>();
    }
}