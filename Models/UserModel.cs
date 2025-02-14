using System.ComponentModel.DataAnnotations;

namespace Quiz1.Models
{
    public class UserModel
    {
        [Required]
        public int UserID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public int Password { get; set; }


        [Required]
        public string Email { get; set; }

        [Required]
        public int Mobile { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public DateTime Modified { get; set; }

    }
}
