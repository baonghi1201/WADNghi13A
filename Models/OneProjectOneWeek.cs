using System;
using System.Collections.Generic;

namespace WADNghi13A.Models
{
    public partial class OneProjectOneWeek
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public string Project { get; set; }
        public string ArriveDt { get; set; }
        public string DepartureDt { get; set; }
        public string OneWeek { get; set; }
    }
}
