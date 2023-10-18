using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.CommandPattern
{
    public class RequestHandler
    {
        private Dictionary<Action, ICommand> commandMap; // injected in, or obtained from a factory
        public void handleRequest(Action action)
        {
            ICommand command = commandMap[action];
            command.execute();
        }
    }
}
