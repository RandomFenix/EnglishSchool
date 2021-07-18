using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Entities
{
    public class Course
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Название курса")]
        public string Title { get; set; }
        [Display(Name = "Описание курса")]
        public string Description { get; set; }
        [Display(Name = "Ссылка на изображение")]
        public string ImageURL { get; set; }
    }
}
