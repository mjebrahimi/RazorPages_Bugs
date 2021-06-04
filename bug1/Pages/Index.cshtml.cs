using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace New_folder.Pages
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public void OnPostHandler1()
        {
            Message = "This is test!";
        }

        public void OnPostHandler2()
        {
            if (Message != "This is test!")
                throw new();
        }
    }
}
