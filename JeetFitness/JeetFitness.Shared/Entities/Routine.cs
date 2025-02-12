using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeetFitness.Shared.Entities
{
    public class Routine
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Difficulty { get; set; }
        public int? Duration { get; set; }
        public ICollection<Excercise>? Excercises { get; set; }
    }
}
