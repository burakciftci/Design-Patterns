using AbstractFactoryDesingPattern.Interface;

namespace AbstractFactoryDesingPattern.Model
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }
    }
}