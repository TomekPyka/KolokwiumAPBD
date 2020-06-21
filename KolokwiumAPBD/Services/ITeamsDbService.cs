using KolokwiumAPBD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Services
{
    interface ITeamsDbService
    {
        public IEnumerable<Team> GetTeams(string orderBy);
        public int CreatePlayer(Player Player);


    }
}
