using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.DTO;

namespace TrackingSystem.BLL.Interfaces
{
    public interface ITasksService
    {
        void UpdateTasks(TasksDTO task);
        IEnumerable<TasksDTO> GetTasks();
  
        void Add(TasksDTO tasksDTO);
        
        
        void DeleteTasks(int id);
       
        void Dispose();
    }
}
