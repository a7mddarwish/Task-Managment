using System.Threading.Tasks;
using TaskMS.AccessData.Entites;

namespace TaskMS.Business.ServicesConstracts
{
    public interface ITaskService
    {
        public Task<List<task>> GetAllTasks();
    }
}
