namespace GraphicsAlgorithmsApp
{
    partial class FrmFillAlgorithm
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
            this.dgvPixels = new System.Windows.Forms.DataGridView();
            this.Paso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReseat = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtVerticalDiagonal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHorizontalDiagonal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbGraph = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPixels)).BeginInit();
            this.grbProcess.SuspendLayout();
            this.grbInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPixels
            // 
            this.dgvPixels.AllowUserToAddRows = false;
            this.dgvPixels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPixels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPixels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paso,
            this.X,
            this.Y});
            this.dgvPixels.Location = new System.Drawing.Point(684, 12);
            this.dgvPixels.Name = "dgvPixels";
            this.dgvPixels.Size = new System.Drawing.Size(194, 407);
            this.dgvPixels.TabIndex = 10;
            // 
            // Paso
            // 
            this.Paso.HeaderText = "Paso";
            this.Paso.MaxInputLength = 100;
            this.Paso.Name = "Paso";
            this.Paso.Width = 65;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 42;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Width = 42;
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReseat);
            this.grbProcess.Controls.Add(this.btnGraph);
            this.grbProcess.Location = new System.Drawing.Point(6, 120);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(261, 134);
            this.grbProcess.TabIndex = 8;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(90, 94);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReseat
            // 
            this.btnReseat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReseat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReseat.Location = new System.Drawing.Point(90, 56);
            this.btnReseat.Name = "btnReseat";
            this.btnReseat.Size = new System.Drawing.Size(85, 30);
            this.btnReseat.TabIndex = 1;
            this.btnReseat.Text = "Reiniciar";
            this.btnReseat.UseVisualStyleBackColor = false;
            this.btnReseat.Click += new System.EventHandler(this.btnReseat_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGraph.Location = new System.Drawing.Point(90, 18);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(85, 30);
            this.btnGraph.TabIndex = 0;
            this.btnGraph.Text = "Graficar";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtVerticalDiagonal);
            this.grbInputs.Controls.Add(this.label4);
            this.grbInputs.Controls.Add(this.txtHorizontalDiagonal);
            this.grbInputs.Controls.Add(this.label3);
            this.grbInputs.Location = new System.Drawing.Point(6, 5);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(261, 109);
            this.grbInputs.TabIndex = 7;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Ingrese los siguientes datos:";
            // 
            // txtVerticalDiagonal
            // 
            this.txtVerticalDiagonal.Location = new System.Drawing.Point(113, 70);
            this.txtVerticalDiagonal.Name = "txtVerticalDiagonal";
            this.txtVerticalDiagonal.Size = new System.Drawing.Size(62, 23);
            this.txtVerticalDiagonal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diag Vertical:";
            // 
            // txtHorizontalDiagonal
            // 
            this.txtHorizontalDiagonal.Location = new System.Drawing.Point(113, 28);
            this.txtHorizontalDiagonal.Name = "txtHorizontalDiagonal";
            this.txtHorizontalDiagonal.Size = new System.Drawing.Size(62, 23);
            this.txtHorizontalDiagonal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Diag Horizontal:";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(4, 16);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(400, 400);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // grbGraph
            // 
            this.grbGraph.Controls.Add(this.picCanvas);
            this.grbGraph.Location = new System.Drawing.Point(273, 6);
            this.grbGraph.Name = "grbGraph";
            this.grbGraph.Size = new System.Drawing.Size(405, 420);
            this.grbGraph.TabIndex = 9;
            this.grbGraph.TabStop = false;
            this.grbGraph.Text = "Gráfico:";
            // 
            // FrmFillAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 431);
            this.Controls.Add(this.dgvPixels);
            this.Controls.Add(this.grbGraph);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFillAlgorithm";
            this.Text = "Algoritmo de Relleno por Inundación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPixels)).EndInit();
            this.grbProcess.ResumeLayout(false);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbGraph.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPixels;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paso;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReseat;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtHorizontalDiagonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVerticalDiagonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbGraph;
    }
}