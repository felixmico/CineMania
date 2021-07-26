using System.Threading.Tasks;
using CineMania.Data;
using CineMania.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CineMania.Pages.Movies
{
    public class ContactModel : PageModel
    {
        private readonly CinemaniaContext _context;
        public ContactModel(CinemaniaContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty] 
        public Message Message { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Messages.Add(Message);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}