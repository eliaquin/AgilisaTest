using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgilisaTest.Models
{
    public class DetailsTest
    {
        public int Id { get; set; }
        public int MasterTestId { get; set; }
        public MasterTest MasterTest { get; set; }
        public string ListItem { get; set; }

    }
}
