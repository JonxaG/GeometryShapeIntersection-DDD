using GeometryShapeIntersection.Domain;
using System.Collections.Generic;
using System.Linq;

namespace GeometryShapeIntersection.Infrastructure
{
    /// <summary>
    /// Repository class for storing and retrieving objects of type IGeometryShape.
    /// </summary>
    public class GeometryShapeRepository : IGeometryShapeRepository
    {
        private List<IGeometryShape> _geometryShapes;
        private int _nextId;

        /// <summary>
        /// Initializes the list of IGeometryShape objects and sets the initial value of their ID to 1.
        /// </summary>
        public GeometryShapeRepository()
        {
            _geometryShapes = new List<IGeometryShape>();
            _nextId = 1;
        }

        /// <summary>
        /// Saves an IGeometryShape object to the list of IGeometryShapes.
        /// </summary>
        /// <param name="geometryShape">The IGeometryShape object to save</param>
        public void Save(IGeometryShape geometryShape)
        {
            geometryShape.ID = _nextId++;
            _geometryShapes.Add(geometryShape);
        }

        /// <summary>
        /// Retrieves an IGeometryShape object from the list of IGeometryShapes based on its ID.
        /// </summary>
        /// <param name="id">The ID of the IGeometryShape object to retrieve</param>
        /// <returns>The retrieved IGeometryShape object</returns>
        public IGeometryShape Get(int id)
        {
            return _geometryShapes.FirstOrDefault(g => g.ID == id);
        }
    }
}

