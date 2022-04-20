using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SiteWeb.Pages
{
    public class CategorieModel : PageModel
    {
        private ILogger<CategorieModel> _logger;

        public CategorieModel(ILogger<CategorieModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
public int Id { get; set; }
public string Nom { get; set; }