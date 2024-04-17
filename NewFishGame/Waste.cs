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

        public Waste(string imageLocation)
        {
            wastePic = Image.FromFile(imageLocation);
            
            if (imageLocation.Contains("bottle"))
            {
                this.width = 30;
                this.height = 80;
            }
            if (imageLocation.Contains("narrow"))
            {
                this.width = 20;
                this.height = 100;
            }
            if (imageLocation.Contains("long"))
            {
                this.width = 50;
                this.height = 100;
            }
            if (imageLocation.Contains("small"))
            {
                this.width = 30;
                this.height = 45;
            }
            if (imageLocation.Contains("wide"))
            {
                this.width = 80;
                this.height = 50;
            }
            if (imageLocation.Contains("even"))
            {
                this.width = 80;
                this.height = 80;
            }
            if (imageLocation.Contains("stick"))
            {
                this.width = 100;
                this.height = 20;
            }

            if (imageLocation.Contains("paper")) wasteType = "paper";
            if (imageLocation.Contains("plastic")) wasteType = "plastic";
            if (imageLocation.Contains("biohazard")) wasteType = "biohazard";
            if (imageLocation.Contains("battery")) wasteType = "battery";

            rect = new Rectangle(position.X, position.Y, width, height);
        }
    }
}
