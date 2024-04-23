using Microsoft.EntityFrameworkCore;
using TaskManager.Context;

namespace TaskManager.Data
{
    public class TaskService
    {
        private readonly ApplicationDBContext _applicationdbContext;
        public TaskService(ApplicationDBContext applicationDBContext) 
        { 
            _applicationdbContext = applicationDBContext;
        }

        //Get all tasks
        public async Task<List<Task>> GetAllTasks()
        {
            return await _applicationdbContext.Tasks.ToListAsync();
        }

        //Add new task record
        public async Task<bool> AddNewTask(Task t)
        {
            await _applicationdbContext.Tasks.AddAsync(t);
            await _applicationdbContext.SaveChangesAsync();
            return true;
        }

        //Update task record
        public async Task<bool> UpdateTaskDetails(Task t)
        {
            _applicationdbContext.Tasks.Update(t);
            await _applicationdbContext.SaveChangesAsync();
            return true;
        }

        //Delete task record
        public async Task<bool> DeleteTasks(Task t)
        {
            _applicationdbContext.Tasks.Remove(t);
            await _applicationdbContext.SaveChangesAsync();
            return true;
        }
    }
}
