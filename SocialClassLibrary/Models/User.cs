using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClassLibrary.Models
{
    public class User
    {
        public User() 
        { 
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [StringLength(25)]
        public string LastName { get; set; } = string.Empty;
        [InverseProperty("User")]
        public ICollection<Post> Posts { get; set; }
        [InverseProperty("User")]
        public ICollection<Comment>  Comments { get; set; }




    }
}
