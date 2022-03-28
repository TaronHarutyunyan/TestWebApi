using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestWebApi.Models;
using TestWebApi.Services;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneController : ControllerBase
    {
        [HttpGet("{name}")]
        public ActionResult<Phone> Get(string name)
        {
            return PhoneService.Get(name);
        }
        [HttpGet]
        public ActionResult<List<Phone>> GetAll()
        {
            return PhoneService.GetAll;
        }
        [HttpGet("{id}")]
        public ActionResult<Phone> Get(int id)
        {
            return PhoneService.Get(id);
        }
        [HttpPost]
        public IActionResult Create(Phone phone)
        {
            PhoneService.Add(phone);
            return CreatedAtAction(nameof(Create), new { id = phone.Id }, phone);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var phone = PhoneService.Get(id);
            if (phone is null)
                return NotFound();
            PhoneService.Delete(id);
            return NoContent();
        }
    }
}
