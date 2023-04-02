using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Entities
{
    public class Import
    {
        public Import()
        {
            ImportProducts = new HashSet<ImportProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Address { get; set; }
        public ICollection<ImportProduct> ImportProducts { get; set; }
       
    }
}
