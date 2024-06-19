using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

public class Program
{
    private static void Main(string[] args)
    {
        CardFactory cardFactory = null;
        Console.WriteLine("Digite o tipo de cartão que gostaria de obter");
        string console = Console.ReadLine();

        switch (console.ToLower())
        {
            case "black":
                cardFactory = new BlackFactory(5000, 0);
                break;
            case "titanium":
                cardFactory = new TitaniumFactory(10000, 0);
                break;
            case "platinum":
                cardFactory = new PlatinumFactory(500000, 0);
                break;
            default:
                break;
        }

        CreditCard creditCard = cardFactory.GetCreditCard();
        Console.WriteLine("\nOs detalhes do seu cartão estão abaixo: \n");
        Console.WriteLine("Tipo do cartão: {0}\nCrédito limite: {1}\nCobrança Anual: {2}",
            creditCard.TypeCredit, creditCard.CreditLimit, creditCard.BilledAnnually);      

        Console.ReadKey();
    }
}