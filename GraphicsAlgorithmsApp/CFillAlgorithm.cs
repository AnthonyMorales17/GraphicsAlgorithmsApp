using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmsApp
{
    class CFillAlgorithm
    {
        private Bitmap canvas;
        private HashSet<Point> visited;
        private List<Point> filledPixels;

        public CFillAlgorithm(Bitmap bmp)
        {
            canvas = bmp;
            filledPixels = new List<Point>();
            visited = new HashSet<Point>();
        }

        public void DrawRhombus(Point center, int horizontalDiagonal, int verticalDiagonal, Color borderColor)
        {
            int h = horizontalDiagonal / 2;
            int v = verticalDiagonal / 2;

            Point top = new Point(center.X, center.Y - v);
            Point right = new Point(center.X + h, center.Y);
            Point bottom = new Point(center.X, center.Y + v);
            Point left = new Point(center.X - h, center.Y);

            DrawLine(top, right, borderColor);
            DrawLine(right, bottom, borderColor);
            DrawLine(bottom, left, borderColor);
            DrawLine(left, top, borderColor);
        }

        private void DrawLine(Point p1, Point p2, Color color)
        {
            int x1 = p1.X, y1 = p1.Y, x2 = p2.X, y2 = p2.Y;
            int dx = Math.Abs(x2 - x1), dy = Math.Abs(y2 - y1);
            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                if (x1 >= 0 && x1 < canvas.Width && y1 >= 0 && y1 < canvas.Height)
                    canvas.SetPixel(x1, y1, color);

                if (x1 == x2 && y1 == y2) break;
                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x1 += sx; }
                if (e2 < dx) { err += dx; y1 += sy; }
            }
        }

        public void FloodFillIterative(int x, int y, Color targetColor, Color fillColor, PictureBox picCanvas)
        {
            HashSet<Point> visited = new HashSet<Point>();
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(x, y));

            while (queue.Count > 0)
            {
                Point p = queue.Dequeue();

                if (p.X < 0 || p.X >= canvas.Width || p.Y < 0 || p.Y >= canvas.Height)
                    continue;
                if (visited.Contains(p))
                    continue;
                visited.Add(p);

                Color currentColor = canvas.GetPixel(p.X, p.Y);
                if (currentColor.ToArgb() != targetColor.ToArgb())
                    continue;

                canvas.SetPixel(p.X, p.Y, fillColor);
                filledPixels.Add(p);

                picCanvas.Image = canvas;
                picCanvas.Refresh();
                Application.DoEvents();
                Thread.Sleep(2);

                // Orden NSEW
                queue.Enqueue(new Point(p.X, p.Y - 1)); // Norte
                queue.Enqueue(new Point(p.X + 1, p.Y)); // Este
                queue.Enqueue(new Point(p.X, p.Y + 1)); // Sur
                queue.Enqueue(new Point(p.X - 1, p.Y)); // Oeste
            }
        }

        public List<Point> GetFilledPixels()
        {
            return filledPixels;
        }

        public void Reset()
        {
            filledPixels.Clear();
            visited.Clear();
        }
    }
}
