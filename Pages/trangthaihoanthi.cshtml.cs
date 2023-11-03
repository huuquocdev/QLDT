using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class trangthaihoanthiModel : PageModel
    {
        private readonly ILogger<trangthaihoanthiModel> _logger;

        public trangthaihoanthiModel(ILogger<trangthaihoanthiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}