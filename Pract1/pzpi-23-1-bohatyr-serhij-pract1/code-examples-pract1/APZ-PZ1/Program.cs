namespace APZ_PZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant sushiRestaurant = new SushiRestaurant();
            sushiRestaurant.PlanOrder();

            Restaurant pizzaRestaurant = new PizzaRestaurant();
            pizzaRestaurant.PlanOrder();
        }
    }

    public interface IFood
    {
        void Order();
    }

    public class Sushi : IFood
    {
        public void Order() 
        {
            Console.WriteLine("Замовлено суші");
        }
    }

    public class Pizza : IFood
    {
        public void Order()
        {
            Console.WriteLine("Замовлено піцу");
        }
    }

    public abstract class Restaurant
    {
        public abstract IFood CreateFood();

        public void PlanOrder()
        {
            IFood food = CreateFood();
            food.Order();
        }
    }

    public class SushiRestaurant : Restaurant
    {
        public override IFood CreateFood() => new Sushi();
    }

    public class PizzaRestaurant : Restaurant
    {
        public override IFood CreateFood() => new Pizza();
    }
}
