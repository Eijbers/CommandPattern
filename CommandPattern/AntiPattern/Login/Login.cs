using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.DIReporting;

namespace CommandPattern.AntiPattern.Login
{
    internal class Login : ILogin
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
        public void doLogin()
        {
            //doLogin logic here
        }
    }
}
