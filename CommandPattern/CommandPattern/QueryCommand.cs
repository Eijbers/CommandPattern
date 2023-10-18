using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.CommandPattern
{
    internal class QueryCommand : ICommand
    {
        public void execute()
        {
            // do what doQuery() used to do
        }
    }
}
