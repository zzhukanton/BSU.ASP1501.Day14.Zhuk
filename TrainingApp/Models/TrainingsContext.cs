using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrainingApp.Models
{
    public class TrainingsContext: DbContext
    {
        public DbSet<Training> Trainings { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}