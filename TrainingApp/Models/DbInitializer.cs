using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TrainingApp.Models
{
    public class DbInitializer: DropCreateDatabaseAlways<TrainingsContext>
    {
        protected override void Seed(TrainingsContext context)
        {
            context.Trainings.Add(new Training() { TrainingID = 1, Title = "Java in web" });
            context.Trainings.Add(new Training() { TrainingID = 2, Title = "Javascript" });
            context.Trainings.Add(new Training() { TrainingID = 3, Title = ".NET" });

            context.Universities.Add(new University() { UniversityID = 1, Name = "BSU" });
            context.Universities.Add(new University() { UniversityID = 2, Name = "BSUIR" });
            context.Universities.Add(new University() { UniversityID = 3, Name = "MSU" });

            base.Seed(context);
        }
    }
}