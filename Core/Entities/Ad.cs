using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    /*!AhmedShaban: An Assumption
     * Ad has a foreign key that makes it associated to every user, and that's
     * why it appeared onetime in the response of the sample API
     */
    public class Ad : EntityBase
    {
        public string company { get; set; }
        public string url { get; set; }
        public string text { get; set; }
    }
}
