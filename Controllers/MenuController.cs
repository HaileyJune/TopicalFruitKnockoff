using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TopicalFruitKnockoff.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TopicalFruitKnockoff.Controllers
{
    public class MenuController : Controller
    {
        private FrootsContext dbContext;

    // here we can "inject" our context service into the constructor
        public MenuController(FrootsContext context)
        {
            dbContext = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<String> NavBar = dbContext.Catagories
                                    .Select(c => c.Name)
                                    .ToList();
            ViewBag.NavBar = NavBar;

            List<Catagory> Menu = dbContext.Catagories
                                    .Where(c => c.Active)
                                    .Include(c => c.Items)
                                    .ToList();
            ViewBag.Menu = Menu;

            return View();
        }

        [HttpGet]
        [Route("catagory/{catagory}")]
        public IActionResult SelectCatagory(String selected)
        {

            if(selected == "ViewAll")
            {
                foreach (Catagory cat in dbContext.Catagories)
                {
                    cat.Active = true;
                }
            }
            else
            {
                foreach (Catagory cat in dbContext.Catagories)
                {
                    cat.Active = false;
                }

                Catagory selectedCat = dbContext.Catagories
                                    .Where(c => c.Name == selected)
                                    .FirstOrDefault();
                selectedCat.Active = true;
            }

            return Redirect("/");
        }

    }
}
