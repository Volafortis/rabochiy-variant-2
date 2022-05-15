using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathematicalPendulum
{
    class Draw
    {
        private int Width, Height;

        private Pen BitmapPen = new Pen(Color.Black);
        private SolidBrush BitmapSolidBrushAnchor = new SolidBrush(Color.Black);
        private SolidBrush BitmapSolidBrushBall = new SolidBrush(Color.DarkGoldenrod);

        public Draw(int BitmapWidth, int BitmapHeight)
        {
            Width = BitmapWidth;
            Height = BitmapHeight;
        }

        // Задание ручки для рисования маятника
        public void SetPen(Pen NewPen)
        {
            BitmapPen = NewPen;
        }

        // Задание кисти для рисования подвеса маятника
        public void SetAnchorBrush(SolidBrush AnchorBrush)
        {
            BitmapSolidBrushAnchor = AnchorBrush;
        }

        // Задание кисти для рисования маятника
        public void SetBallBrush(SolidBrush BallBrush)
        {
            BitmapSolidBrushBall = BallBrush;
        }

        // Рисование маятника
        public Bitmap DrawPendulum(int anchorX, int anchorY, int ballX, int ballY)
        {
            Bitmap dblBuffer = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(dblBuffer);

            g.DrawLine(BitmapPen, new Point(anchorX, anchorY), new Point(ballX, ballY));
            g.FillEllipse(BitmapSolidBrushAnchor, anchorX - 3, anchorY - 4, 7, 7);
            g.FillEllipse(BitmapSolidBrushBall, ballX - 7, ballY - 7, 14, 14);

            return dblBuffer;
        }

        public void SendChart_(Chart ChartI, double angle, double speed)
        {
            ChartI.Series[0].Points.AddXY(angle, speed);
        }

        public void SendChart(Chart ChartI, double angle, double time)
        {
            ChartI.Series[0].Points.AddXY(time, angle);
        }

        // Перегрузка метода рисования маятника
        public Bitmap DrawPendulum(int[] Points)
        {
            return DrawPendulum(Points[0], Points[1], Points[2], Points[3]);
        }
    }
}
