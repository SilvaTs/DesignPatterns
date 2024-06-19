using Facade.Interfaces;

namespace Facade
{
    public class PizzaSupplier : IPizza
    {
        public void SearchVerganaNormal()
        {
            GetNonVerganaCoverage();
            Console.WriteLine("Buscando a Pizza Normal.");
        }

        public void SearchVerganaPizza()
        {
            Console.WriteLine("Buscando a Pizza Vergana.");
        }

        private void GetNonVerganaCoverage()
        {
            Console.WriteLine("Obtendo coberturas de pizza não vergetais.");
        }    
    }
}
