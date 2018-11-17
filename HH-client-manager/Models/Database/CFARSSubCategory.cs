using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class CFARSSubCategory
{
        [DisplayName("Subcategory Name")]
        public string Name { get; set; }

        [DisplayName("Category Name")]
        public string Category_name { get; set; }
    }
}
