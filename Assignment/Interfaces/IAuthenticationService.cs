using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces
{
    internal interface IAuthenticationService
    {
        #region Signature for Methods
        bool AuthenticateUser();
        bool AuthorizeUser();
        #endregion
    }
}
