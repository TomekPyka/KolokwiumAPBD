using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Model
{
    public class Team
    {
        public int IdTeam { get; set; }
        public string TeamName { get; set; }
        public int maxAge { get; set; }
        public virtual ICollection<Championship_Team> Participations { get; set; }

    }
}
