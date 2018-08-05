using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentAssertions;
using Nextech.Data;
using Nextech.Framework;
using Nextech.Domain;
using System.Linq;
using System;
using System.Threading.Tasks;


namespace NextechTests
{
    [TestClass]
    public class HackerNewsServiceTests
    {
        private Mock<IHakerNewsRepository<Article>> _mockRepo;
        private Article _article = new Article();
        private void init()
        {
            _article.by = "bjentz";
            _article.title = "The art of the Rick Roll";
            _article.url = "http://tinyurl.com/y8ufsnp ";

            _mockRepo = new Mock<IHakerNewsRepository<Article>>();
            _mockRepo.Setup(repo => repo.ReadIdsasync()).ReturnsAsync(new int[]{ 12345,67890});
            _mockRepo.Setup(repo => repo.ReadItemasync(It.IsAny<int>())).ReturnsAsync(_article);
        }
        [TestMethod]
        public void Service_Ctor_Should_Throw_Exception_If_Not_Initialized_Properly()
        {

            Action act = () => new HackerNewsService(null);

            act.Should().Throw<ArgumentNullException>();
            
        }

        [TestMethod]
        public async Task GetBestStories_Should_Return_List_Of_Articles()
        {
            init();
            HackerNewsService service = new HackerNewsService(_mockRepo.Object);

            var articles = await service.GetBestStories();

            articles.Should().HaveCount(2);
        }
    }
}
