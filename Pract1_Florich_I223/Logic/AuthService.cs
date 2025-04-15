using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pract1_Florich_I223.DBMODEL12;
using Pract1_Florich_I223.Model;

namespace Pract1_Florich_I223.Logic
{
    public class AuthService : IAuthService
    {
       
        ShopDBEntities dbContext = new ShopDBEntities();

        public bool CheckData(string login, string pass)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Login == login && u.Password == pass);

            if (user != null && user.Password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
