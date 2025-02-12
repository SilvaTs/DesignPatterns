using Adapter.Contracts;
using Adapter.Legacy;

namespace Adapter.Adapters
{
    public class DataProcessorAdapter : IDataProcessor
    {
        private readonly LegacyDataProcessor _legacyProcessor;

        public DataProcessorAdapter()
        {
            _legacyProcessor = new LegacyDataProcessor();
        }

        public DataProcessorAdapter(LegacyDataProcessor legacyProcessor)
        {
            _legacyProcessor = legacyProcessor ?? throw new ArgumentNullException(nameof(legacyProcessor));
        }

        public string ProcessData(string data)
        {
            try
            {
                return _legacyProcessor.ProcessLegacyFormat(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar dados: {ex.Message}");
                throw new InvalidOperationException("Falha ao processar os dados.", ex);
            }
        }
    }
}
