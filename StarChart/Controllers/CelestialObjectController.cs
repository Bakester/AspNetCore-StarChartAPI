using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

//Object Controller that contains ApiController attr. as well as a route TBD
namespace StarChart.Controllers
{
    [ApiController]
    [Route("")]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        //CelestialObjectController constructor to set val w/ private readonly _context
        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Method: GetById
        //Returns: IActionResult, NotFound(), ok
        //Params: int id
        //Attrs: HttpGet
        //Goal: Return NotFound() if no CelestialObject with Id matches current ID
        //      Set Satellites Property to any CelestialObject who's OrbitedObjectID is the current CelestialObject ID
        //      Return OK with value of CelestialObject whose Id matches the id param
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            int objId = id;

            Models.CelestialObject curObj = new Models.CelestialObject();

            if (curObj.Id != objId)
                return NotFound();
            else if (curObj.Id == objId)
                curObj.Satellites.Add(curObj);
                return Ok();
        }

        //Method: GetByName
        /*
        return type: IActionResult.
        Accept a parameter of type string named 'name'.
        attr: HttpGet attribute with a value of "{name}".
        Set: set the Satellites property for each returned CelestialObject to any CelestialObjects who's OrbitedObjectId is the current CelestialObject's Id.
        Returns: return NotFound() when there is no CelestialObject with a Name property that matches the name parameter.
                 return an Ok with a value of all CelestialObjects whose Name property matches the name parameter.
        */
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            string newName = name;
            Models.CelestialObject celestialObject = new Models.CelestialObject();
            int objLen = celestialObject.Satellites.Count();

            for (int i = 0; i < objLen; i++)
            {
                if (celestialObject.Satellites[i].Name == newName)
                {
                    if (celestialObject.Satellites[i].Id != celestialObject.Id)
                    {
                        celestialObject.Id = celestialObject.Satellites[i].Id;
                    }
                    return Ok();
                }
            }
            return NotFound();
        }


    }
}
