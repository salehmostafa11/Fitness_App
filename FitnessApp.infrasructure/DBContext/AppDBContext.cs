using FitnessApp.Core.Domain.Interfaces;
using FitnessApp.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.infrasructure.DBContext
{
    internal class AppDBContext: DbContext,IAppDbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
      //  public DbSet<Log> Logs { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<WorkoutVideo> Videos { get; set; }
        public DbSet<Nutritionist> Nutritionists { get; set; }
        public DbSet<Nutrition_Plan> NutritionPlans { get; set; }
    }

}

