using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.DIReporting;
using Microsoft.Extensions.DependencyInjection;

namespace CommandPattern.AntiPattern.Logout
{
    public interface ILogout : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
        public void doLogout();
    }
}
