using Sinemapp.Data;
using Sinemapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemapp.Service
{
    public class CastService : ICastService
    {
        private readonly IRepository<Cast> castRepository;
        private readonly IUnitOfWork unitOfWork;
        public CastService(IRepository<Cast> castRepository, IUnitOfWork unitOfWork)
        {
            this.castRepository = castRepository;
            this.unitOfWork = unitOfWork;
        }
        public bool Any(Guid id)
        {
            return castRepository.Any(x => x.Id == id);
        }

        public void Delete(Guid id)
        {
            var cast = castRepository.Get(id);
            if (cast != null)
            {
                castRepository.Delete(cast);
                unitOfWork.SaveChanges();
            }
        }

        public Cast Get(Guid id)
        {
            return castRepository.Get(id);
        }

        public IEnumerable<Cast> GetAll()
        {
            return castRepository.GetAll();
        }

        public void Insert(Cast cast)
        {
            castRepository.Insert(cast);
            unitOfWork.SaveChanges();
        }

        public void Update(Cast cast)
        {
            castRepository.Update(cast);
            unitOfWork.SaveChanges();
        }
    }
    public interface ICastService
    {
        IEnumerable<Cast> GetAll();
        Cast Get(Guid id);
        void Insert(Cast cast);
        void Update(Cast cast);
        void Delete(Guid id);
        bool Any(Guid id);
    }
}
