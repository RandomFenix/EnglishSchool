using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Entities
{
    public class TextField
    {
        public Guid Id { get; set; }
        public string CodeWord { get; set; }
        [Display (Name ="Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Заголовок")]
        public string Text { get; set; } = "заполняется администратором";
    }
}
