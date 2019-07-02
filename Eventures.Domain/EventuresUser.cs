using Microsoft.AspNetCore.Identity;

namespace Eventures.Domain
{
    public class EventuresUser : IdentityUser
    {
        //•	First Name – a string.
        //•	Last Name – a string.
        //•	Unique Citizen Number(UCN) – a string.
               
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UCN { get; set; }

    }
}
