using FactoryDesingPattern.Interface;

namespace FactoryDesingPattern.Model
{

    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}