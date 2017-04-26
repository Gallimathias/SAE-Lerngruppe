using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public partial class Game : UserControl
    {
        private int y;
        private int direction;
        private int speed;
        private Timer timer;
        private Ball ball;

        public Game()
        {
            InitializeComponent();
            direction = 1;
            speed = 15;
            BackColor = Color.CornflowerBlue;
            y = 100;
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();

            ball = new Ball(new Rectangle(200, 100, 150, 150), 1, new SemiVector(0, 0));


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Update();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var nullPoint = new Point(Width / 2, Height / 2);
            var rect = ball.Rectangle;

            var diff = ball.Position - SemiVector.Null;

            rect = new Rectangle(
                (nullPoint.X + diff.X) - (rect.Width / 2),
                (nullPoint.Y + diff.Y) - (rect.Height / 2),
                rect.Width, rect.Height);

            using (var brush = new SolidBrush(Color.Red))
            {
                e.Graphics.FillEllipse(brush, rect);
            }

            base.OnPaint(e);
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
        }

        public new void Update()
        {

            Invalidate();
        }
    }
}
