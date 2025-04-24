using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using שיעור_3.Interfaces;
using שיעור_3.Models;
using שיעור_3.Services;



namespace שיעור_3.Controllers;


    [ApiController]
    [Route("[controller]")]
    public class userController : ControllerBase
    {
        private IuserSevice userService;

        private IclothesService clothesService;

        public userController(IuserSevice userService,IclothesService clothesService)
        {
            this.userService = userService;
            this.clothesService=clothesService;
        }

        [HttpGet()]
        [Authorize(Policy="Admin")]
        public ActionResult<List<User>> GetAll() =>
                this.userService.GetAll();

        [HttpGet("{id}")]
        [Authorize(Policy="User")]
        public ActionResult<User> Get(int id)
        {
            var user = userService.Get(id);
            if (user == null)
                return NotFound();
            return user;
        }

        [HttpPost]
        [Authorize(Policy="Admin")]
        public IActionResult POST(User newUser)
        {
            userService.POST(newUser);
            return CreatedAtAction(nameof(POST), new { id = newUser.Id }, newUser);
        }

        [HttpPut("{id}")]
        [Authorize(Policy="User")]
        public IActionResult Update(int id, User newUser)
        {
            if (id != newUser.Id)
                return BadRequest();

            var existingcloth = userService.Get(id);
            if (existingcloth is null)
                return NotFound();

            userService.PUT(newUser);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Policy = "Admin")]
        public IActionResult Delete(int id)
        {
            var user = userService.Get(id);
            if (user is null)
                return  NotFound();
            userService.Delete(id);
            clothesService.DeleteAll(id);
            return Content(userService.Count.ToString());
        }

        [HttpPost]
        [Route("/login")]
        public  ActionResult<objectToReturn> Login([FromBody] User user)
        {
            int UserExistID = userService.ExistUser(user.Username, user.Password);
            if(UserExistID==-1)
            {
                return Unauthorized();
            }
            var claims=new List<Claim>{};
            if( user.Username=="ruti"&& user.Password=="455542")
               claims.Add(new Claim("type","Admin"));
            else
                claims.Add(new Claim("type","User"));
            claims.Add(new Claim("id",UserExistID.ToString()));

            var token=ClothesTokenService.GetToken(claims);
            return new OkObjectResult(new{Id=UserExistID,token=ClothesTokenService.WriteToken(token)});
        }


    }

public class objectToReturn
{
    public int Id { get; set; }

    public string token { get; set; }
}