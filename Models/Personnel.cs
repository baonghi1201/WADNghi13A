using System;
using System.Collections.Generic;

namespace WADNghi13A.Models
{
    public partial class Personnel
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
    }
}
