using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Model
{
    public class Player
    {
        public int IdPlayer { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }

        public LocalDate DateOfBirth { get; set; }
        public virtual ICollection<Championship_Team> Participations { get; set; }
    }
}
