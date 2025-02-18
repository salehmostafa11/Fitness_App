using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Domain.Models
{
    public class Trainee:User
    {
        public int age { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Type_of_Training { get; set; }
        public int Steps { get; set; }
    }
}
