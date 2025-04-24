using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using שיעור_3.Interfaces;
using שיעור_3.Services;
using שיעור_3.Models;

namespace שיעור_3.Controllers;


    [ApiController]
    [Route("[controller]")]
    public class ShopClothesController : ControllerBase
    {
        private IclothesService clothesService;

        public ShopClothesController(IclothesService clothesService)
        {
            this.clothesService = clothesService;
        }

        [HttpGet()]
        [Authorize(Policy="User")]
        public ActionResult<List<Sclothes>> GetAll()
        {
             return clothesService.GetAll(int.Parse(User.FindFirst("id")?.Value!));
        }
                

        [HttpGet("{id}")]
        [Authorize(Policy="User")]
        public ActionResult<Sclothes> Get(int id)
        {
            var cloth = clothesService.Get(id);
            if (cloth == null)
                return NotFound();
            return cloth;
        }

        [HttpPost]
        [Authorize(Policy="User")]
        public IActionResult POST(Sclothes newClothes)
        {
            clothesService.POST(newClothes);
            return CreatedAtAction(nameof(POST), new { id = newClothes.Id }, newClothes);
        }

        [HttpPut("{id}")]
        [Authorize(Policy="User")]
        public IActionResult Update(int id, Sclothes newItem)
        {
            if (id != newItem.Id)
                return BadRequest();

            var existingcloth = clothesService.Get(id);
            if (existingcloth is null)
                return NotFound();

            clothesService.PUT(newItem);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Policy="User")]
        public IActionResult Delete(int id)
        {
            var cloth = clothesService.Get(id);
            if (cloth is null)
                return  NotFound();
            clothesService.Delete(id);
            return Content(clothesService.Count.ToString());
        }
    }