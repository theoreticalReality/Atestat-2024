using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFishGame
{
    internal class Waste
    {
        public Image wastePic;
        public int height;
        public int width;

        public Point position = new Point();
        public Rectangle rect;

        public bool active;

        public Waste(string imageLocation, int imageWidth, int imageHeight)
        {
            wastePic = Image.FromFile(imageLocation);
            this.width = imageWidth;
            this.height = imageHeight;

            rect = new Rectangle(position.X, position.Y, width, height);
        }
    }
}
