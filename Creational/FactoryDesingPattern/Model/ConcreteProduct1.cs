using FactoryDesingPattern.Interface;

namespace FactoryDesingPattern.Model
{

    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}