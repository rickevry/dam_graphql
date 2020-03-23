using DAM.Core.Messages;
using System;

namespace DAM.Core.GraphQL.Subscriptions.Interfaces
{
    public interface ISubscriptionService<TDataEvent> where TDataEvent : class, IDataEvent
    {
        IObservable<TDataEvent> GetObservable();

        void Notify(TDataEvent e);
    }
}
