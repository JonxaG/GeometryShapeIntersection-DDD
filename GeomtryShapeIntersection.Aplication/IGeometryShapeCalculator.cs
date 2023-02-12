using GeometryShapeIntersection.Domain;

namespace GeometryShapeIntersection.Application
{
    public interface IGeometryShapeCalculator
    {
        string GetIntersectionResult(IGeometryShape shape1, IGeometryShape shape2);
    }
}
