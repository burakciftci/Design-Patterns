namespace AbstractFactoryDesingPattern.Interface
{
    public interface IAbstractFactory 
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();

    }
}