using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MosaicoSolutions.Blog.Application.Queries;
using System.Threading.Tasks;

namespace MosaicoSolutions.Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PostController : BlogApiController
    {
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetPage([FromQuery] PostPagingQuery query)
        {
            return Ok(query);
        }
    }
}