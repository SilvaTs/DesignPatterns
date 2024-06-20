using Facade;

class Program
{
    static void Main(string[] args)
    {
        var restaurantFacade = new RestaurantFacade();

        Console.WriteLine("----------------------PEDIDOS DE PIZZA DO CLIENTE----------------------------\n");
        restaurantFacade.SearchPizzaNormal();
        restaurantFacade.SearchVerganaPizza();

        Console.WriteLine("\n----------------------PEDIDOS DE PÃO DO CLIENTE----------------------------\n");
        restaurantFacade.SearchGarlicBread();
        restaurantFacade.SearchGarlicBreadWithCheese();
    }
}
