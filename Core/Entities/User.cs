using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    //!AhmedShabn: User Entity modeling
    public class User : EntityBase
    {
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
        public Ad ad { get; set; }
    }
}
