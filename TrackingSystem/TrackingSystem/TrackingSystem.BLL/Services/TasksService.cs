﻿using AutoMapper;
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
        public async Task UpdateTasks(TasksDTO task)
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<TasksDTO, Tasks>()).CreateMapper();
            Tasks tasks = mapper.Map<TasksDTO, Tasks>(task);
            db.Task.Update(tasks);

            await db.SaveAsync();
        }
        public async Task< IEnumerable<TasksDTO>> GetTasks()
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<Tasks, TasksDTO>()).CreateMapper();
            var tasks = mapper.Map<IEnumerable<Tasks>, IEnumerable<TasksDTO>>(db.Task.GetAll());
            return tasks;
        }

        public async Task DeleteTasks(int id)
        {
            db.Task.Delete(id);
        }

        public async Task Add(TasksDTO tasksDTO)
        {
            var mapper = new MapperConfiguration(c => c.CreateMap<TasksDTO, Tasks>()).CreateMapper();
           Tasks task = mapper.Map<TasksDTO, Tasks>(tasksDTO);
            db.Task.Create(task);
            await db.SaveAsync();


        }

            public void Dispose()
        {
            db.Dispose();
        }
    }
}
