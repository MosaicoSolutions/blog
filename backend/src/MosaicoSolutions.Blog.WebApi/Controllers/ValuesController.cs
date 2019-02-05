using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MosaicoSolutions.Blog.Domain.Models;
using MosaicoSolutions.Blog.Infra.Data.Contexts;
using MosaicoSolutions.Blog.Infra.Data.Contexts.Options;

namespace MosaicoSolutions.Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : BlogApiController
    {
        public ValuesController(BlogContext context, IMediator mediator): base(mediator)
        {
            var contextLocal = context;

            //var collection = context.GetCollection<Post>();

            //collection.InsertOne(new Post
            //{
            //    Title = "Primeiro Post",
            //    Body = "Isto é apenas um Texto",
            //    Category = "Teste",
            //    Image = "photo-1524721696987-b9527df9e512.jpg",
            //    Tags = new []
            //    {
            //        "TestandoApp",
            //        "PrimeiroPost"
            //    }
            //});
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
