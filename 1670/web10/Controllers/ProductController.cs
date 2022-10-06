﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using web10.Data;

namespace web10.Controllers
{
    public class ProductController : Controller
    {
        //khai báo ApplicationDbContext
        private readonly ApplicationDbContext context;

        //khai báo constructor để khởi tạo ApplicationDbContext
        public ProductController (ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        //SQL: SELECT * FROM Product
        //READ function
        public IActionResult Index()
        {
            var products = context.Product.ToList();
            return View(products);
        }
    }
}
