using EnglishSchool.Data.Entities;
using EnglishSchool.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Repositories.EntityFramework
{
    public class EFTimetableRepository : ITimetableRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EFTimetableRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public Timetable GetEventsById(Guid id)
        {
            return applicationDbContext.DateEvents.FirstOrDefault(x => x.Id == id);
        }
        public void SaveEvent(Timetable entity)
        {
            if (entity.Id == default)
                applicationDbContext.Entry(entity).State = EntityState.Added;
            else
                applicationDbContext.Entry(entity).State = EntityState.Modified;
            applicationDbContext.SaveChanges();
        }
        public void DeleteEvent(Timetable entity)
        {

        }
        public IQueryable<Timetable> GetDateEvents()
        {
            return applicationDbContext.DateEvents.OrderBy(x => x.Id);
        }
    }
}
