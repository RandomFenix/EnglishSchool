using EnglishSchool.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data
{
    public class DataManager
    {
        public IGalleryRepository Images { get; set; }
        public ITextFieldsRepository TextFields { get; set; }
        public ICourseRepository Courses { get; set; }
        public ITimetableRepository Events { get; set; }

        public DataManager(IGalleryRepository galleryRepository, ITextFieldsRepository textFieldsRepository, ICourseRepository courseRepository, ITimetableRepository dateEventsRepository)
        {
            Images = galleryRepository;
            TextFields = textFieldsRepository;
            Courses = courseRepository;
            Events = dateEventsRepository;
        }
    }
}
