using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nextech.Data;
using Nextech.Domain;
using Nextech.Framework;


namespace NexTechAPI.Controllers
{
    [Produces("application/json")]
    public class HakerNewsController : Controller
    {
        private IHackerNewsService _service;

        public HakerNewsController(IHackerNewsService service)
        {
            _service = service ?? throw new ArgumentNullException($"{nameof(HackerNewsService)} Not Initialized properly.  Missing dependency: {nameof(service)}");
            //normally all error messages would go in a resource file somewhere
        }
        [HttpGet]
        [Route("api/hackernews/best-stories")]
        public Task<IEnumerable<Article>> Get()
        {
            return _service.GetBestStories();
        } 
    }
}