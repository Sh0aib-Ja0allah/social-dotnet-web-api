using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClassLibrary.Models
{
    public class Post
    {
        public Post() 
        {
            Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(5000)]
        public string Title { get; set; } = string.Empty;
        [Required]
        public DateTime Date { get; set; }

        [InverseProperty("Post")]
        public ICollection<Comment>? Comments { get; set; }

        public int User_Id { get; set; }   
        [ForeignKey("User_Id")]
        [InverseProperty("Posts")]
        public User? User { get; set; }
    }
}
