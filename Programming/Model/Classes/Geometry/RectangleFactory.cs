using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class RectangleFactory
    {
        static Random random = new Random();

        public static Rectangle Randomize(int rectangleWidth, int rectangleHeight)
        {
            int lengthColor = Enum.GetNames(typeof(Model.Enums.Color)).Length;
            var x = random.Next(1, rectangleWidth - 1);
            var y = random.Next(1, rectangleHeight - 1);
            var color = ((Model.Enums.Color)random.Next(lengthColor)).ToString();
            var length = random.Next(1, rectangleWidth - x);
            var width = random.Next(1, rectangleHeight - y);
            var rectangle = new Rectangle(length, width, color, new Point2D(x, y));
            return rectangle;
        }
    }
}
