using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        #region Properies
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Role { get; set; } 
        #endregion

        #region Constractor
        public BasicAuthenticationService(string userName, string pass, string role)
        {
            UserName = userName;
            Password = pass;
            Role = role;
        }
        #endregion

        #region Methods
        public bool AuthenticateUser()
        {
            return UserName == "Sajeda" && Password == "123456";
        }

        public bool AuthorizeUser()
        {
            return UserName == "Sajeda" && Role == "Authorized";
        } 
        #endregion
    }
}
