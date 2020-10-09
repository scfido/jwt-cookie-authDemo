using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AuthDemo.Pages
{
    [Authorize]
    public class TokenModel : PageModel
    {
        private readonly ILogger<TokenModel> _logger;

        public string UserName { get; set; }  

        public TokenModel(ILogger<TokenModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            UserName = HttpContext.User.FindFirstValue(ClaimTypes.Name);
        }
    }
}
