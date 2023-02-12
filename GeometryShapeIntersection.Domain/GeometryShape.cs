namespace GeometryShapeIntersection.Domain
{
    public class GeometryShape : IGeometryShape
    {
        public int ID { get; set; }
        public double[] Center { get; set; }
        public double Dimension { get; set; }

        public GeometryShape(int id, double[] center, double dimension)
        {
            ID = id;
            Center = center;
            Dimension = dimension;
        }
    }
}
