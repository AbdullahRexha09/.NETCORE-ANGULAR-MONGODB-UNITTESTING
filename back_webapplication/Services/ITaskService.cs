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
        public PMLTask Update(PMLTask task, Guid id);
        public PMLTask Delete(Guid id);

    }
}
