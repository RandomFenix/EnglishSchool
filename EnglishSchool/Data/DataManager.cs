using EnglishSchool.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data
{
    public class DataManager
    {
        public IActivitiesRepository Activities { get; set; }
        public IGalleryRepository Images { get; set; }
        public ITextFieldsRepository TextFields { get; set; }
        public ICourseRepository Courses { get; set; }

        public DataManager(IActivitiesRepository activitiesRepository, IGalleryRepository galleryRepository, ITextFieldsRepository textFieldsRepository, ICourseRepository courseRepository)
        {
            Activities = activitiesRepository;
            Images = galleryRepository;
            TextFields = textFieldsRepository;
            Courses = courseRepository;
        }
    }
}
