using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Data.Entities
{
    public class Request
    {
        [Display(Name = "Ваше имя")]
        public string PersonName { get; set; }
        [Display(Name = "Ваша фамилия")]
        public string PersonSurname { get; set; }
        [Display(Name = "Электронный адрес")]
        [DataType(DataType.EmailAddress)]
        public string PersonEmail { get; set; }
        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        public string PersonPhone { get; set; }
        [Display(Name = "Выбрать курс")]
        [UIHint("Collection")]
        public string NameCourse { get; set; }
        [Display(Name = "Имя ребенка")]
        public string ChildName { get; set; }
        [Display(Name = "Возраст ребенка")]
        public uint ChildAge { get; set; }
        [Display(Name = "Знает ли ребенок животных, цвета, цифры, предметы в доме")]
        [UIHint("Collection")]
        public bool ChildKnowledge { get; set; }
        [Display(Name = "Увлечения ребенка")]
        public string ChildHobby { get; set; }
        [Display(Name = "Любимый персонаж")]
        public string FavouriteCharacter { get; set; }
        [Display(Name = "Что ребенок не любит")]
        public string ThingsNotLike { get; set; }

    }
}
