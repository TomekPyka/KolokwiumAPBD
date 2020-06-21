using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Model
{
    public class Championship_Team
    {
        public int IdChampionship_Team { get; set; }
        public int IdTeam { get; set; }
        public int IdChampionship { get; set; }
        public int Score { get; set; }
        public virtual Championship Championship { get; set; }
        public virtual Team Team { get; set; }
        
    }
}
