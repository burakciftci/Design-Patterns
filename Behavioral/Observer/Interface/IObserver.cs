using System;

namespace Observer.Interface
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
