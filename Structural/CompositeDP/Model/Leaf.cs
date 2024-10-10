
namespace CompositeDP.Model
{

    public class Leaf : Component
    {


        public override bool IsComposite()
        {
            return false;
        }

        public override string Operation()
        {
            return "Leaf";
        }

        public override string Operation()
        {
            throw new NotImplementedException();
        }
    }
}