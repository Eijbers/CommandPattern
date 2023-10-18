using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.CommandPattern
{
    internal class LogoutCommand : ICommand
    {
        public void execute()
        {
            // do what doLogout() used to do
        }
    }
}
