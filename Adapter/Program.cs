using Adapter.Adapters;
using Adapter.Contracts;

namespace Adapter.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IDataProcessor processor = new DataProcessorAdapter();
                string inputData = "Olá, Padrão Adapter!";

                Console.WriteLine("Demonstração do Padrão Adapter");
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Dados Originais: {inputData}");

                string result = processor.ProcessData(inputData);
                
                Console.WriteLine($"Resultado Adaptado: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro durante a execução: {ex.Message}");
            }
        }
    }
}
