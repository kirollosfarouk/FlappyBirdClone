using System;

namespace Services.MessageHub
{
    public interface IMessageHub
    {
        /// <summary>
        /// Adds the handler to the event dispatcher. The handler will be called when an event of the type is triggered.
        /// </summary>
        /// <param name="handler">The function that is called when the event is triggered</param>
        /// <typeparam name="TEvent">The event type the handler is used for</typeparam>
        void Subscribe<TEvent>(Action<TEvent> handler);
        
        /// <summary>
        /// Removes the handler from the event dispatcher.
        /// </summary>
        /// <param name="handler">The function that should not be called anymore.</param>
        /// <typeparam name="TEvent">The event type the handler is used for</typeparam>
        void Unsubscribe<TEvent>(Action<TEvent> handler);
        
        /// <summary>
        /// Forwards the passed event to all subscribed handlers.
        /// </summary>
        /// <param name="event">The event instance that is passed to the handlers</param>
        void Trigger<TEvent>(TEvent @event);
    }
}