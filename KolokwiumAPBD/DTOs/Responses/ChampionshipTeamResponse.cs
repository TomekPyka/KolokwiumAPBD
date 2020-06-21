using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.DTOs.Responses
{
    public class GetChampionship_TeamResponse
    {
        [Required]
        public int IdChampionship { get; set; }
        [Required]
        public float Score { get; set; }
        [Required]
        public int IdTeam { get; set; }
    }
}
