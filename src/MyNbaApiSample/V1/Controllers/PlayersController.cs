using Microsoft.AspNetCore.Mvc;
using MyNbaApiSample.Controllers;
using System.Collections.Generic;

namespace MyNbaApiSample.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PlayersController : BaseController
    {
        private static readonly string[] Players = new[]
        {
           "LeBron James", "Carmelo Anthony", "James Harden", "DeMar DeRozan"
        };
        public PlayersController()
        {

        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Players;
        }
    }
}
