using System;

namespace Services.MessageHub
{
    public class MessageHub : IMessageHub
    {
        private static class EventDispatcher<T>
        {
            public static Action<T> EventHandler;
        }
        
        public void Subscribe<T>(Action<T> handler)
        {
            EventDispatcher<T>.EventHandler += handler;
        }

        public void Unsubscribe<T>(Action<T> handler)
        {
            EventDispatcher<T>.EventHandler -= handler;
        }

        public void Trigger<T>(T @event)
        {
            EventDispatcher<T>.EventHandler?.Invoke(@event);
        }
    }
}
