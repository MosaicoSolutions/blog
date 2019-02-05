using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MosaicoSolutions.Blog.Application.MediatR.Request;
using MosaicoSolutions.Blog.Application.Queries;
using MosaicoSolutions.Blog.Application.ViewModels;
using MosaicoSolutions.Blog.Domain.Core.Models;
using System.Threading.Tasks;

namespace MosaicoSolutions.Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PostController : BlogApiController
    {
        public PostController(IMediator mediator) : base(mediator)
        { }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetPage([FromQuery] PostPagingQuery query)
            => Ok(await mediator.Send(new PostPagingRequest(query)));
    }
}