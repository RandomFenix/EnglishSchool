using EnglishSchool.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Repositories.Abstract
{
    public interface ITimetableRepository
    {
        IQueryable<Timetable> GetDateEvents();
        Timetable GetEventsById(Guid id);
        void SaveEvent(Timetable entity);
        void DeleteEvent(Timetable entity);
    }
}
