using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.DIReporting;

namespace CommandPattern.AntiPattern.Logout
{
    public class Logout : ILogout
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
        public void doLogout()
        {
            //do logout logic here
        }
    }
}
