using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Domain.Models
{
    public class Supervisor:Admin
    {
        public int Experience_Years { get; set; }
        public ICollection<Trainee>trainees { get; set; }
    }
}
