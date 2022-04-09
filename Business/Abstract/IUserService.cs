using Core.Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService : IEntityService<User>
    {
        List<OperationClaim> GetClaims(User user);
        User GetByEmail(string email);
    }
}