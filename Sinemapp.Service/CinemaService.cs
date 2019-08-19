using Sinemapp.Data;
using Sinemapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Service
{
    public class CinemaService : ICinemaService
    {
        private readonly IRepository<Cinema> cinemaRepository;
        private readonly IUnitOfWork unitOfWork;
        public CinemaService(IRepository<Cinema> cinemaRepository, IUnitOfWork unitOfWork)
        {
            this.cinemaRepository = cinemaRepository;
            this.unitOfWork = unitOfWork;
        }
        public bool Any(Guid id)
        {
            return cinemaRepository.Any(x => x.Id == id);
        }

        public void Delete(Guid id)
        {
            var cinema = cinemaRepository.Get(id);
            if (cinema != null)
            {
                cinemaRepository.Delete(cinema);
                unitOfWork.SaveChanges();
            }
        }

        public Cinema Get(Guid id)
        {
            return cinemaRepository.Get(id);
        }

        public IEnumerable<Cinema> GetAll()
        {
            return cinemaRepository.GetAll();
        }

        public void Insert(Cinema cinema)
        {
            cinemaRepository.Insert(cinema);
            unitOfWork.SaveChanges();
        }

        public void Update(Cinema cinema)
        {
            cinemaRepository.Update(cinema);
            unitOfWork.SaveChanges();
        }
    }
    public interface ICinemaService
    {
        IEnumerable<Cinema> GetAll();
        Cinema Get(Guid id);
        void Insert(Cinema cinema);
        void Update(Cinema cinema);
        void Delete(Guid id);
        bool Any(Guid id);
    }
}
