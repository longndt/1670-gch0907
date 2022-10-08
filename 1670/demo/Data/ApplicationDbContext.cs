using demo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace demo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //tạo bảng
        //Student: tên của Model (design của bảng)
        //Students: tên của bảng & tên của DbSet (collection) được gọi đến trong Controller
        public DbSet<Student> Students { get; set; }
    }
}
