using System.Collections.Generic;
using System.Threading.Tasks;
using zCoach.Entities.ThaiNH.Models;
using zCoach.Repositories.ThaiNH;

namespace zCoach.Services.ThaiNH
{
    public class SpecializationThaiNhService : ISpecializationThaiNhService
    {
        private readonly SpecializationThaiNhRepository _repository;

        public SpecializationThaiNhService()
        {
            _repository = new SpecializationThaiNhRepository();
        }

        public async Task<List<SpecializationThaiNh>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
