using EnglishSchool.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishSchool.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<TextField> TextFields { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "047E7E08-BA55-4BB3-A7B8-3426AD2884D2",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3DF7F7A1-CA6D-450C-8D23-368958CA5904",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "047E7E08-BA55-4BB3-A7B8-3426AD2884D2",
                UserId = "3DF7F7A1-CA6D-450C-8D23-368958CA5904"
            });

            builder.Entity<Course>().HasData(new Course
            {
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                Title = "Базовый уровень",
                Description = "Программа для начального изучения английскому языку",
                ImageURL = "https://images.pexels.com/photos/256417/pexels-photo-256417.jpeg?cs=srgb&dl=pexels-pixabay-256417.jpg&fm=jpg"
            });
            builder.Entity<Gallery>().HasData(new Gallery
            {
                Id = new Guid("E44B5BD3-FFB0-45A0-A1E5-3D7F8497AFAF"),
                Title = "Первое фото",
                ImageURL = "https://images.pexels.com/photos/267669/pexels-photo-267669.jpeg?cs=srgb&dl=pexels-pixabay-267669.jpg&fm=jpg"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("1F2DBF89-4137-487E-9A45-535D002D68C0"),
                CodeWord = "PageHome",
                Title = "Курсы"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("D9AB7AEB-F309-4DDE-986D-18456F6E26B5"),
                CodeWord = "PageGallegy",
                Title = "Галерея"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("A66318D7-27E9-47D4-A461-B3A6CAB89323"),
                CodeWord = "PageTimetable",
                Title = "Расписание"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("FD4880DE-40BF-49E1-87E9-44BC45AE8546"),
                CodeWord = "PageAbout",
                Title = "Преподаватель"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("9E66054E-9230-49E4-A52B-B55A00AF64E3"),
                CodeWord = "PageRequest",
                Title = "Заявка"
            });
        }
    }
}
