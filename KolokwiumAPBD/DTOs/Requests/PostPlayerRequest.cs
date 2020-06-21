using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.DTOs.Requests
{
    public class PostPlayerRequest
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
       
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        
        [Required]
        public LocalDate DateOfBirth { get; set; }
    }
}
