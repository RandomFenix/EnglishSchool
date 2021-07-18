﻿using EnglishSchool.Data.Entities;
using EnglishSchool.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Repositories.EntityFramework
{
    public class EFCourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public EFCourseRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IQueryable<Course> GetCourses()
        {
            return applicationDbContext.Courses.OrderBy(course => course.Title);
        }

        public async Task<Course> GetCourseByIdAsync(Guid id)
        {
            Course result = await applicationDbContext.Courses.FirstOrDefaultAsync(course => course.Id == id);
            return result;
        }

        public Guid SaveCourse(Course entity)
        {
            if (entity.Id == default)
                applicationDbContext.Entry(entity).State = EntityState.Added;
            else
                applicationDbContext.Entry(entity).State = EntityState.Modified;
            applicationDbContext.SaveChanges();
            return entity.Id;
        }

        public void DeleteCourse(Course entity)
        {
            applicationDbContext.Courses.Remove(entity);
            applicationDbContext.SaveChanges();
        }
    }
}
