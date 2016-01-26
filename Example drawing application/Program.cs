/*
* Copyright (C) Jere-Joonas Valtanen
*
* This file is part of JAMK object oriented programming course
*
* Created: 26.1.2016
*Author: Jere-Joonas Valtanen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_drawing_application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ei pysty DrawingObject do = new DrawingObject();

            Circle circle = new Circle();
            circle.Name = "My Circle";
            circle.Draw();

            Square square = new Square();
            square.Name = "My Square";
            square.Draw();


            // Create a List collection for Drawing Objects

            List<DrawingObject> drawingobjects = new List<DrawingObject>();
            // Add a few objects to the collection
            drawingobjects.Add(new Circle());
            drawingobjects.Add(new Square());
            drawingobjects.Add(new Circle());
            drawingobjects.Add(new Square());
            drawingobjects.Add(new Circle());
            drawingobjects.Add(new Square());
            drawingobjects.Add(new Circle());
            drawingobjects.Add(new Square());
            drawingobjects.Add(new Circle());
            drawingobjects.Add(new Square());

            // loop collection and draw objects
            Console.WriteLine("Drawing objects in a List:");
            foreach (DrawingObject drawingObject in drawingobjects)
            {
                drawingObject.Draw();
            }
        }
    }
}
