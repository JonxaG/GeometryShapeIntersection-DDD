using System;

namespace GeometryShapeIntersection.Infrastructure
{
    /// <summary>
    /// Class for logging messages.
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// Log an error message.
        /// </summary>
        /// <param name="message">The error message to log.</param>
        public void LogError(string message)
        {
            Console.WriteLine($"ERROR: {message}");
        }

        /// <summary>
        /// Log an info message.
        /// </summary>
        /// <param name="message">The info message to log.</param>
        public void LogInfo(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }
    }
}