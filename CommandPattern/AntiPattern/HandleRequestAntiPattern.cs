using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.AntiPattern.Login;
using CommandPattern.AntiPattern.Logout;
using CommandPattern.AntiPattern.Query;

namespace CommandPattern.AntiPattern
{
    class HandleRequestAntiPattern
    {
        ILogin _login;
        IQuery _query;
        ILogout _logout;
        public HandleRequestAntiPattern(ILogin login, IQuery query, ILogout logout) 
        {
            _login = login;
            _query = query;
            _logout = logout;
        }
        public void handleRequest(Action action)
        {

            switch (action)
            {
                case Action.LOGIN:

                    break;
                case Action.LOGOUT:
                    
                    break;
                case Action.QUERY:

                    break;
            }
        }
    }
}
