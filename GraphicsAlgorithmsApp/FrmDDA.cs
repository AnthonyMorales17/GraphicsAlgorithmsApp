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
    public partial class FrmDDA : Form
    {
        // Instancia única del formulario (patrón Singleton)
        private static FrmDDA instance;
        // Bitmap usado como lienzo para dibujar
        private Bitmap mCanvas;
        private Pen drawPen = new Pen(Color.Blue);
        // Objeto que encapsula el algoritmo DDA
        private CDDA dda;
        // Variables para almacenar los puntos seleccionados con el mouse
        private Point? firstClick = null;
        private Point? secondClick = null;
        private List<Point> linePixels;
        private int currentPixelIndex = 0;
        private Timer lineTimer;

        // Constructor del formulario.
        public FrmDDA()
        {
            InitializeComponent();
        }

        // Obtiene una instancia única del formulario (Patrón Singleton).
        public static FrmDDA GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDDA();
            }
            return instance;
        }

        private void FrmDDA_Load(object sender, EventArgs e)
        {
            mCanvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = mCanvas;

            cmbInputMode.Items.Clear();
            cmbInputMode.Items.Add("Seleccione un modo.");
            cmbInputMode.Items.Add("Modo Manual");
            cmbInputMode.Items.Add("Modo Click");
            cmbInputMode.SelectedIndex = 0;

            // Clear canvas
            using (Graphics g = Graphics.FromImage(mCanvas))
            {
                g.Clear(Color.White);
                DrawAxes(g);
            }

            SetTextBoxesEnabled(false);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            if (cmbInputMode.SelectedIndex <= 0)
            {
                MessageBox.Show("Por favor seleccione un modo de ingreso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int x1, y1, x2, y2;

            if (cmbInputMode.SelectedItem.ToString() == "Modo Manual")
            {
                if (!TryGetPoints(out x1, out y1, out x2, out y2))
                {
                    MessageBox.Show("Por favor ingrese coordenadas numéricas válidas en todos los campos.", "Error de Entrada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (cmbInputMode.SelectedItem.ToString() == "Modo Click")
            {
                if (firstClick == null || secondClick == null)
                {
                    MessageBox.Show("Debe marcar 2 puntos en el lienzo primero.", "Error de Selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                x1 = firstClick.Value.X;
                y1 = firstClick.Value.Y;
                x2 = secondClick.Value.X;
                y2 = secondClick.Value.Y;
            }
            else
            {
                MessageBox.Show("Modo Incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Graphics g = Graphics.FromImage(mCanvas))
            {
                g.Clear(Color.White);
                DrawAxes(g);
            }

            dda = new CDDA(mCanvas, drawPen);
            linePixels = dda.GetLinePixels(x1, y1, x2, y2, picCanvas.Width, picCanvas.Height);
            currentPixelIndex = 0;

            dgvSteps.Rows.Clear(); // Limpiar el DataGridView antes de empezar

            // Configura el timer para animar el pintado
            if (lineTimer == null)
            {
                lineTimer = new Timer();
                lineTimer.Interval = 50; // milisegundos entre píxeles
                lineTimer.Tick += LineTimer_Tick;
            }
            lineTimer.Start();
        }

        private void LineTimer_Tick(object sender, EventArgs e)
        {
            if (linePixels == null || currentPixelIndex >= linePixels.Count)
            {
                lineTimer.Stop();

                // Mostrar los píxeles en el DataGridView al finalizar
                dgvSteps.Rows.Clear();
                int step = 1;
                foreach (Point p in linePixels)
                    dgvSteps.Rows.Add(step++, p.X, p.Y);

                return;
            }

            Point pt = linePixels[currentPixelIndex++];
            using (Graphics g = Graphics.FromImage(mCanvas))
            {
                g.FillRectangle(new SolidBrush(drawPen.Color), pt.X, pt.Y, CCoordinate.Scale, CCoordinate.Scale);
            }
            picCanvas.Refresh();
        }

        private bool TryGetPoints(out int x1, out int y1, out int x2, out int y2)
        {
            x1 = y1 = x2 = y2 = 0;
            return int.TryParse(txtX1.Text, out x1) &&
                   int.TryParse(txtY1.Text, out y1) &&
                   int.TryParse(txtX2.Text, out x2) &&
                   int.TryParse(txtY2.Text, out y2);
        }

        private void cmbInputMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbInputMode.SelectedItem.ToString();
            ClearInputs();

            if (selected == "Modo Manual")
            {
                SetTextBoxesEnabled(true);
                MessageBox.Show("Ingrese 4 valores: x1, y1, x2, y2.", "Modo Manual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selected == "Modo Click")
            {
                SetTextBoxesEnabled(false);
                MessageBox.Show("Haga clic en dos puntos sobre el lienzo \n" +
                    " para dibujar la línea.", "Modo Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbInputMode.SelectedItem == null || cmbInputMode.SelectedItem.ToString() != "Modo Click")
                return;

            Point logical = CCoordinate.ToLogical(e.X, e.Y, picCanvas.Width, picCanvas.Height);

            if (firstClick == null)
            {
                firstClick = logical;
                MessageBox.Show($"Primer punto seleccionado: ({logical.X}, {logical.Y})", "Modo Click");
            }
            else if (secondClick == null)
            {
                secondClick = logical;
                MessageBox.Show($"Segundo punto seleccionado: ({logical.X}, {logical.Y})", "Modo Click");
            }
        }

        private void DrawAxes(Graphics g)
        {
            int width = picCanvas.Width;
            int height = picCanvas.Height;
            int centerX = width / 2;
            int centerY = height / 2;
            int scale = CCoordinate.Scale;

            Pen gridPen = new Pen(Color.LightGray, 1);
            Pen axisPen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 7);
            Brush textBrush = Brushes.Black;

            // Dibujar la cuadrícula
            for (int x = centerX; x < width; x += scale)
                g.DrawLine(gridPen, x, 0, x, height);
            for (int x = centerX; x > 0; x -= scale)
                g.DrawLine(gridPen, x, 0, x, height);
            for (int y = centerY; y < height; y += scale)
                g.DrawLine(gridPen, 0, y, width, y);
            for (int y = centerY; y > 0; y -= scale)
                g.DrawLine(gridPen, 0, y, width, y);

            // Dibujar ejes
            int xStart = centerX - 25 * scale;
            int xEnd = centerX + 25 * scale;
            g.DrawLine(axisPen, xStart, centerY, xEnd, centerY); // eje X limitado
            g.DrawLine(axisPen, centerX, 0, centerX, height);    // eje Y completo

            // Etiquetas eje X
            for (int i = 1; i <= 25 && centerX + i * scale < width; i++)
                g.DrawString(i.ToString(), font, textBrush, centerX + i * scale + 2, centerY + 2);
            for (int i = 1; i <= 25 && centerX - i * scale > 0; i++)
                g.DrawString("-" + i, font, textBrush, centerX - i * scale + 2, centerY + 2);

            // Etiquetas eje Y
            for (int i = 1; i <= 20 && centerY - i * scale > 0; i++)
                g.DrawString(i.ToString(), font, textBrush, centerX + 2, centerY - i * scale - 8);
            for (int i = 1; i <= 20 && centerY + i * scale < height; i++)
                g.DrawString("-" + i, font, textBrush, centerX + 2, centerY + i * scale - 8);

            // Etiqueta del origen
            g.DrawString("0", font, textBrush, centerX + 2, centerY + 2);
        }

        private void btnReseat_Click(object sender, EventArgs e)
        {
            ClearInputs();
            cmbInputMode.SelectedIndex = 0;

            using (Graphics g = Graphics.FromImage(mCanvas))
            {
                g.Clear(Color.White);
                DrawAxes(g);
            }

            picCanvas.Refresh();
            dgvSteps.Rows.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetTextBoxesEnabled(bool enabled)
        {
            txtX1.Enabled = enabled;
            txtY1.Enabled = enabled;
            txtX2.Enabled = enabled;
            txtY2.Enabled = enabled;
        }

        private void ClearInputs()
        {
            txtX1.Clear();
            txtY1.Clear();
            txtX2.Clear();
            txtY2.Clear();

            firstClick = null;
            secondClick = null;

            SetTextBoxesEnabled(false);
        }
    }
}
