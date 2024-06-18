namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Padrão Strategy ##\n");

            CompressaoContext compressaoContext = new CompressaoContext(new CompressaoRar());

            Console.WriteLine("Informe o nome do arquivo a comprimir");
            var nomeArquivo = Console.ReadLine();

            Console.WriteLine("\nInforme o tipo de compressão a ser usada");
            Console.WriteLine("1-Rar(Padrão) 2-Zip 3-Gzip");
            var opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 2)
            {
                compressaoContext.DefineStrategy(new CompressaoZip());
            }
            else if (opcao == 3)
            {
                compressaoContext.DefineStrategy(new CompressaoGzip());
            }

            compressaoContext.CriarArquivoCompactado(nomeArquivo);

            Console.Read();
        }
    }
}
