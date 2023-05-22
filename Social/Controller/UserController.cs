using Microsoft.AspNetCore.Mvc;
using SocialClassLibrary.Interfaces;
using SocialClassLibrary.Models;

namespace Social.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<User>))]

        public IActionResult GetUsers()
        {
            var users = _userRepository.GetUsers();
            //var users = new List<User>
            //{
            //    new User {
            //        Id = 1,
            //        FirstName = "Shoaib",
            //        LastName = "Jadallah",
            //        Comments = new List<Comment>
            //        {
            //            new Comment {
            //                Id = 1,
            //                Body = "Hello World!",
            //                Date = DateTime.Now,
            //                Post_Id = 1,
            //                User_Id = 1,
                            
            //            }
            //        },
            //        Posts = new List<Post> 
            //        {
            //            new Post
            //            {
            //                Id = 1,
            //                Title = "Greeting.",
            //                User_Id= 1,
            //                Date = DateTime.Now,
            //            }
            //        }
            //    }
            //};    // API Testing Data . . .

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(users);
        }
    }
}
