using demo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace demo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //tạo bảng (DB) tương ứng model (Code)
        //Student: tên của Model (design của bảng)
        //Students: tên của bảng & tên của DbSet (collection) được gọi đến trong Controller
        public DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //add dữ liệu tự động vào DB bằng code
            builder.Entity<Student>().HasData(
                //bắt buộc phải nhập giá trị cho cột Id (PK)
                //những thuộc tính set là "Required" ở trong file Model thì bắt buộc phải nhập
                //còn lại không bắt buộc. Thứ tự khai báo các thuộc tính không quan trọng
                new Student
                {
                    Id = 1, //Id bắt buộc phải khác nhau
                    Name = "Nam",
                    Mobile = "0912345678",
                    Email = "nam@gmail.com",
                    Gender = 'M',
                    Grade = 7.8,
                    IsGraduated = true,
                    SId = "GCH12345",
                    Image = "https://d2jyir0m79gs60.cloudfront.net/news/images/successful-college-student-lg.png",
                    Birthday = DateTime.Parse("2000-04-06")  //YYYY-MM-DD
                },
                new Student
                {
                    Id = 2, 
                    Name = "Huong",
                    Mobile = "0912345678",
                    Email = "nam@gmail.com",
                    Gender = 'F',
                    Grade = 7.8,
                    IsGraduated = true,
                    SId = "GCH12345",
                    Image = "https://content.gallup.com/origin/gallupinc/GallupSpaces/Production/Cms/EDUCMS/tz7n-7vqceaq86dprdnzag.jpg",
                    Birthday = DateTime.Parse("2000-04-06")
                },
                new Student
                {
                    Id = 3,
                    Name = "Minh",
                    Mobile = "0912345678",
                    Email = "nam@gmail.com",
                    Gender = 'M',
                    Grade = 7.8,
                    IsGraduated = true,
                    SId = "GCH12345",
                    Image = "https://img.freepik.com/free-photo/front-view-male-student-dark-t-shirt-yellow-backpack-holding-files-books-smiling-light-blue-wall_140725-46715.jpg?w=2000",
                    Birthday = DateTime.Parse("2000-04-06")
                }
            );
        }

    }
}
