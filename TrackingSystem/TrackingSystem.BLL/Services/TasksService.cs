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


        private readonly IUnitOfWork db;
        private readonly IMapper mapp;

        public TasksService(EFUnitOfWork uow,IMapper mapper)
        {
            db = uow;
            mapp = mapper;
        }
        public async Task UpdateTasks(TasksDTO task)
        {
            
            Tasks tasks = mapp.Map<TasksDTO, Tasks>(task);
            db.Task.Update(tasks);

            await db.SaveAsync();
        }
        public async Task< IEnumerable<TasksDTO>> GetTasks()
        {
            
            var tasks = mapp.Map<IEnumerable<Tasks>, IEnumerable<TasksDTO>>(db.Task.GetAll());
            return tasks;
        }

        public async Task DeleteTasks(int id)
        {
            db.Task.Delete(id);
        }

        public async Task Add(TasksDTO tasksDTO)
        {
           
           Tasks task = mapp.Map<TasksDTO, Tasks>(tasksDTO);
            db.Task.Create(task);
            await db.SaveAsync();


        }

            public void Dispose()
        {
            db.Dispose();
        }
    }
}
