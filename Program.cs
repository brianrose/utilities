using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utilities;
using Utilities.Gmail;

namespace GmailQuickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiAccessObject gmail = new GmailApiAccessObject(new GmailAuthorizer());
            gmail.Run();
        }
    }
}