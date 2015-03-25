using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_HDL_NathanDougherty.Models
{
    public class hdl
    {
        public int ID {get; set;}
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ImageURL { get; set; }
        public string FavoriteDog { get; set; }
        public string lastAte { get; set; }
        public List<string> previousDogs { get; set; }

      
    }

    public class hdlDBContext : DbContext
    {
        public DbSet<hdl> hdls { get; set; }
    }
}