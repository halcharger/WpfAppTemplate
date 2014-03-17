using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace WpfAppTemplate.Infrastructure
{
    public interface IEventAggregator
    {
        IObservable<T> GetEventStream<T>();
        void Publish<T>(T payload);
    }

    public class EventAggregator : IEventAggregator
    {
        private readonly ISubject<object> _subject = new Subject<object>();

        public IObservable<T> GetEventStream<T>()
        {
            return _subject.OfType<T>().AsObservable();
        }

        public void Publish<TEvent>(TEvent payload)
        {
            _subject.OnNext(payload);
        }
    }
}