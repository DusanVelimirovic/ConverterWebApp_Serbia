namespace Converter_Web_Application.Service
{
    /// <summary>
    /// Defines a contract for a subject in the Observer pattern.
    /// Subjects implementing this interface manage and notify observers.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Attaches an observer to the subject.
        /// </summary>
        /// <param name="observer">The observer to attach.</param>
        void Attach(IObserver observer);

        /// <summary>
        /// Detaches an observer from the subject.
        /// </summary>
        /// <param name="observer">The observer to detach.</param>
        void Detach(IObserver observer);

        /// <summary>
        /// Notifies all attached observers of a change.
        /// </summary>
        void Notify();
    }
}
