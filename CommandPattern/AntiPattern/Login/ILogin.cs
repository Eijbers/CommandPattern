using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.DIReporting;
using Microsoft.Extensions.DependencyInjection;

namespace CommandPattern.AntiPattern.Login
{
    public interface ILogin : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;

        public void doLogin();
    }
}
