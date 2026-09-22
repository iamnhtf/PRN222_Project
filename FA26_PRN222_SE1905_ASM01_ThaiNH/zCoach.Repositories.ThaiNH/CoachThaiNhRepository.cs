using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zCoach.Entities.ThaiNH.Models;
using zCoach.Repositories.ThaiNH.Base;
using zCoach.Repositories.ThaiNH.DbContext;
using Microsoft.EntityFrameworkCore;

namespace zCoach.Repositories.ThaiNH
{
    public class CoachThaiNhRepository : GenericRepository<CoachThaiNh>
    {
        public CoachThaiNhRepository() => _context ??= new PRN222Context();
        public CoachThaiNhRepository(PRN222Context context) => _context = context;

        public async Task<List<CoachThaiNh>> GetAllAsync()
        {
            return await _context.CoachThaiNhs.Include(c => c.SpecializationThaiNh).ToListAsync();
        }

        public async Task<CoachThaiNh> GetByIdAsync(int id)
        {
            return await _context.CoachThaiNhs.Include(c => c.SpecializationThaiNh).FirstOrDefaultAsync(c => c.CoachThaiNhid == id);
        }

        public async Task<List<CoachThaiNh>> SearchAsync(string? fullName, string? email, string? phone)
        {
            return await _context.CoachThaiNhs
                .Include(c => c.SpecializationThaiNh)
                .Where(c =>
                    (string.IsNullOrEmpty(fullName) || (c.FullName != null && c.FullName.Contains(fullName))) &&
                    (string.IsNullOrEmpty(email) || (c.Email != null && c.Email.Contains(email))) &&
                    (string.IsNullOrEmpty(phone) || (c.Phone != null && c.Phone.Contains(phone))))
                .ToListAsync();
        }
    }
}
