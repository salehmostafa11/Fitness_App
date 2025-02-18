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
        public string Name {  get; set; }
        public int steps { get; set; }
        public ICollection<WorkoutVideo> workoutVideos { get; set; }
    }
}
