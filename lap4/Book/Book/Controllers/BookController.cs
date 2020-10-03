using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Book.Models;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;

namespace Book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public IActionResult Create()
        {
            return View();
        }

 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(
            [Bind("ID,Title,ReleaseDate,Cost")] BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectAction("Index");
            }
            return View(bookModel);
        }

        private IActionResult RedirectAction(string v)
        {
            throw new NotImplementedException();
        }

        private IActionResult View(BookModel bookModel)
        {
            throw new NotImplementedException();
        }
    }  
}
