using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MosaicoSolutions.Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BlogApiController : ControllerBase
    {
        protected readonly IMediator mediator;

        public BlogApiController(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}