using GeometryShapeIntersection.Infrastructure;
using System;

namespace GeometryShapeIntersection.Infrastructure
{
    /// <summary>
    /// Class for handling exceptions.
    /// </summary>
    public class ExceptionHandler : IExceptionHandler
    {
        // Logger for logging errors.
        private ILogger logger;

        /// <summary>
        /// Constructor that takes a logger as a parameter.
        /// </summary>
        /// <param name="logger">The logger for logging errors.</param>
        public ExceptionHandler(ILogger logger)
        {
            // Store the logger.
            this.logger = logger;
        }

        /// <summary>
        /// Handle an exception.
        /// </summary>
        /// <param name="ex">The exception to handle.</param>
        public void HandleException(Exception ex)
        {
            // Log the error message.
            logger.LogError($"An error occurred: {ex.Message}");
        }
    }
}