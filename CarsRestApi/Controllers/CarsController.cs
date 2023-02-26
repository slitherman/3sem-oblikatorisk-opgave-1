using _3sem_oblikatorisk_opgave_1;
using CarsRestApi.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarsRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        public CarsRepo _repo;

        public CarsController(CarsRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Car> Get()
        {
            _repo.GetAll();
            if (_repo.GetAll().Count <= -1)
            {
                return NotFound("Error nothing could be retrieved from the list");
            };
          
            return Ok();


        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Car> Get([FromHeader] int id)
        {
    
            if (_repo.GetById(id) == null || _repo.GetById(id).Id <= -1)
            {
                return NotFound("Error id does not exist" + id);
            };
    
            return Ok();


        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Car> Post([FromBody] Car car)
        {
            Car cars = _repo.Create(car);
            if (cars == null)
            {
                return BadRequest("request on the object could not be processed, object: " + car);

            }

            return Created("api/pokemons/new", cars);
        }

        [HttpPost("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public ActionResult<Car> Put ([FromBody] Car car, [FromHeader] int id)
        {
            var cars = _repo.Update(car, id);
            if(cars == null)
            {
                return Conflict("request on the object could not be processed, object: " + car);
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Car> Delete([FromHeader] int id)
        {
            Car cars = _repo.Delete(id);
            if (cars == null)
            {
                return NotFound("Object with the id could not be located, id:" + id);
            }
            return Ok();
        }
    }
}
