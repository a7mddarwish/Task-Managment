using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMS.AccessData.Data;
using TaskMS.AccessData.Entites;
using TaskMS.Business.ServicesConstracts;

namespace TaskMS.Business.Services
{
    public class TaskService : ITaskService
    {
        private AppDbContext context;

        public TaskService(AppDbContext Context)
        {
            context = Context;
        }
      
        public async Task<List<task>> GetAllTasks() =>
               await context.tasks.ToListAsync();


      

    }
}
