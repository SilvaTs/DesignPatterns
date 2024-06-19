using Facade.Interfaces;

namespace Facade
{
    public class PizzaSupplier : IPizza
    {
        public void SearchVerganaNormal()
        {
            throw new NotImplementedException();
        }

        public void SearchVerganaPizza()
        {
            throw new NotImplementedException();
        }

        private void GetNonVerganaCoverage()
        {
            Console.WriteLine("Obtendo coberturas de pizza não vergetais.");
        }    
    }
}
