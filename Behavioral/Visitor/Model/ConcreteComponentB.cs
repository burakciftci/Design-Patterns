using System;
using Visitor.Interface;

namespace Visitor.Model
{
    public class ConcreteComponentB:IComponent
    {
        // Same here: VisitConcreteComponentB => ConcreteComponentB
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentB(this);
        }

        public string SpecialMethodOfConcreteComponentB()
        {
            return "B";
        }
    }
}
