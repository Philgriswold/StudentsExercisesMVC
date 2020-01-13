
using StudentExerciseMVC.Models;
using StudentExercisesMVC.Models;
using System.Collections.Generic;

namespace StudentExercisesMVC.Controllers
{
    internal class StudentInstructorViewModel
    {
        public StudentInstructorViewModel()
        {
        }

        public List<Student> Students { get; internal set; }
        public List<Instructor> Instructors { get; internal set; }
    }
}