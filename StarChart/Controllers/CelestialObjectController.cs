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


    }
}
