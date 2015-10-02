using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    abstract class ApiAccessObject
    {
        public abstract void Connect();
        public abstract void GetData();
        public abstract void Process();

        public void Run()
        {
            Connect();
            Process();
        }
    }
}
