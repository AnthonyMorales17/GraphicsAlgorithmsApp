using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmsApp
{
    public partial class FrmMidPoint : Form
    {
        private static FrmMidPoint instance;
        private List<(int step, int x, int y, int pk)> circlePixels;
        private int currentPixelIndex = 0;
        private Timer circleTimer;
        private Bitmap bmp;

        public static FrmMidPoint GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmMidPoint();
            }
            return instance;
        }

        public FrmMidPoint()
        {
            InitializeComponent();
        }

        private void FrmCircleBresenham_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                DrawCartesianPlane(g);
            }
            picCanvas.Image = bmp;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRadius.Text, out int radius) || radius <= 0)
            {
                MessageBox.Show("Ingrese un radio válido y positivo.");
                return;
            }

            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                DrawCartesianPlane(g);
            }
            picCanvas.Image = bmp;

            // Obtener los puntos de la circunferencia
            circlePixels = GetCircleSteps(radius, picCanvas.Width, picCanvas.Height);
            currentPixelIndex = 0;
            dgvSteps.Rows.Clear();

            if (circleTimer == null)
            {
                circleTimer = new Timer();
                circleTimer.Interval = 30; // ms entre píxeles, ajusta a gusto
                circleTimer.Tick += CircleTimer_Tick;
            }
            circleTimer.Start();
        }

        private void CircleTimer_Tick(object sender, EventArgs e)
        {
            if (circlePixels == null || currentPixelIndex >= circlePixels.Count)
            {
                circleTimer.Stop();
                // Llenar el DataGridView al final
                dgvSteps.Rows.Clear();
                foreach (var (stepNum, xPix, yPix, pkValue) in circlePixels)
                    dgvSteps.Rows.Add(stepNum, xPix, yPix, pkValue);
                return;
            }

            var (step, x, y, pk) = circlePixels[currentPixelIndex++];
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Point p = CCoordinate.ToPixel(x, y, picCanvas.Width, picCanvas.Height);
                g.FillRectangle(Brushes.Blue, p.X, p.Y, CCoordinate.Scale, CCoordinate.Scale);
            }
            picCanvas.Image = bmp;
            picCanvas.Refresh();
        }

        // Devuelve todos los puntos a pintar en la circunferencia, con sus datos
        private List<(int step, int x, int y, int pk)> GetCircleSteps(int radius, int width, int height)
        {
            var list = new List<(int, int, int, int)>();
            int xc = 0, yc = 0;
            int x = 0, y = radius;
            int p = 1 - radius;
            int step = 1;

            AddCirclePoints(list, xc, yc, x, y, step, p);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                step++;
                AddCirclePoints(list, xc, yc, x, y, step, p);
            }
            return list;
        }

        private void AddCirclePoints(List<(int, int, int, int)> list, int xc, int yc, int x, int y, int step, int pk)
        {
            list.Add((step, xc + x, yc + y, pk));
            list.Add((step, xc - x, yc + y, pk));
            list.Add((step, xc + x, yc - y, pk));
            list.Add((step, xc - x, yc - y, pk));
            list.Add((step, xc + y, yc + x, pk));
            list.Add((step, xc - y, yc + x, pk));
            list.Add((step, xc + y, yc - x, pk));
            list.Add((step, xc - y, yc - x, pk));
        }

        private void btnReseat_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                DrawCartesianPlane(g);
            }
            picCanvas.Image = bmp;
            dgvSteps.Rows.Clear();
            txtRadius.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawCartesianPlane(Graphics g)
        {
            int w = picCanvas.Width;
            int h = picCanvas.Height;
            int step = CCoordinate.Scale;
            int originX = w / 2;
            int originY = h / 2;

            Pen gridPen = new Pen(Color.LightGray, 1);
            Pen axisPen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 7);
            Brush labelBrush = Brushes.Black;

            for (int x = originX; x < w; x += step)
                g.DrawLine(gridPen, x, 0, x, h);
            for (int x = originX; x > 0; x -= step)
                g.DrawLine(gridPen, x, 0, x, h);
            for (int y = originY; y < h; y += step)
                g.DrawLine(gridPen, 0, y, w, y);
            for (int y = originY; y > 0; y -= step)
                g.DrawLine(gridPen, 0, y, w, y);

            // Eje X limitado a ±25
            int xStart = originX - 25 * step;
            int xEnd = originX + 25 * step;
            g.DrawLine(axisPen, xStart, originY, xEnd, originY);//eje X

            g.DrawLine(axisPen, originX, 0, originX, h); // eje Y

            // Etiquetas eje X
            for (int i = 1; i <= 25 && originX + i * step < w; i++)
                g.DrawString(i.ToString(), font, labelBrush, originX + i * step + 2, originY + 2);
            for (int i = 1; i <= 25 && originX - i * step > 0; i++)
                g.DrawString("-" + i, font, labelBrush, originX - i * step + 2, originY + 2);

            // Etiquetas eje Y
            for (int i = 1; i <= 20 && originY - i * step > 0; i++)
                g.DrawString(i.ToString(), font, labelBrush, originX + 2, originY - i * step - 8);
            for (int i = 1; i <= 20 && originY + i * step < h; i++)
                g.DrawString("-" + i, font, labelBrush, originX + 2, originY + i * step - 8);
        }
    }
}
