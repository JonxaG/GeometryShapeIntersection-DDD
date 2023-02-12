namespace GeometryShapeIntersection.Domain
{
    public interface IGeometryShape
    {
        int ID { get; set; }
        double[] Center { get; set; }
        double Dimension { get; set; }
    }
}
