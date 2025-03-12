using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Domain.Models
{
    public class NutritionPlan
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Calories { get; set; }
        public string Meals { get; set; }
        public int NutritionistId { get; set; }
        public Nutritionist nutritionist { get; set; }
        public int LevelId { get; set; }
        public Level level { get; set; }
    }
}
