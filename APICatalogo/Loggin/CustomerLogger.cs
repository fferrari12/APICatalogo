
namespace APICatalogo.Loggin
{
    public class CustomerLogger : ILogger
    {
        readonly string loggerName;
        readonly CustomLoggerProviderConfig loggerConfig;

        public CustomerLogger(string name, CustomLoggerProviderConfig config)
        {
            loggerName = name;
            loggerConfig = config;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel == loggerConfig.LogLevel;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            string mensagem = $"{DateTime.Now.ToLongTimeString()} - {logLevel.ToString()} - {eventId.Id} - {formatter(state,exception)}";
            EscreverTextoNoArquivo(mensagem);
        }

        private void EscreverTextoNoArquivo(string mensagem)
        {
            string caminhoArquivo = @"c:\fabio\estudos\apicatalogo\log\LogApiCatalogo.log";
            using StreamWriter sw = new StreamWriter(caminhoArquivo, true);
            try
            {
                sw.WriteLine(mensagem);
                sw.Close();
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
