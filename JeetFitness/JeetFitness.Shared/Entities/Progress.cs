using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeetFitness.Shared.Entities
{
    public class Progress
    {
        public int Id { get; set; } 
        public DateOnly Date { get; set; }
        public string? Notes { get; set; }

    }
}
