using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmsApp
{
    class CDDA : CLineDrawing
    {
        public List<StepData> StepsList { get; private set; } = new List<StepData>();

        public CDDA(Bitmap canvas, Pen pen) : base(canvas, pen) { }

        public void DrawWithSteps(int x1, int y1, int x2, int y2, Graphics g, DataGridView dgv, int width, int height)
        {
            dgv.Rows.Clear();
            Pixels.Clear();

            float dx = x2 - x1;
            float dy = y2 - y1;
            float stepsCount = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xInc = dx / stepsCount;
            float yInc = dy / stepsCount;

            float x = x1;
            float y = y1;

            for (int i = 0; i <= stepsCount; i++)
            {
                int logicX = (int)Math.Round(x);
                int logicY = (int)Math.Round(y);

                Point p = CCoordinate.ToPixel(logicX, logicY, width, height);
                g.FillRectangle(Brushes.Black, p.X, p.Y, CCoordinate.Scale, CCoordinate.Scale);
                Pixels.Add(p);

                // Solo agregas los valores necesarios, en el orden de tus columnas del diseñador
                dgv.Rows.Add(i, x, y, logicY);

                x += xInc;
                y += yInc;
            }
        }

        public List<Point> GetLinePixels(int x1, int y1, int x2, int y2, int width, int height)
        {
            List<Point> points = new List<Point>();

            float dx = x2 - x1;
            float dy = y2 - y1;
            float stepsCount = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xInc = dx / stepsCount;
            float yInc = dy / stepsCount;

            float x = x1;
            float y = y1;

            for (int i = 0; i <= stepsCount; i++)
            {
                int logicX = (int)Math.Round(x);
                int logicY = (int)Math.Round(y);

                Point p = CCoordinate.ToPixel(logicX, logicY, width, height);
                points.Add(p);

                x += xInc;
                y += yInc;
            }
            return points;
        }

        public class StepData
        {
            public int Pasos { get; set; }
            public float X { get; set; }
            public float Y { get; set; }
        }
    }
}
