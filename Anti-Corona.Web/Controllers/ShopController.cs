﻿using Anti_Corona.Business.Abstract;
using Anti_Corona.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Controllers
{
    public class ShopController : Controller
    {
        
        private ICategoryService _categoryService;
        private IProductService _productService;
        public ShopController(ICategoryService categoryService,IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public IActionResult Index(string url)
        {
            ViewBag.Categories = _categoryService.GetAllCategories();
            return View(new ShopViewModel()
            {
                 mostPopularProducts= _productService.GetMostPopularProducts().Select(i=> new PopularProduct()
                 {
                     CategoryName=i.Category.Name,
                     Title=i.Title,
                     Price= (double)i.Price,
                     ImageUrl=i.Images[0].ImageUrl

                 }).ToList(),
                 products=_productService.GetAllProducts(url).Select(i=> new Product()
                 {
                     Price= (double)i.Price,
                     Title=i.Title,
                     ImageUrl=i.Images[0].ImageUrl
                     
                 }).ToList(),
                 
            });
        }
    }
}
