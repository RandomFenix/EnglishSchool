using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Services
{
    public class SharedModelsToView
    {
        public IQueryable<Data.Entities.Course> Courses { get; set; }
        public Data.Entities.Course course { get; set; } 
        public Data.Entities.Request request { get; set; }
    }
}
