﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Composite
{
    public class GraphicObject
    {
        public virtual string Name { get; set; } = "Group";
        public string Color;

        private Lazy<List<GraphicObject>> children = new Lazy<List<GraphicObject>>();
        public List<GraphicObject> Children => children.Value;

        public void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('*', depth))
                .Append(String.IsNullOrEmpty(Color) ? string.Empty : $"{ Color}")
                .AppendLine(Name);

            foreach(var child in Children)
            {
                child.Print(sb, depth + 1);
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);
            return sb.ToString();
        }

    }

    public class Circle : GraphicObject
    {
        public override string Name => "Circle";

    }

    public class Square : GraphicObject
    {
        public override string Name => "Square";
    }
}
