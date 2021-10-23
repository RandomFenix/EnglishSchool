using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Entities
{
    public class Timetable
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Имя ребенка")]
        public string ChildName { get; set; }
        [Required]
        [Display(Name = "День")]
        [UIHint("Collection")]
        public int Day { get; set; }
        [Display(Name = "Месяц")]
        [UIHint("Collection")]
        public string Month { get; set; }
        [Required]
        [Display(Name = "Время")]
        public string Time { get; set; }
        [NotMapped]
        public List<int> Days = new List<int>();
        [NotMapped]
        public List<string> Months = new List<string> { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
    }
}
