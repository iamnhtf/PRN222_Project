using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using zCoach.Entities.ThaiNH.Models;

namespace zCoach.Services.ThaiNH
{
    public interface ICoachThaiNhService
    {
        Task<List<CoachThaiNh>> GetAllAsync();
        Task<CoachThaiNh> GetByIdAsync(int id);
        Task<int> CreateAsync(CoachThaiNh coach);
        Task<int> UpdateAsync(CoachThaiNh coach);
        Task<bool> DeleteAsync(int id);
        Task<List<CoachThaiNh>> SearchAsync(string? fullName, string? email, string? phone);
    }
}
