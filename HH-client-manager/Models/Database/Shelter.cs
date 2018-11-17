using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class Shelter
{
        [DisplayName("Shelter Location")]
        public string Location { get; set; }
    }
}
