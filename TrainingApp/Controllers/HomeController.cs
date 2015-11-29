using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingApp.Models;

namespace TrainingApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        TrainingsContext trainingsData = new TrainingsContext();

        public ActionResult Index()
        {
            IEnumerable<Training> trainings = trainingsData.Trainings;
            ViewBag.Trainings = trainings;
            return View();
        }

        [HttpGet]
        public ActionResult Register(int id)
        {
            ViewBag.TrainingId = id;
            ViewBag.Universities = trainingsData.Universities;
            return View();
        }

        [HttpPost]
        public string Register(Student student)
        {
            // добавляем информацию о покупке в базу данных
            trainingsData.Students.Add(student);
            // сохраняем в бд все изменения
            trainingsData.SaveChanges();
            return "Thanks for registration, " + student.Name;
        }

        public ActionResult ShowStudents(int id)
        {
            //ViewBag.TrainingName = trainingsData.Trainings.Where(t => t.TrainingID == id).Select(training => training.Title);
            List<Student> studentList = new List<Student>();
            foreach (var student in trainingsData.Students)
                if (student.TrainingID == id)
                    studentList.Add(student);

            ViewBag.Students = studentList;
            return View();
        }
    }
}
