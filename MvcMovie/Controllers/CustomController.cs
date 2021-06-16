using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class CustomController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my custom action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Trudor()
        {
            return "This is the Trudor action method...";
        }
    }
}