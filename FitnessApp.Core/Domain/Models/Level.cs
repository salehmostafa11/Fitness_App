using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Domain.Models
{
    public class Level
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Steps { get; set; }
        public List<Trainee> trainees { get; set; }
        public List<Video> videos { get; set; }
        public List<Nutritionist> nutritionists { get; set; }
        public List<NutritionPlan> nutritionPlans { get; set; }
    }
}
