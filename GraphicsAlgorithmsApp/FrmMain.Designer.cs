namespace GraphicsAlgorithmsApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seleccioneUnAlgoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoParaLíneasRectasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoParaCircunferencíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeRellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeBresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDelPuntoMedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeRellenoPorInundaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccioneUnAlgoritmoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1218, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seleccioneUnAlgoritmoToolStripMenuItem
            // 
            this.seleccioneUnAlgoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoParaLíneasRectasToolStripMenuItem,
            this.algoritmoParaCircunferencíaToolStripMenuItem,
            this.algoritmoDeRellenoToolStripMenuItem});
            this.seleccioneUnAlgoritmoToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 11F);
            this.seleccioneUnAlgoritmoToolStripMenuItem.Name = "seleccioneUnAlgoritmoToolStripMenuItem";
            this.seleccioneUnAlgoritmoToolStripMenuItem.Size = new System.Drawing.Size(171, 21);
            this.seleccioneUnAlgoritmoToolStripMenuItem.Text = "Seleccione un Algoritmo";
            // 
            // algoritmoParaLíneasRectasToolStripMenuItem
            // 
            this.algoritmoParaLíneasRectasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDeDDAToolStripMenuItem,
            this.algoritmoDeBresenhamToolStripMenuItem});
            this.algoritmoParaLíneasRectasToolStripMenuItem.Name = "algoritmoParaLíneasRectasToolStripMenuItem";
            this.algoritmoParaLíneasRectasToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.algoritmoParaLíneasRectasToolStripMenuItem.Text = "Algoritmo para Líneas Rectas";
            // 
            // algoritmoParaCircunferencíaToolStripMenuItem
            // 
            this.algoritmoParaCircunferencíaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDelPuntoMedioToolStripMenuItem});
            this.algoritmoParaCircunferencíaToolStripMenuItem.Name = "algoritmoParaCircunferencíaToolStripMenuItem";
            this.algoritmoParaCircunferencíaToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.algoritmoParaCircunferencíaToolStripMenuItem.Text = "Algoritmo para Circunferencia";
            // 
            // algoritmoDeRellenoToolStripMenuItem
            // 
            this.algoritmoDeRellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoDeRellenoPorInundaciónToolStripMenuItem});
            this.algoritmoDeRellenoToolStripMenuItem.Name = "algoritmoDeRellenoToolStripMenuItem";
            this.algoritmoDeRellenoToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.algoritmoDeRellenoToolStripMenuItem.Text = "Algoritmo de Relleno";
            // 
            // algoritmoDeDDAToolStripMenuItem
            // 
            this.algoritmoDeDDAToolStripMenuItem.Name = "algoritmoDeDDAToolStripMenuItem";
            this.algoritmoDeDDAToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.algoritmoDeDDAToolStripMenuItem.Text = "Algoritmo de DDA";
            this.algoritmoDeDDAToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDeDDAToolStripMenuItem_Click);
            // 
            // algoritmoDeBresenhamToolStripMenuItem
            // 
            this.algoritmoDeBresenhamToolStripMenuItem.Name = "algoritmoDeBresenhamToolStripMenuItem";
            this.algoritmoDeBresenhamToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.algoritmoDeBresenhamToolStripMenuItem.Text = "Algoritmo de Bresenham";
            this.algoritmoDeBresenhamToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDeBresenhamToolStripMenuItem_Click);
            // 
            // algoritmoDelPuntoMedioToolStripMenuItem
            // 
            this.algoritmoDelPuntoMedioToolStripMenuItem.Name = "algoritmoDelPuntoMedioToolStripMenuItem";
            this.algoritmoDelPuntoMedioToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.algoritmoDelPuntoMedioToolStripMenuItem.Text = "Algoritmo del Punto Medio";
            this.algoritmoDelPuntoMedioToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDelPuntoMedioToolStripMenuItem_Click);
            // 
            // algoritmoDeRellenoPorInundaciónToolStripMenuItem
            // 
            this.algoritmoDeRellenoPorInundaciónToolStripMenuItem.Name = "algoritmoDeRellenoPorInundaciónToolStripMenuItem";
            this.algoritmoDeRellenoPorInundaciónToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.algoritmoDeRellenoPorInundaciónToolStripMenuItem.Text = "Algoritmo de Relleno por Inundación";
            this.algoritmoDeRellenoPorInundaciónToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDeRellenoPorInundaciónToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 707);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos para Gráficar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seleccioneUnAlgoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoParaLíneasRectasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeBresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoParaCircunferencíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDelPuntoMedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeRellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeRellenoPorInundaciónToolStripMenuItem;
    }
}