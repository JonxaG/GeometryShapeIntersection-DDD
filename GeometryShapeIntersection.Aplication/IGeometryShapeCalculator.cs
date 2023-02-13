using GeometryShapeIntersection.Domain;

namespace GeometryShapeIntersection.Application
{
    /// <summary>
    /// IGeometryShapeCalculator is an interface for the GeometryShapeCalculator class, which calculates the
    /// intersection between two IGeometryShapes and returns the result.
    /// </summary>
    public interface IGeometryShapeCalculator
    {
        /// <summary>
        /// Intersects method calculates the intersection between two shapes and returns a boolean indicating whether
        /// the shapes intersect or not.
        /// </summary>
        /// <param name="shape1">First IGeometryShape to intersect.</param>
        /// <param name="shape2">Second IGeometryShape to intersect.</param>
        /// <returns>Boolean indicating whether the shapes intersect or not.</returns>
        bool Intersects(IGeometryShape shape1, IGeometryShape shape2);
        /// <summary>
        /// CalculateIntersectedVolume method calculates the volume of the intersection between two shapes.
        /// </summary>
        /// <param name="shape1">First IGeometryShape to intersect.</param>
        /// <param name="shape2">Second IGeometryShape to intersect.</param>
        /// <returns>Volume of the intersection between two shapes.</returns>
        double CalculateIntersectedVolume(IGeometryShape shape1, IGeometryShape shape2);

        /// <summary>
        /// GetIntersectionResult method calculates the intersection between two shapes and returns a string indicating 
        /// the result of the intersection.
        /// </summary>
        /// <param name="shape1">First IGeometryShape to intersect.</param>
        /// <param name="shape2">Second IGeometryShape to intersect.</param>
        /// <returns>String indicating the result of the intersection.</returns>
        string GetIntersectionResult(IGeometryShape shape1, IGeometryShape shape2);
    }
}
