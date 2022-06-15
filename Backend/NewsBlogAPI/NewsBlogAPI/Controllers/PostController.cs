using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsBlogAPI.Dto;
using NewsBlogAPI.Helpers;
using NewsBlogAPI.Models;

namespace NewsBlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly INewsRepository _repository;

        public PostController(INewsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllPost()
        {
            return Ok(_repository.getAllPost());
        }

        [HttpGet("{id}")]
        public IActionResult GetPostById(int id)
        {
            return Ok(_repository.getPostByID(id));
        }

        [HttpPost("createpost")]
        public IActionResult CreatePost(CreatePostDto dto)
        {
            var newPost = new NewsPost()
            {
                Title = dto.Title,
                Description = dto.Description,
            };

            return Created("CreatePost",_repository.CreatePost(newPost));
        }

        [HttpPut("updatepost")]
        public IActionResult UpdatePost(NewsPost post)
        {
            return Ok(_repository.UpdatePost(post));
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            _repository.DeletePost(id);

            return NoContent();
        }
    }
}
