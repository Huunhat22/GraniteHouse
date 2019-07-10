using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Granite_House.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Granite_House.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypeController : Controller
    {
        private readonly GraniteHouseContext _context;

        public ProductTypeController(GraniteHouseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}