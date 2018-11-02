using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models
{
    public class TestingClass // a sample, dummy class used for testing the Excel import/export functionality
{
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Statistic")]
        private int stat { get; set; }

        public string altName { get; set; }

        public TestingClass(string pname, int pstat, string paltname)
        {
            name = pname;
            stat = pstat;
            altName = paltname;
        }

    }


}
