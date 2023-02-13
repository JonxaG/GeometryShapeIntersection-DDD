namespace GeometryShapeIntersection.Domain
{
    /// <summary>
    /// Class representing a generic geometry shape.
    /// </summary>
    public class GeometryShape : IGeometryShape
    {
        /// <summary>
        /// The ID of the shape.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The center coordinates of the shape.
        /// </summary>
        public double[] Center { get; set; }

        /// <summary>
        /// The size of the shape.
        /// </summary>
        public double Size { get; set; }

        /// <summary>
        /// Constructs a new instance of GeometryShape.
        /// </summary>
        /// <param name="id">The ID of the shape.</param>
        /// <param name="center">The center coordinates of the shape.</param>
        /// <param name="dimension">The size of the shape.</param>
        public GeometryShape(int id, double[] center, double dimension)
        {
            ID = id;
            Center = center;
            Size = dimension;
        }
    }
}