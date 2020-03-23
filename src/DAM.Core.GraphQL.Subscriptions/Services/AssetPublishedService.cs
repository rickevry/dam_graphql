using DAM.Core.GraphQL.Subscriptions.Interfaces;
using DAM.Core.Messages.AssetDomain;
using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace DAM.Core.GraphQL.Subscriptions.Services
{
    public class AssetPublishedService : ISubscriptionService<AssetPublishedEvent>
    {
        private readonly ISubject<AssetPublishedEvent> _subject = new ReplaySubject<AssetPublishedEvent>(1);

        public AssetPublishedService()
        {
        }

        public IObservable<AssetPublishedEvent> GetObservable()
        {
            return _subject.AsObservable();
        }

        public void Notify(AssetPublishedEvent e)
        {
            _subject.OnNext(e);
        }
    }
}
