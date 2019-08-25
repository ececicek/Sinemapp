using Sinemapp.Data;
using Sinemapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Service
{
    public class FilmService : IFilmService
    {
        private readonly IRepository<Film> filmRepository;
        private readonly IUnitOfWork unitOfWork;
        public FilmService(IRepository<Film> filmRepository, IUnitOfWork unitOfWork)
        {
            this.filmRepository = filmRepository;
            this.unitOfWork = unitOfWork;
        }
        public bool Any(Guid id)
        {
            return filmRepository.Any(x => x.Id == id);
        }

        public void Delete(Guid id)
        {
            var film = filmRepository.Get(id);
            if (film != null)
            {
                filmRepository.Delete(film);
                unitOfWork.SaveChanges();
            }
        }

        public Film Get(Guid id)
        {
            return filmRepository.Get(id);
        }

        public IEnumerable<Film> GetAll()
        {
            return filmRepository.GetAll();
        }

        public void Insert(Film film)
        {
            filmRepository.Insert(film);
            unitOfWork.SaveChanges();
        }

        public void Update(Film film)
        {
            filmRepository.Update(film);
            unitOfWork.SaveChanges();
        }
    }
    public interface IFilmService
    {
        IEnumerable<Film> GetAll();
        Film Get(Guid id);
        void Insert(Film film);
        void Update(Film film);
        void Delete(Guid id);
        bool Any(Guid id);
    }
}
