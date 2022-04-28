using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore2.Models;

namespace EFCore2.Controllers
{
    public class BookController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
           
        }
        public IActionResult create(Books b)
        {
            if (ModelState.IsValid)
            {
                BookDbContext dbc = new BookDbContext();
                dbc.Add(b);
                dbc.SaveChanges();
                return View(b);
            }
            return View ("Index");
           }
    }
}
