using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.BLL.DTO;
using TrackingSystem.BLL.Interfaces;
using TrackingSystem.DAL.EF;
using TrackingSystem.DAL.Entities;
using TrackingSystem.DAL.Interfaces;

namespace TrackingSystem.BLL.Services
{
    public class TasksService : ITasksService
    {


        public IUnitOfWork db { get; set; }
        public TasksService(EFUnitOfWork uow)
        {
            db = uow;
        }
        public void UpdateTasks(TasksDTO task)
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<TasksDTO, Tasks>()).CreateMapper();
            Tasks tasks = mapper.Map<TasksDTO, Tasks>(task);
            db.Task.Update(tasks);
            db.SaveAsync();
        }
        public IEnumerable<TasksDTO> GetTasks()
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<Tasks, TasksDTO>()).CreateMapper();
            var tasks = mapper.Map<IEnumerable<Tasks>, IEnumerable<TasksDTO>>(db.Task.GetAll());
            return tasks;
        }

        public void DeleteTasks(int id)
        {
            db.Task.Delete(id);
        }

        public void Add(TasksDTO tasksDTO)
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<TasksDTO, Task>()).CreateMapper();
           Task task = mapper.Map<TasksDTO, Task>(tasksDTO);
          
        }

            public void Dispose()
        {
            db.Dispose();
        }
    }
}
