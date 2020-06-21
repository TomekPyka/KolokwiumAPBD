using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Model
{
    public class PlayerTeam
    {
        public int Player_Team { get; set; }
        public int IdTeam { get; set; }
        public int IdPlayer { get; set; }
        public int IdChampionship { get; set; }
        public int NumOnShirt { get; set; }
        public string Comment { get; set; }
        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
    }
}
