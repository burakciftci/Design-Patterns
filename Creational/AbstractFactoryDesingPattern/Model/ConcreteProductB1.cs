using AbstractFactoryDesingPattern.Interface;

namespace AbstractFactoryDesingPattern.Model
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }
    }
}