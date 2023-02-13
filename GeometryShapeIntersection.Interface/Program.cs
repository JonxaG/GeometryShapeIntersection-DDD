using System;
using GeometryShapeIntersection.Domain;
using GeometryShapeIntersection.Infrastructure;
using GeometryShapeIntersection.Application;

namespace GeometryShapeIntersection.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register the dependencies used in the application
            DependencyContainer.Instance.RegisterDependencies();

            // Create an instance of the logger
            ILogger logger = new Logger();

            // Read data for first cube
            Console.WriteLine("Enter data for the first cube:");
            IGeometryShape shape1 = ReadCubeData();
            // Read data for second cube
            Console.WriteLine("Enter data for the second cube:");
            IGeometryShape shape2 = ReadCubeData();

            // Get the instance of the geometry shape repository from the DependencyContainer
            IGeometryShapeRepository repository = DependencyContainer.Instance.GeometryShapeRepository;

            // Store the cubes in the repository
            repository.Save(shape1);
            repository.Save(shape2);

            // Get the instance of the geometry shape calculator from the DependencyContainer
            IGeometryShapeCalculator calculator = DependencyContainer.Instance.GeometryShapeCalculator;

            try
            {
                // Get the intersection result
                string result = calculator.GetIntersectionResult(shape1, shape2);
                Console.WriteLine(result);
                Console.ReadLine();

                // Log the result
                logger.LogInfo(result);
            }
            catch (Exception ex)
            {
                // Log the error
                logger.LogError(ex.Message);
            }
        }

        /// <summary>
        /// Reads data for a cube from the console.
        /// </summary>
        /// <returns>The created cube object</returns>
        private static Cube ReadCubeData()
        {
            Console.WriteLine("Enter center coordinates (x, y, z):");
            string[] centerCoords = Console.ReadLine().Split(',');
            double[] center = Array.ConvertAll(centerCoords, double.Parse);

            Console.WriteLine("Enter Size:");
            double dimension = double.Parse(Console.ReadLine());

            //Assign id to 0 as it will be assigned by the IGeometryShapeRepository
            int id = 0;
            return new Cube(id, center[0], center[1], center[2], dimension);
        }
    }
}

