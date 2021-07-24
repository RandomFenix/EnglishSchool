using EnglishSchool.Data.Entities;
using EnglishSchool.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public EFTextFieldsRepository (ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IQueryable<TextField> GetTextField()
        {
            return applicationDbContext.TextFields;
        }
        public TextField GetTextFieldById(Guid Id)
        {
            return applicationDbContext.TextFields.FirstOrDefault(x => x.Id == Id);
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return applicationDbContext.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
                applicationDbContext.Entry(entity).State = EntityState.Added;
            else
                applicationDbContext.Entry(entity).State = EntityState.Modified;
            applicationDbContext.SaveChanges();
        }
        public void DeleteTextField(Guid id)
        {
            applicationDbContext.TextFields.Remove(new TextField { Id = id });
            applicationDbContext.SaveChanges();

        }
    }
}
