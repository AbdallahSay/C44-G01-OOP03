using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUpdated
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {
            Width = default;
            Height = default;
        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }
        public override string ToString()
        {
            return $"Width = {Width} , Height = {Height}";
        }
    }
}
