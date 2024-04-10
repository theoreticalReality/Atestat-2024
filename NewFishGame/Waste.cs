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
        public string wasteType;

        public Waste(string imageLocation, int imageWidth, int imageHeight)
        {
            wastePic = Image.FromFile(imageLocation);
            this.width = imageWidth;
            this.height = imageHeight;

            if (imageLocation.Contains("paper")) wasteType = "paper";
            if (imageLocation.Contains("plastic")) wasteType = "plastic";
            if (imageLocation.Contains("biohazard")) wasteType = "biohazard";
            if (imageLocation.Contains("battery")) wasteType = "battery";

            rect = new Rectangle(position.X, position.Y, width, height);
        }

        public void Delete()
        {
            wastePic.Dispose();
        }
    }
}
