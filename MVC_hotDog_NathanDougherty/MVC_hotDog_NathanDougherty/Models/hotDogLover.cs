using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_hotDog_NathanDougherty.Models
{
    public class hotDogLover
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ImageURL { get; set; }
        public string FavoriteDog { get; set; }
        public string lastAte { get; set; }
        public List<string> previousDogs;

    }
}