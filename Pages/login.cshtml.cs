using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
namespace WebApplication4.Pages
{
    public class User
    {
        public string? username { get; set; }
        public string? password { get; set; }
    }
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            string doc = System.IO.File.ReadAllText("Data/account.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(doc);
            string? username = Request.Form["username"];
            string? password = Request.Form["password"];
            if (users.Any(x=>(x.username== username && x.password == password)))
            {
                Response.Redirect("/");
            }
            else
            {
                Response.Redirect("?failed=1");
            }
        }
    }
}