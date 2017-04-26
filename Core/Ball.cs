using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Ball
    {
        public Rectangle Rectangle { get; private set; }
        private Materials Material;
        private double weight;
        private double diameter;

        public Color color { get; private set; }

        public SemiVector Position { get; private set; }

        public double Speed { get; set; }

        public Ball(Rectangle rectangle, double weight)
        {
            Rectangle = rectangle;
            this.weight = weight;
        }

        public Ball(Rectangle rectangle, double weight, SemiVector position) : this(rectangle, weight)
        {
            Position = position;
        }

        public void Move(int x, int y)
        {
            var vect = new SemiVector(x, y);
            Position += vect;
        }
    }
}
