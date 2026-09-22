using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using zCoach.Entities.ThaiNH.Models;
using zCoach.Repositories.ThaiNH;

namespace zCoach.Services.ThaiNH
{
    public class CoachThaiNhService : ICoachThaiNhService
    {
        private readonly CoachThaiNhRepository _repository;

        public CoachThaiNhService()
        {
            _repository = new CoachThaiNhRepository();
        }

        public async Task<List<CoachThaiNh>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<CoachThaiNh> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> CreateAsync(CoachThaiNh coach)
        {
            return await _repository.CreateAsync(coach);
        }

        public async Task<int> UpdateAsync(CoachThaiNh coach)
        {
            return await _repository.UpdateAsync(coach);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var coach = await _repository.GetByIdAsync(id);
            if (coach != null)
            {
                return await _repository.RemoveAsync(coach);
            }
            return false;
        }

        public async Task<List<CoachThaiNh>> SearchAsync(string? fullName, string? email, string? phone)
        {
            return await _repository.SearchAsync(fullName, email, phone);
        }
    }
}
