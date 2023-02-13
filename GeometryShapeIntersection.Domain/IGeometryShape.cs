namespace GeometryShapeIntersection.Domain
{
    /// <summary>
    /// Interface representing a generic geometry shape.
    /// </summary>
    public interface IGeometryShape
    {
        /// <summary>
        /// The ID of the shape.
        /// </summary>
        int ID { get; set; }

        /// <summary>
        /// The center coordinates of the shape.
        /// </summary>
        double[] Center { get; set; }

        /// <summary>
        /// The size of the shape.
        /// </summary>
        double Size { get; set; }
    }
}
