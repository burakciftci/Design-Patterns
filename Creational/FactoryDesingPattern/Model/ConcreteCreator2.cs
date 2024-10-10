using FactoryDesingPattern.Interface;

namespace FactoryDesingPattern.Model
{

    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}