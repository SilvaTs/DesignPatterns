using Facade.Interfaces;

namespace Facade
{
    public class RestaurantFacade
    {
        private IPizza _pizzaSupplier;
        private IBread _breadSupplier;

        public RestaurantFacade()
        {
            _pizzaSupplier = new PizzaSupplier();
            _breadSupplier = new BreadSupplier();
        }

        public void SearchPizzaNormal()
        {
            _pizzaSupplier.SearchVerganaNormal();
        }

        public void SearchVerganaPizza()
        {
            _pizzaSupplier.SearchVerganaPizza();
        }

        public void SearchGarlicBread()
        {
            _breadSupplier.SearchGarlicBread();
        }

        public void SearchGarlicBreadWithCheese()
        {
            _breadSupplier.SearchGarlicBreadWithCheese();
        }
    }
}
