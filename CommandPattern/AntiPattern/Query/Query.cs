using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.DIReporting;

namespace CommandPattern.AntiPattern.Query
{
    public class Query : IQuery
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
        public void doQuery()
        {
            //Do query logic here
        }
    }
}
