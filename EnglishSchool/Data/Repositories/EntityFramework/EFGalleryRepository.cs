using EnglishSchool.Data.Entities;
using EnglishSchool.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Repositories.EntityFramework
{
    public class EFGalleryRepository : IGalleryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public EFGalleryRepository (ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public IQueryable<Gallery> GetImages()
        {
            return applicationDbContext.Galleries.OrderBy(image => image.Title);
        }

        public Gallery GetImagesById(Guid id)
        {
            return applicationDbContext.Galleries.FirstOrDefault(image => image.Id == id);
        }

        public void SaveImage(Gallery entity)
        {
            if (entity.Id == default)
                applicationDbContext.Entry(entity).State = EntityState.Added;
            else
                applicationDbContext.Entry(entity).State = EntityState.Modified;
            applicationDbContext.SaveChanges();
        }

        public void DeleteImage(Gallery entity)
        {
            applicationDbContext.Galleries.Remove(entity);
            applicationDbContext.SaveChanges();
        }

    }
}
