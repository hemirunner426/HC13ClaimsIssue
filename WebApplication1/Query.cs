using HotChocolate;
using System.Security.Claims;

namespace WebApplication1
{
    public class Query
    {
        public IEnumerable<User> GetUsers([Service] DataContext context)
        {
            return context.Users;
        }

        //This causes the pipe to explode.
        public IEnumerable<UserClaim> GetClaims([Service] DataContext context)
        {
            return context.UserClaims;
        }
    }
}
