using System.Collections.Generic;
using GeometryShapeIntersection.Domain;

namespace GeometryShapeIntersection.Infrastructure
{
    /// <summary>
    /// Interface for the GeometryShapeRepository class.
    /// </summary>
    public interface IGeometryShapeRepository
    {
        /// <summary>
        /// Method to save a geometry shape in the repository.
        /// </summary>
        /// <param name="geometryShape">The geometry shape to be saved</param>
        void Save(IGeometryShape geometryShape);

        /// <summary>
        /// Method to retrieve a geometry shape from the repository using its ID.
        /// </summary>
        /// <param name="id">The ID of the geometry shape to retrieve</param>
        /// <returns>The retrieved geometry shape</returns>
        IGeometryShape Get(int id);
    }
}



