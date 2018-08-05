using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nextech.Domain;
using Nextech.Data;

namespace Nextech.Framework
{
    public class HackerNewsService : IHackerNewsService
    {
        IHakerNewsRepository<Article> _repository;

        public HackerNewsService(IHakerNewsRepository<Article> repository)
        {
            _repository = repository ?? throw new ArgumentNullException($"{nameof(HackerNewsService)} Not Initialized properly.  Missing dependency: {nameof(repository)}");
        }
        public async Task<IEnumerable<Article>> GetBestStories()
        {
            var ids = await _repository.ReadIdsasync();
            List<Task<Article>> tasks = new List<Task<Article>>();
            foreach(int id in ids)
            {
                tasks.Add(_repository.ReadItemasync(id));
            }
            IEnumerable<Article> articles = await Task.WhenAll(tasks) as IEnumerable<Article>;
            return articles;
        }
    }
}
