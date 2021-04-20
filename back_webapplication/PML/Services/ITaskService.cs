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
        public PMLTask GetById(string id);
        public bool Update(PMLTask task);
        public bool Delete(string id);
        public bool ChangeStatus(string id);
        public List<PMLTask> GetByListId(string id);

    }
}
