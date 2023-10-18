using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.DIReporting;
using Microsoft.Extensions.DependencyInjection;

namespace CommandPattern.AntiPattern.Query
{
    public interface IQuery : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
        void doQuery();
    }
}
