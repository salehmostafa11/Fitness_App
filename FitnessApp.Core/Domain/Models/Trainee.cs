using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Domain.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Gender { get; set; }
        public string PasswordHash { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string TypeOfTraining { get; set; }
        public int Steps { get; set; }
        public int TrainerId { get; set; }
        public Trainer trainer { get; set; }
        public int LevelId { get; set; }
        public Level level { get; set; }
    }
}
