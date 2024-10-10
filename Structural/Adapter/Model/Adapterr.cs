namespace Adapter.Model
{
    public class Adapterr : ITaget
    {
        private readonly Adaptee _adaptee;

        public Adapterr(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }

    }
}