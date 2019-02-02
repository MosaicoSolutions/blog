﻿using System.Threading.Tasks;
using MosaicoSolutions.Blog.Domain.Models;
using MosaicoSolutions.Blog.Domain.Repositories;
using MosaicoSolutions.Blog.Infra.Data.MongoDBProvider.Contexts;

namespace MosaicoSolutions.Blog.Infra.Data.Repositories
{
    public class PostRepository : MongoDBRepository<Post>, IPostRepository
    {
        public PostRepository(MongoDBContext mongoDBContext) : base(mongoDBContext)
        {}
    }
}
