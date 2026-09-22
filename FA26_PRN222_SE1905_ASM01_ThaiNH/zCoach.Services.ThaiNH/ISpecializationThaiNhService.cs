using System.Collections.Generic;
using System.Threading.Tasks;
using zCoach.Entities.ThaiNH.Models;

namespace zCoach.Services.ThaiNH
{
    public interface ISpecializationThaiNhService
    {
        Task<List<SpecializationThaiNh>> GetAllAsync();
    }
}
