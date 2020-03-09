using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationServices3.Models {
    public class Major {

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        public int MinSAT { get; set; }


        public Major() { }

    }
}
