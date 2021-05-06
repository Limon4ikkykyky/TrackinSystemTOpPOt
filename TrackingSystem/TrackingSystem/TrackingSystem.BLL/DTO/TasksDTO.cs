using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.DAL.Entities;

namespace TrackingSystem.BLL.DTO
{
   public class TasksDTO
    {
        public int TasksID { get; set; }
     
        public string TaskName { get; set; }
       
        public string Description { get; set; }
       
        public double MaxScore { get; set; }
      
        public double MinScore { get; set; }

        public IList<ApplicationUser> Students { get; set; }
    }
}
