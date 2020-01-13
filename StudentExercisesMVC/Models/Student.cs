using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentExercisesMVC.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string SlackHandle { get; set; }

        [Required]
        public int CohortId { get; set; }
    }
}