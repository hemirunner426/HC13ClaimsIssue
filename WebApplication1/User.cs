
using Microsoft.AspNetCore.Identity;

namespace WebApplication1
{
    public class User : IdentityUser<long>
    {
    }

    public class UserClaim : IdentityUserClaim<long>
    {

    }

    public class UserRole : IdentityUserRole<long>
    {
    }
}
