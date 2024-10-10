using Builder.Interface;

namespace Builder.Model
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void Reset()
        {
            this._product = new Product();
        }

        public void BuildPartA()
        {
            this._product.Add("ProductA1");
        }

        public void BuildPartB()
        {
            this._product.Add("ProductB1");
        }

        public void BuildPartC()
        {
            this._product.Add("ProductC1");
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
