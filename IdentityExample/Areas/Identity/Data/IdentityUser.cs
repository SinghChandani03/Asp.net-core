using Microsoft.AspNetCore.Identity;

namespace IdentityExample.Areas.Identity.Data
{
    // Rename to avoid naming conflict with Microsoft.AspNetCore.Identity.IdentityUser
    public class ApplicationUser : IdentityUser
    {
        // Add any additional custom properties here
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
