using GeometryShapeIntersection.Domain;

namespace GeometryShapeIntersection.Application
{
    public class GeometryShapeCalculator : IGeometryShapeCalculator
    {
        public bool Intersects(IGeometryShape shape1, IGeometryShape shape2)
        {
            if (shape1.Center.Length != shape2.Center.Length)
            {
                throw new System.ArgumentException("Both shapes must have the same number of dimensions.");
            }

            for (int i = 0; i < shape1.Center.Length; i++)
            {
                if (System.Math.Abs(shape1.Center[i] - shape2.Center[i]) > (shape1.Dimension + shape2.Dimension) / 2)
                {
                    return false;
                }
            }
            return true;
        }

        public double CalculateIntersectedVolume(IGeometryShape shape1, IGeometryShape shape2)
        {
            if (shape1.Dimension < 0 || shape2.Dimension < 0)
            {
                throw new System.ArgumentException("Dimensions cannot be negative.");
            }

            if (!Intersects(shape1, shape2))
            {
                return 0;
            }

            double intersectedLength = System.Math.Min(shape1.Dimension, shape2.Dimension);
            for (int i = 0; i < shape1.Center.Length; i++)
            {
                double distance = System.Math.Abs(shape1.Center[i] - shape2.Center[i]);
                double halfDim1 = shape1.Dimension / 2;
                double halfDim2 = shape2.Dimension / 2;
                intersectedLength = System.Math.Min(intersectedLength, halfDim1 + halfDim2 - distance);
            }

            return System.Math.Pow(intersectedLength, shape1.Center.Length);
        }

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
