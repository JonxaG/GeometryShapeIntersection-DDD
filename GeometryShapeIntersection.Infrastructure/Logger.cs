using GeometryShapeIntersection.Infrastructure;
using System;

namespace GeometryShapeIntersection.Infrastructure
{
    public class Logger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"ERROR: {message}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }
    }
}



