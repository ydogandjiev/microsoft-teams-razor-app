using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesMovie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }


        public ActionResult OnPostSave([FromBody] Person person)
        {
            return RedirectToPage("Index1");
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        public class PostData
        {
            public string Item1 { get; set; }
            public string Item2 { get; set; }
            public string Item3 { get; set; }

        }
    }
}
