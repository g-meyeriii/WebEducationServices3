using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationServices3.Models {
    public class Student {

        public int Id { get; set; }
        public int StudentNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        public int? SAT { get; set; }
        public double GPA { get; set; }
        public int? MajorId { get; set; }


        public virtual Major Major { get; set; }

        public Student() { }
    }
}
