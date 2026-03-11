using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalBomCodigo.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Document { get; set; }
    }
}
