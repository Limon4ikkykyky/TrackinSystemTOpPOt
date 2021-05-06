using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.DAL.Entities
{
   public class Courses
    {
        [Key]
        public int CoursesID { get; set; }
        [Required]
        public string CoursName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
