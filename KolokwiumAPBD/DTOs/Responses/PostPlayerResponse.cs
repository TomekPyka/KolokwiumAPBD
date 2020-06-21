using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.DTOs.Responses
{
    public class PostPlayerResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LocalDate DateOfBirth { get; set; }
    }
}
