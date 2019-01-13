using System;

namespace Structural.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GrpahicObject
            var graphics = new GraphicObject { Name = "Graphics" };
            graphics.Children.Add(new Circle { Color = "Red" });
            graphics.Children.Add(new Square { Color = "Red" });

            var groups = new GraphicObject();
            groups.Children.Add(new Circle { Color = "Blue" });
            groups.Children.Add(new Square { Color = "Blue" });
            graphics.Children.Add(groups);

            Console.WriteLine(graphics.ToString()); 

            #endregion
        }
    }
}
