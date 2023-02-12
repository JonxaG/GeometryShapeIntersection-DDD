using GeometryShapeIntersection.Application;

namespace GeometryShapeIntersection.Infrastructure
{
    /// <summary>
    /// Class DependencyContainer that manages the dependencies of the application.
    /// </summary>
    public class DependencyContainer
    {
        private static DependencyContainer instance;

        /// <summary>
        /// Property that provides access to the instance of the DependencyContainer.
        /// </summary>
        public static DependencyContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DependencyContainer();
                }
                return instance;
            }
        }

        private DependencyContainer() { }

        public IGeometryShapeRepository GeometryShapeRepository { get; set; }
        public IGeometryShapeCalculator GeometryShapeCalculator { get; set; }

        /// <summary>
        /// Method to register the dependencies used in the application.
        /// </summary>
        public void RegisterDependencies()
        {
            GeometryShapeRepository = new GeometryShapeRepository();
            GeometryShapeCalculator = new GeometryShapeCalculator();
        }
    }
}