using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishSchool.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Введите логин")]
        public string UserName { get; set; }
        [UIHint("password")]
        [Display(Name = "Введите пароль")]
        public string Password { get; set; }
        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}
