using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Reservation_API.Helpers
{
    public static class Helper
    {
        public static string GetClaimType(this ClaimsPrincipal principal,string type)
        {
            var Value = principal.Claims.FirstOrDefault(c => c.Type == type);
            return Value?.Value;
        }
    }
}
