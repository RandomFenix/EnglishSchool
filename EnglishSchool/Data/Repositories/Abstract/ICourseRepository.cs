using EnglishSchool.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Repositories.Abstract
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        Course GetCourseById(Guid id);
        void SaveCourse(Course entity);
        void DeleteCourse(Course entity);
    }
}
