using System;

namespace GeometryShapeIntersection.Infrastructure
{
    public interface IExceptionHandler
    {
        void HandleException(Exception ex);
    }
}
