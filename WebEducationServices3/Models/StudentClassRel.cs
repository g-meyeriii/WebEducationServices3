using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebEducationServices3.Models {
    public class StudentClassRel { 

        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId{ get; set; }

        //This attribute prevents the many to many cyclical error
        [JsonIgnore]
        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }

        public StudentClassRel() { }
    }
}
