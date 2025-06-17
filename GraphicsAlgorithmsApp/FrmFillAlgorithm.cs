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
    public partial class FrmFillAlgorithm : Form
    {
        private Bitmap bmp;
        private CFillAlgorithm fillAlgorithm;
        private List<Point> pixelsToAnimate;
        private int currentPixelIndex = 0;
        private Timer fillTimer;
        private static FrmFillAlgorithm instance;
        private bool rhombusDrawn = false;

        public FrmFillAlgorithm()
        {
            InitializeComponent();
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bmp;
        }

        public static FrmFillAlgorithm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmFillAlgorithm();
            }
            return instance;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out int hDiag, out int vDiag))
                return;

            // Centro siempre en el medio del canvas
            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            Point center = new Point(centerX, centerY);

            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bmp;
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            fillAlgorithm = new CFillAlgorithm(bmp);
            fillAlgorithm.DrawRhombus(center, hDiag, vDiag, Color.Black);
            picCanvas.Refresh();
            rhombusDrawn = true;

            MessageBox.Show("Rhombus drawn. Click inside the rhombus to plant the seed and fill.", "Info");
        }

        private void btnReseat_Click(object sender, EventArgs e)
        {
            txtHorizontalDiagonal.Clear();
            txtVerticalDiagonal.Clear();
            bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = bmp;
            dgvPixels.Rows.Clear();
            picCanvas.Refresh();
            rhombusDrawn = false;

            if (fillTimer != null)
                fillTimer.Stop();
            pixelsToAnimate = null;
            currentPixelIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!rhombusDrawn || fillAlgorithm == null)
                return;

            Color targetColor = bmp.GetPixel(e.X, e.Y);

            fillAlgorithm.Reset();
            fillAlgorithm.FloodFillIterative(e.X, e.Y, targetColor, Color.Yellow, picCanvas);

            // Mostrar en DataGridView
            dgvPixels.Rows.Clear();
            int step = 1;
            foreach (Point pt in fillAlgorithm.GetFilledPixels())
                dgvPixels.Rows.Add(step++, pt.X, pt.Y);
        }

        private void FillTimer_Tick(object sender, EventArgs e)
        {
            if (pixelsToAnimate == null || currentPixelIndex >= pixelsToAnimate.Count)
            {
                fillTimer.Stop();
                // Llenar el DataGridView al final
                dgvPixels.Rows.Clear();
                int step = 1;
                foreach (Point pt in pixelsToAnimate)
                    dgvPixels.Rows.Add(step++, pt.X, pt.Y);
                return;
            }

            Point p = pixelsToAnimate[currentPixelIndex++];
            bmp.SetPixel(p.X, p.Y, Color.Yellow);
            picCanvas.Refresh();
        }

        private bool ValidateInputs(out int hDiag, out int vDiag)
        {
            hDiag = vDiag = 0;
            if (string.IsNullOrWhiteSpace(txtHorizontalDiagonal.Text) ||
                string.IsNullOrWhiteSpace(txtVerticalDiagonal.Text))
            {
                MessageBox.Show("Both diagonals are required.", "Error");
                return false;
            }
            bool isNumH = int.TryParse(txtHorizontalDiagonal.Text, out hDiag);
            bool isNumV = int.TryParse(txtVerticalDiagonal.Text, out vDiag);
            if (!isNumH || !isNumV || hDiag <= 0 || vDiag <= 0)
            {
                MessageBox.Show("Diagonals must be positive integers.", "Error");
                return false;
            }
            // Opcional: validar que el rombo quepa en el canvas
            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            if (centerX - hDiag / 2 < 0 || centerX + hDiag / 2 >= bmp.Width ||
                centerY - vDiag / 2 < 0 || centerY + vDiag / 2 >= bmp.Height)
            {
                MessageBox.Show("The rhombus does not fit in the canvas.", "Error");
                return false;
            }
            return true;
        }
    }
}
