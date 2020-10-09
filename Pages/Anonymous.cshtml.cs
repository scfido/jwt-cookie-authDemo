using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AuthDemo.Pages
{
    public class AnonymousModule : PageModel
    {
        private readonly ILogger<AnonymousModule> _logger;

        public AnonymousModule(ILogger<AnonymousModule> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
