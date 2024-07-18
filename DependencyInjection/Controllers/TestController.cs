using DependencyInjection.Servicies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IRandomNumberServices _randomNumberServices1;
        private readonly IRandomNumberServices _randomNumberServices2;

        public TestController(IRandomNumberServices randomNumberServices1, IRandomNumberServices randomNumberServices2)
        {
            _randomNumberServices1= randomNumberServices1;
            _randomNumberServices2 = randomNumberServices2;

        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new
            {
                Number1 = _randomNumberServices1.GetNumber(),
                Number2=_randomNumberServices2.GetNumber()

            });; 
        }
    }
}
