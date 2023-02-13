using GeometryShapeIntersection.Domain;

namespace GeometryShapeIntersection.Application
{
    /// <summary>
    /// Class that implements the IGeometryShapeCalculator interface and provides methods 
    /// to calculate intersection and volume of two shapes.
    /// </summary>
    public class GeometryShapeCalculator : IGeometryShapeCalculator
    {
        /// <summary>
        /// Determines if two shapes intersect.
        /// </summary>
        /// <param name="shape1">The first shape to compare.</param>
        /// <param name="shape2">The second shape to compare.</param>
        /// <returns>True if the shapes intersect, false otherwise.</returns>
        public bool Intersects(IGeometryShape shape1, IGeometryShape shape2)
        {
            // Ensure both shapes have the same number of dimensions
            if (shape1.Center.Length != shape2.Center.Length)
            {
                throw new System.ArgumentException("Both shapes must have the same number of dimensions.");
            }

            // Check if the distance between the centers of the shapes is greater than their combined size
            for (int i = 0; i < shape1.Center.Length; i++)
            {
                if (System.Math.Abs(shape1.Center[i] - shape2.Center[i]) > (shape1.Size + shape2.Size) / 2)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Calculates the volume of the intersection between two shapes.
        /// </summary>
        /// <param name="shape1">The first shape to compare.</param>
        /// <param name="shape2">The second shape to compare.</param>
        /// <returns>The volume of the intersection between the two shapes.</returns>
        public double CalculateIntersectedVolume(IGeometryShape shape1, IGeometryShape shape2)
        {
            // Ensure that the shapes have a valid size
            if (shape1.Size < 0 || shape2.Size < 0)
            {
                throw new System.ArgumentException("Sizes cannot be negative.");
            }

            // Check if the shapes intersect
            if (!Intersects(shape1, shape2))
            {
                return 0;
            }

            // Calculate the minimum intersecting length between the two shapes
            double intersectedLength = System.Math.Min(shape1.Size, shape2.Size);
            for (int i = 0; i < shape1.Center.Length; i++)
            {
                double distance = System.Math.Abs(shape1.Center[i] - shape2.Center[i]);
                double halfDim1 = shape1.Size / 2;
                double halfDim2 = shape2.Size / 2;
                intersectedLength = System.Math.Min(intersectedLength, halfDim1 + halfDim2 - distance);
            }

            // Return the calculated volume
            return System.Math.Pow(intersectedLength, shape1.Center.Length);
        }
        // <summary>
        /// Gets the result of the intersection between two shapes
        /// </summary>
        /// <param name="shape1">The first shape</param>
        /// <param name="shape2">The second shape</param>
        /// <returns>A string indicating whether the shapes intersect and the volume of the intersection if they do</returns>
        public string GetIntersectionResult(IGeometryShape shape1, IGeometryShape shape2)
        {
            if (!Intersects(shape1, shape2))
            {
                return "The shapes do not intersect.";
            }
            double intersectedVolume = CalculateIntersectedVolume(shape1, shape2);
            return $"The shapes intersect with a volume of {intersectedVolume}.";
        }

    }
}
