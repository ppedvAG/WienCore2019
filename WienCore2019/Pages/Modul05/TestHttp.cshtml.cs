using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class TestHttpModel : PageModel
    {
        public void OnGet()
        {
            
            HttpContext.Response.StatusCode = 404;
        }
    }
}