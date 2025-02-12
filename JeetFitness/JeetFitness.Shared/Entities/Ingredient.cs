using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeetFitness.Shared.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float? Quantity { get; set; }
        public int? TotalCalories { get; set; }
        public int? Protein { get; set; }
        public int? CarboHydrates { get; set; }
        public int? Fats { get; set; }
    }
}
