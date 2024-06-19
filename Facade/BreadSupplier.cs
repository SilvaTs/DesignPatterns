using Facade.Interfaces;

namespace Facade
{
    public class BreadSupplier : IBread
    {
        public void SearchGarlicBread()
        {
            Console.WriteLine("Obtendo Pão de Alho.");
        }

        public void SearchGarlicBreadWithCheese()
        {
            GetCheese();
            Console.WriteLine("Obtendo Pão de Alho com Queijo.");
        }

        private void GetCheese()
        {
            Console.WriteLine("Obtendo Queijo.");
        }
    }
}
