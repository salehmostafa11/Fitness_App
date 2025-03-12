using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Domain.Models
{
    public class Nutritionist
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<NutritionPlan> nutritionPlans { get; set; }
        public int LevelId { get; set; }
        public Level level { get; set; }
    }
}
