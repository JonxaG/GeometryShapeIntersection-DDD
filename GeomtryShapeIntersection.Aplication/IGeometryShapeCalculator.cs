using GeometryShapeIntersection.Domain;

namespace GeometryShapeIntersection.Application
{
    public interface IGeometryShapeCalculator
    {
        bool Intersects(IGeometryShape shape1, IGeometryShape shape2);
        double CalculateIntersectedVolume(IGeometryShape shape1, IGeometryShape shape2);
        string GetIntersectionResult(IGeometryShape shape1, IGeometryShape shape2);
    }
}
