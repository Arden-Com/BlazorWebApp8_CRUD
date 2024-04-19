using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlazorWebApp8_CRUD.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full Name"), StringLength(30)]
        public string? FullName { get; set; }
        [Display(Name = "Birth Date")]
        public DateOnly? BirthDate { get; set; }
    }

}
