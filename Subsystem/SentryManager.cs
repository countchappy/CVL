using Sentry;

namespace CVL.Subsystem
{
    class SentryManager
    {
        public static void SetScope(Scope scope)
        {
            if (scope == Scope.Development)
                ConfigureDevelopmentScope();
        }

        public enum Scope
        {
            Production,
            Development
        }

        static void ConfigureDevelopmentScope()
        {
            SentrySdk.ConfigureScope(scope => { 
                scope.SetTag("environment", "development"); 
            });
        }
    }
}
