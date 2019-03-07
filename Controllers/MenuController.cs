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
            List<Catagory> NavBar = dbContext.Catagories
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
        [Route("catagory/{catagoryid}")]
        public IActionResult SelectCatagory(String catagoryid)
        {

            if(catagoryid == "ViewAll")
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

                if(Int32.TryParse(catagoryid, out int x))
                {
                    Catagory selectedCat = dbContext.Catagories
                                        .Where(c => c.CatagoryId == x)
                                        .FirstOrDefault();
                    selectedCat.Active = true;
                }
            }

            dbContext.SaveChanges();
            return Redirect("/");
        }

    }
}
