using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using udacity_react_backend.Models;

namespace udacity_react_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        readonly DataContext _context;

        public ItemsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getItems")]
        public IActionResult GetItems() 
        {
            var items = _context.Items.ToList();
            return Ok();
        }

        [HttpPost]
        [Route("addItem")]
        public IActionResult AddItems(Item item) 
        {
            return Ok();
        }
    }
}