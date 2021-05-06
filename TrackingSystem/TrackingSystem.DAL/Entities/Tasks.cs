using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.DAL.Entities
{
    public class Tasks
    {
        [Key]
        public string TasksID { get; set; }
        [Required]
        public string TaskName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double MaxScore { get; set; }
        [Required]
        public double MinScore { get; set; }
        public IList<ApplicationUser> Students { get; set; }
    }
}
