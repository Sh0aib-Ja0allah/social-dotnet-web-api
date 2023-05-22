using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClassLibrary.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(5000)]
        public string Body { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }

        public int Post_Id { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        [InverseProperty("Comments")]        
        public User? User { get; set; }
        [ForeignKey("Post_Id")]
        [InverseProperty("Comments")]
        public Post? Post { get; set; }




    }
}
