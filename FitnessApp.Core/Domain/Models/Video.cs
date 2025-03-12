using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Domain.Models
{
    public class Video
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Link { get; set; }
        public int LevelId { get; set; }
        public Level level { get; set; }
    }
}
