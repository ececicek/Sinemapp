using Sinemapp.Data;
using Sinemapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Service
{
    public class GenreService : IGenreService
    {
        private readonly IRepository<Genre> genreRepository;
        private readonly IUnitOfWork unitOfWork;
        public GenreService(IRepository<Genre> genreRepository, IUnitOfWork unitOfWork)
        {
            this.genreRepository = genreRepository;
            this.unitOfWork = unitOfWork;
        }
        public bool Any(Guid id)
        {
            return genreRepository.Any(x => x.Id == id);
        }

        public void Delete(Guid id)
        {
            var genre = genreRepository.Get(id);
            if (genre != null)
            {
                genreRepository.Delete(genre);
                unitOfWork.SaveChanges();
            }
        }

        public Genre Get(Guid id)
        {
            return genreRepository.Get(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return genreRepository.GetAll();
        }

        public void Insert(Genre genre)
        {
            genreRepository.Insert(genre);
            unitOfWork.SaveChanges();
        }

        public void Update(Genre genre)
        {
            genreRepository.Update(genre);
            unitOfWork.SaveChanges();
        }
    }
    public interface IGenreService
    {
        IEnumerable<Genre> GetAll();
        Genre Get(Guid id);
        void Insert(Genre genre);
        void Update(Genre genre);
        void Delete(Guid id);
        bool Any(Guid id);
    }

}
