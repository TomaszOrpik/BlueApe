using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlueApeAPI.DTOs
{
    public class UserDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Password must be between {2} and {1} characters", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
