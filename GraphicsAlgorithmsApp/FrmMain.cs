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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void OpenFigureForm<T>() where T : Form
        {
            // Utilizamos reflexión para llamar al método estático GetInstance()
            var method = typeof(T).GetMethod("GetInstance", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            // Si no se encuentra el método, salir del método sin hacer nada.
            if (method == null) return;

            // Invocar el método estático GetInstance() que devuelve una instancia del formulario
            var form = method.Invoke(null, null) as Form;

            // Si se obtuvo un formulario válido
            if (form != null)
            {
                // Asignar el formulario actual como padre MDI si aún no tiene uno
                if (form.MdiParent == null)
                {
                    form.MdiParent = this; // 'this' hace referencia al formulario principal MDI
                }

                //Mostrar el formulario si no está visible.
                if (!form.Visible)
                {
                    form.Show();
                }
                else
                {
                    // Si ya está abierto, llevarlo al frente.
                    form.BringToFront();
                }
            }
        }

        private void algoritmoDeDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmDDA>();
        }

        private void algoritmoDeBresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmBresenham>();
        }

        private void algoritmoDelPuntoMedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmMidPoint>();
        }

        private void algoritmoDeRellenoPorInundaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFigureForm<FrmFillAlgorithm>();
        }
    }
}
