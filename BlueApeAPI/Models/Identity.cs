using AspNetCore.Identity.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueApeAPI.Models.Identity
{
    public class ApplicationRole : MongoIdentityRole
    {

    }
    public class ApplicationUser : MongoIdentityUser
    {
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
