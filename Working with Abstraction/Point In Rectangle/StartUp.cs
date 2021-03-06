﻿using System;
using System.Linq;

namespace Point_In_Rectangle
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] rectangleCoordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var topLeftPoint = new Point(rectangleCoordinates[0], rectangleCoordinates[1]);
            var bottomRightPoint = new Point(rectangleCoordinates[2], rectangleCoordinates[3]);
            var rectangle = new Rectangle(topLeftPoint, bottomRightPoint);

            int pointCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pointCount; i++)
            {
                int[] pointCoordinates = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                Point currentPoint = new Point(pointCoordinates[0], pointCoordinates[1]);

                Console.WriteLine(rectangle.Contains(currentPoint));
            }
        }
    }
}
