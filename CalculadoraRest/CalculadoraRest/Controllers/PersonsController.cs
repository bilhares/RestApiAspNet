using CalculadoraRest.Model;
using CalculadoraRest.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {

        private IPersonService _personService;


        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Person person)
        {
            return new ObjectResult(_personService.Create(person));
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Person p)
        {
            return new ObjectResult(_personService.Update(p));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
