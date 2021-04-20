using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapplication.Models;

namespace webapplication.Services
{
    public interface IListService
    {
        public bool Create(PMLList pMLList);
        public List<PMLList> GetAllLists();
        public PMLList GetById(Guid? id);
        public bool Update(PMLList pMLList);
        public bool Delete(Guid id);


    }
}
