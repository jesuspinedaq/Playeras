using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Playeras.Repositories;
using Playeras.Models;

namespace Playeras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        ColorRepositories repo = new ColorRepositories();

        // GET api/values
        [HttpGet]
        public ActionResult<List<Color>> Get()
        {
            return repo.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Color> Get(int id)
        {
            return repo.Get(id);
        }

        [HttpPost]
        public void Post([FromBody]Color color)
        {
            repo.Add(color);
        }
    }
}
