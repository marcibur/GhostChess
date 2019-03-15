using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GhostChess.Web.Pages
{
    [Authorize]
    public class GameModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}
