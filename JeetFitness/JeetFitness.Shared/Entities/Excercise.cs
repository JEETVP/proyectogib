using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeetFitness.Shared.Entities
{
    public class Excercise
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? MuscleGroup { get; set; }
        public string? Series { get; set; }
        public string? Repetitions { get; set; }
        public string? Weight { get; set; }

    }
}
