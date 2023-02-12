namespace GeometryShapeIntersection.Domain
{
    public class Square : GeometryShape
    {
        public Square(int id, double centerX, double centerY, double dimension)
            : base(id, new double[] { centerX, centerY }, dimension)
        {
        }
    }
}
