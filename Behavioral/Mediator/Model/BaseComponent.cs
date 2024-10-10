using System;
    // The Base Component provides the basic functionality of storing a
    // mediator's instance inside component objects.
namespace Mediator.Model
{
    public class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
