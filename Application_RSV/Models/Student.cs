using Microsoft.AspNetCore.Identity;

namespace Application_RSV.Models
{
    public class Student : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Count { get; set; }
    }
}