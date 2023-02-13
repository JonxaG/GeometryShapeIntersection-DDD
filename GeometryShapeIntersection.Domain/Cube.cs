namespace GeometryShapeIntersection.Domain
{
    /// <summary>
    /// Class that represents a cube in 3D space.
    /// </summary>
    public class Cube : GeometryShape
    {
        /// <summary>
        /// Constructor that initializes a new Cube object with a given ID, center point
        /// </summary>
        /// <param name="id">Unique identifier for the cube.</param>
        /// <param name="centerX">X-coordinate of the center point.</param>
        /// <param name="centerY">Y-coordinate of the center point.</param>
        /// <param name="centerZ">Z-coordinate of the center point.</param>
        /// <param name="dimension">The size of the cube's edges.</param>
        public Cube(int id, double centerX, double centerY, double centerZ, double dimension): base(id, new double[] { centerX, centerY, centerZ }, dimension)
        {
        }
    }
}
