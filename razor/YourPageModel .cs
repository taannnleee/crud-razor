using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor
{
    public class YourPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public YourPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            // Truy vấn dữ liệu từ database
        }
    }
}
