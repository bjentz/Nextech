using System;
using System.Collections.Generic;
using System.Text;
using Nextech.Domain;
using System.Threading.Tasks;

namespace Nextech.Data
{
    public interface IHakerNewsRepository<T> where T : INextechDomain
    {
        Task<IEnumerable<int>> ReadIdsasync();
        Task<T> ReadItemasync(int Id);
    }

   
}
