using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace APICatalogo.Loggin
{
    public class CustomLoggerProvider : ILoggerProvider
    {
        readonly CustomLoggerProviderConfig loggerConfig;
        readonly ConcurrentDictionary<string, CustomerLogger> _loggers = new ConcurrentDictionary<string, CustomerLogger>();

        public CustomLoggerProvider(CustomLoggerProviderConfig logger)
        {
            loggerConfig = logger;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(categoryName, name => new CustomerLogger(name, loggerConfig));
        }

        public void Dispose()
        {
            _loggers.Clear();
        }
    }
}
