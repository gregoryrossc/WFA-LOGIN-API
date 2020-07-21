using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms.Design;

namespace api_login_excercise.Shared
{
    public static class Service
    {
        public static bool LoginUser(string userName, string password)
        {
            using (var db = new Model.EmployeeContext())
            {
                var rec = db.Login.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
                if (rec != null)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
