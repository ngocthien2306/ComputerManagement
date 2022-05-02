using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStore.Model
{
    public static class CurrentUser
    {
        public static AppUser AppUser;
        public static void SetCurrentUser(AppUser appUser)
        {
            AppUser = appUser;
        }
    }
}
