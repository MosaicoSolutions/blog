using System.Collections.Generic;

namespace MosaicoSolutions.Blog.Domain.Core.Models
{
    public interface IPage<TRentity> where TRentity : class
    {
        IEnumerable<TRentity> Data { get; }
        int RecordsTotal { get; }
        int RecordsFiltered { get; }
    }
}
