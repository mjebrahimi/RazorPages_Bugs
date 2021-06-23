using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace New_folder__2_.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public PersonCreate PersonCreate { get; set; }
        public void OnPostCreate()
        {
            var isValid = ModelState.IsValid;
        }

        [BindProperty]
        public PersonUpdate PersonUpdate { get; set; }
        public void OnPostUpdate()
        {
            var isValid = ModelState.IsValid;
        }
    }

    public class PersonCreate
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }

    public class PersonUpdate
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
