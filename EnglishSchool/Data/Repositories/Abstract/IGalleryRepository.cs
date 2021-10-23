using EnglishSchool.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Repositories.Abstract
{
    public interface IGalleryRepository
    {
        IQueryable<Gallery> GetImages();
        Gallery GetImagesById(Guid id);
        void SaveImage(Gallery entity);
        void DeleteImage(Gallery entity);
    }
}
