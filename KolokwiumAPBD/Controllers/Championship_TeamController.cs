using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolokwiumAPBD.Model;
using KolokwiumAPBD.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumAPBD.Controllers
{
    [Route("api/participations")]
    [ApiController]
    public class Championship_TeamController : ControllerBase

    {
        private readonly ITeamsDbService _dbService;

        [HttpGet("{idChampionship}")]
        public async Task<ActionResult<IEnumerable<ChampionshipTeamResponse>>> GetTeams()
        {
            var teams = await _dbService.GetTeams();
            return Ok(teams.Select(d => new ChampionshipTeamResponse
            {
                IdTeam = d.IdTeam,
                TeamName = d.TeamName,
                MaxAge = d.MaxAge

            }));
        }

    }
}