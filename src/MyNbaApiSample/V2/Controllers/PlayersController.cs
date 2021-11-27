using Microsoft.AspNetCore.Mvc;
using MyNbaApiSample.Controllers;
using MyNbaApiSample.V2.ViewModels;
using System.Collections.Generic;

namespace MyNbaApiSample.V2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PlayersController : BaseController
    {
        private List<PlayerViewModel> Players = new()
        {
           new() { Name = "LeBron James" }, 
           new() { Name = "Carmelo Anthony" }, 
           new() { Name = "James Harden" },
           new() { Name = "DeMar DeRozan" }
        };

        public PlayersController()
        {

        }

        [HttpGet]
        public IEnumerable<PlayerViewModel> Get()
        {
            return Players;
        }

        [HttpPost]
        public void Post([FromBody]PlayerViewModel player)
        {
            Players.Add(player);
        }
    }
}
