using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogsController : ControllerBase
    {
        private readonly BloggingContext _context;

        public BlogsController(BloggingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllBlogs()
        {
            var blogs = _context.Blogs
                .Include(b => b.Posts)
                .ThenInclude(p => p.Comments)
                .ToList();
            return Ok(blogs);
        }


        [HttpGet("{id}")]
        public IActionResult GetBlogById(int id)
        {
            var blogs = _context.Blogs.FirstOrDefault(b => b.BlogId == id);//todo verify why Lazy loading is not working as expected

            var blogWithSelect = _context.Blogs
                .Select(b => new {b.BlogId, b.Url1})
                .FirstOrDefault(b => b.BlogId == id);

            return Ok(blogs);
        }

        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return Ok(blog);
        }

        [HttpPut()]
        public IActionResult UpdateBlog(Blog blog)
        {
            var blogToUpdate = _context.Blogs.FirstOrDefault(b => b.BlogId == blog.BlogId);
            if (blogToUpdate == null)
            {
                return NotFound(blog.BlogId);
            }

            blogToUpdate.Title = blog.Title;
            blogToUpdate.Url1 = blog.Url1;
            _context.Blogs.Update(blogToUpdate);
            _context.SaveChanges();
            return Ok(blog);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            var blog = _context.Blogs.FirstOrDefault(b => b.BlogId == id);
            if (blog == null)
            {
                return NotFound(id);
            }

            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}/posts")]
        public IActionResult GetPostsByBlogId(int id)
        {
            var comment = _context.Comments.Include(c => c.Post).ToList();
            var posts = _context.Posts.Include(p => p.Comments).Where(p => p.BlogId == id).ToList();
            return Ok(posts);
        }
    }
}
