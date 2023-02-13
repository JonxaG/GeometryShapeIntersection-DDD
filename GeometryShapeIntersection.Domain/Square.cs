namespace GeometryShapeIntersection.Domain
{
    /// <summary>
    /// Class that represents a Square shape. Inherits from GeometryShape.
    /// </summary>
    public class Square : GeometryShape
    {
        /// <summary>
        /// Constructor for Square shape.
        /// </summary>
        /// <param name="id">ID of the shape.</param>
        /// <param name="centerX">X coordinate of the center of the shape.</param>
        /// <param name="centerY">Y coordinate of the center of the shape.</param>
        /// <param name="dimension">Size of the shape, which is a square so it is the same for both width and height.</param>
        public Square(int id, double centerX, double centerY, double dimension)
            : base(id, new double[] { centerX, centerY }, dimension)
        {
        }
    }
}
