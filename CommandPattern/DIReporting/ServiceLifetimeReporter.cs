using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.AntiPattern.Login;
using CommandPattern.AntiPattern.Logout;
using CommandPattern.AntiPattern.Query;

namespace CommandPattern.DIReporting
{
    internal class ServiceLifetimeReporter
    {
        private readonly IQuery _queryTransientService;
        private readonly ILogin _loginScopedService;
        private readonly ILogout _logoutSingletonService;

        public ServiceLifetimeReporter(
            IQuery queryTransientService,
            ILogin loginScopedService,
            ILogout logoutSingletonService) =>
            (_queryTransientService, _loginScopedService, _logoutSingletonService) =
                (queryTransientService, loginScopedService, logoutSingletonService);

        public void ReportServiceLifetimeDetails(string lifetimeDetails)
        {
            Console.WriteLine(lifetimeDetails);

            LogService(_queryTransientService, "Always different");
            LogService(_loginScopedService, "Changes only with lifetime");
            LogService(_logoutSingletonService, "Always the same");
        }

        private static void LogService<T>(T service, string message)
            where T : IReportServiceLifetime =>
            Console.WriteLine(
                $"    {typeof(T).Name}: {service.Id} ({message})");
    }
}
