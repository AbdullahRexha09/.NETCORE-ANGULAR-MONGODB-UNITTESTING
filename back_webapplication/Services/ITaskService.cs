using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public interface ITaskService
    {
        public bool Create(PMLTask task);
        public List<PMLTask> GetAllTasks();
        public PMLTask Update(PMLTask task, Guid id);
        public bool Delete(Guid id);
        public bool ChangeStatus(Guid id);

    }
}
