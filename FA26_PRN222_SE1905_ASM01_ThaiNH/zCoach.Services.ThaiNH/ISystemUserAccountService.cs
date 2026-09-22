using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zCoach.Entities.ThaiNH.Models;

namespace zCoach.Services.ThaiNH
{
    public interface ISystemUserAccountService
    {
        Task<SystemUserAccount> GetUserAccount(string userName, string password);
    }
}
