using Sinemapp.Data;
using Sinemapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Service
{
    public class NewsService : INewsService
    {
        private readonly IRepository<News> newsRepository;
        private readonly IUnitOfWork unitOfWork;
        public NewsService(IRepository<News> newsRepository, IUnitOfWork unitOfWork)
        {
            this.newsRepository = newsRepository;
            this.unitOfWork = unitOfWork;
        }
        public bool Any(Guid id)
        {
            return newsRepository.Any(x => x.Id == id);
        }

        public void Delete(Guid id)
        {
            var news = newsRepository.Get(id);
            if (news != null)
            {
                newsRepository.Delete(news);
                unitOfWork.SaveChanges();
            }
        }

        public News Get(Guid id)
        {
            return newsRepository.Get(id);
        }

        public IEnumerable<News> GetAll()
        {
            return newsRepository.GetAll();
        }

        public void Insert(News news)
        {
            newsRepository.Insert(news);
            unitOfWork.SaveChanges();
        }

        public void Update(News news)
        {
            newsRepository.Update(news);
            unitOfWork.SaveChanges();
        }
    }
    public interface INewsService
    {
        IEnumerable<News> GetAll();
        News Get(Guid id);
        void Insert(News news);
        void Update(News news);
        void Delete(Guid id);
        bool Any(Guid id);
    }
}
