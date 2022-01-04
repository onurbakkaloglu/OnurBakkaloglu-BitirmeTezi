using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ÜniversiteSite.Models;

namespace ÜniversiteSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly Context dbContext;

        public BlogController(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Blog>>> Get()
        {
            return await dbContext.Blogs.ToListAsync();
        }
        [HttpGet("{id}",Name = "GetBlog")]
        public async Task<ActionResult<Blog>> Get(int id)
        {
            return await dbContext.Blogs.FirstOrDefaultAsync(x => x.Id == id);
        }
        [HttpPost]
        public async Task<ActionResult> Post(Blog blog)
        {
            dbContext.Add(blog);
            await dbContext.SaveChangesAsync();
            return new CreatedAtRouteResult("GetBlog", new { id = blog.Id }, blog);
        }
        [HttpPut]
        public async Task<ActionResult> Put(Blog blog)
        {
            dbContext.Entry(blog).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("(id")]
        public async Task<ActionResult> Delete(int id)
        {
            var blog = new Blog { Id = id };
            dbContext.Remove(blog);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
