using System;
using System.Collections.Generic;
using System.Text;

namespace FPS.Entities
{
    public class InterestedProperty
    {
        public int Id { get; set; }
        public Property Property { get; set; }
        public ApplicationUser Customer { get; set; }
    }
}
