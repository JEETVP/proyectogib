using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeetFitness.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        private string? Password{ get; set; }
        public float? Weight {  get; set; }
        public float? Height { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? ActitvityLevel { get; set; }

    }
}
