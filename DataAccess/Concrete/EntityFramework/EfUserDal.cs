using Core.DataAccess.Concrete.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            var context = new NorthwindContext();
            var result = from operationClaim in context.OperationClaims
                         join userOperationClaim in context.UserOperationClaims
                         on operationClaim.OperationClaimID equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.UserId
                         select new OperationClaim
                         {
                             OperationClaimID = operationClaim.OperationClaimID,
                             Name = operationClaim.Name
                         };
            return result.ToList();
        }
    }
}