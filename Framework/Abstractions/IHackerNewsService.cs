using System;
using System.Collections.Generic;
using System.Text;
using Nextech.Data;
using Nextech.Domain;
using System.Threading.Tasks;

namespace Nextech.Framework
{
    public interface IHackerNewsService
    {
        Task<IEnumerable<Article>> GetBestStories();
    }
}
