using System;

namespace Visitor.Interface
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
