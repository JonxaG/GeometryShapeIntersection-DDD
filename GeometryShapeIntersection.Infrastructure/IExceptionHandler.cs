using System;

namespace GeometryShapeIntersection.Infrastructure
{
    /// <summary>
    /// Interface for handling exceptions.
    /// </summary>
    public interface IExceptionHandler
    {
        /// <summary>
        /// Handle an exception.
        /// </summary>
        /// <param name="ex">The exception to handle.</param>
        void HandleException(Exception ex);
    }
}
