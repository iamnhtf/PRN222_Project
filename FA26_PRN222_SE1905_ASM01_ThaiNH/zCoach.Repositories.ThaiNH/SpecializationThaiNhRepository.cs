using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zCoach.Entities.ThaiNH.Models;
using zCoach.Repositories.ThaiNH.Base;
using zCoach.Repositories.ThaiNH.DbContext;

namespace zCoach.Repositories.ThaiNH
{
    public class SpecializationThaiNhRepository : GenericRepository<SpecializationThaiNh>
    {
        public SpecializationThaiNhRepository() => _context ??= new PRN222Context();
        public SpecializationThaiNhRepository(PRN222Context context) => _context = context;
    }
}
