using GeometryShapeIntersection.Infrastructure;
using System;

namespace GeometryShapeIntersection.Infrastructure
{
    public class ExceptionHandler : IExceptionHandler
    {
        private ILogger logger;

        public ExceptionHandler(ILogger logger)
        {
            this.logger = logger;
        }

        public void HandleException(Exception ex)
        {
            logger.LogError($"An error occurred: {ex.Message}");
        }
    }
}
