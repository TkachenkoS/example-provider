using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace Walks.Controllers
{
    public class WalksController : Controller
    {
        private IConfiguration _Configuration { get; }
        private WalkRepository _Repository;

        // This would usually be from a Repository/Data Store

        public WalksController(IConfiguration configuration)
        {
            this._Configuration = configuration;
            this._Repository = Walks.WalkRepository.GetInstance();
        }

        [HttpGet]
        [Route("/walks")]
        public IActionResult GetAll()
        {
            var jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = null
            };

            return new JsonResult(_Repository.GetWalks(), jsonSerializerOptions);
        }

        [HttpGet]
        [Route("/walk/{id?}")]
        public IActionResult GetSingle(int id)
        {
            var walk = _Repository.GetWalk(id);
            if (walk != null)
            {
                return new JsonResult(walk);
            }
            return new NotFoundResult();
        }
    }
}
