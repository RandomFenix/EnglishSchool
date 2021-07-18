using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Entities
{
    public class Gallery
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [Display (Name = "Название фото")]
        public string Title { get; set; }
        [Display(Name = "Фото")]
        public string ImageURL { get; set; }
    }
}
