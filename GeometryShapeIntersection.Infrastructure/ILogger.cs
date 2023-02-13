namespace GeometryShapeIntersection.Infrastructure
{
    /// <summary>
    /// Interface for logging messages.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log an error message.
        /// </summary>
        /// <param name="message">The error message to log.</param>
        void LogError(string message);

        /// <summary>
        /// Log an info message.
        /// </summary>
        /// <param name="message">The info message to log.</param>
        void LogInfo(string message);
    }
}