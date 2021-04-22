using System;
using System.Collections.Generic;
using System.Text;

namespace FPS.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public Purpose Purpose { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public PropertyType PropertyType { get; set; }
        public decimal Price { get; set; }
        public ApplicationUser Owner { get; set; }
        //public ICollection<ApplicationUser> Customers { get; set; }
    }
}
