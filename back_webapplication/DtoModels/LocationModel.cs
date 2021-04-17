using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapplication.DtoModels
{
    public class LocationModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Guid CityId { get; set; }

    }
}
