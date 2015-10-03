using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;

namespace Utilities.Gmail
{
    public interface IGmailAuthorizer
    {
        UserCredential Authorize();
    }
}
