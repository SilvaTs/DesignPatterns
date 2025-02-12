namespace Adapter.Legacy
{
    public class LegacyDataProcessor
    {
        public string ProcessLegacyFormat(string legacyData)
        {
            if (string.IsNullOrEmpty(legacyData))
                throw new ArgumentNullException(nameof(legacyData), "Os dados não podem ser nulos ou vazios.");

            return $"Processado pelo sistema legado: {legacyData.ToUpper()}";
        }
    }
}
