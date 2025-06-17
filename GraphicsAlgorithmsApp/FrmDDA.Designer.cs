namespace GraphicsAlgorithmsApp
{
    partial class FrmDDA
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
            this.dgvSteps = new System.Windows.Forms.DataGridView();
            this.Pasos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbInputMode = new System.Windows.Forms.ComboBox();
            this.btnGraph = new System.Windows.Forms.Button();
            this.grbGraph = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReseat = new System.Windows.Forms.Button();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbProcess.SuspendLayout();
            this.grbInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSteps
            // 
            this.dgvSteps.AllowUserToAddRows = false;
            this.dgvSteps.AllowUserToDeleteRows = false;
            this.dgvSteps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pasos,
            this.X,
            this.Y});
            this.dgvSteps.Location = new System.Drawing.Point(651, 12);
            this.dgvSteps.Name = "dgvSteps";
            this.dgvSteps.ReadOnly = true;
            this.dgvSteps.Size = new System.Drawing.Size(232, 365);
            this.dgvSteps.TabIndex = 10;
            // 
            // Pasos
            // 
            this.Pasos.HeaderText = "Pasos";
            this.Pasos.MaxInputLength = 3;
            this.Pasos.MinimumWidth = 3;
            this.Pasos.Name = "Pasos";
            this.Pasos.ReadOnly = true;
            this.Pasos.Width = 61;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MaxInputLength = 3;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 39;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MaxInputLength = 3;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 39;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbInputMode);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 102);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione Modo:";
            // 
            // cmbInputMode
            // 
            this.cmbInputMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInputMode.FormattingEnabled = true;
            this.cmbInputMode.Items.AddRange(new object[] {
            "Modo Manual",
            "Modo Click"});
            this.cmbInputMode.Location = new System.Drawing.Point(23, 35);
            this.cmbInputMode.Name = "cmbInputMode";
            this.cmbInputMode.Size = new System.Drawing.Size(177, 21);
            this.cmbInputMode.TabIndex = 0;
            this.cmbInputMode.SelectedIndexChanged += new System.EventHandler(this.cmbInputMode_SelectedIndexChanged);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGraph.Location = new System.Drawing.Point(7, 31);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(68, 30);
            this.btnGraph.TabIndex = 0;
            this.btnGraph.Text = "Gráficar";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // grbGraph
            // 
            this.grbGraph.Controls.Add(this.picCanvas);
            this.grbGraph.Location = new System.Drawing.Point(242, 5);
            this.grbGraph.Name = "grbGraph";
            this.grbGraph.Size = new System.Drawing.Size(403, 372);
            this.grbGraph.TabIndex = 8;
            this.grbGraph.TabStop = false;
            this.grbGraph.Text = "Gráfico:";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(390, 347);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnGraph);
            this.grbProcess.Controls.Add(this.btnReseat);
            this.grbProcess.Location = new System.Drawing.Point(6, 254);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(230, 75);
            this.grbProcess.TabIndex = 6;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(158, 31);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReseat
            // 
            this.btnReseat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReseat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReseat.Location = new System.Drawing.Point(79, 31);
            this.btnReseat.Name = "btnReseat";
            this.btnReseat.Size = new System.Drawing.Size(76, 30);
            this.btnReseat.TabIndex = 1;
            this.btnReseat.Text = "Reiniciar";
            this.btnReseat.UseVisualStyleBackColor = false;
            this.btnReseat.Click += new System.EventHandler(this.btnReseat_Click);
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtY2);
            this.grbInputs.Controls.Add(this.txtX2);
            this.grbInputs.Controls.Add(this.label3);
            this.grbInputs.Controls.Add(this.label4);
            this.grbInputs.Controls.Add(this.txtY1);
            this.grbInputs.Controls.Add(this.txtX1);
            this.grbInputs.Controls.Add(this.label2);
            this.grbInputs.Controls.Add(this.label1);
            this.grbInputs.Location = new System.Drawing.Point(6, 110);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(230, 138);
            this.grbInputs.TabIndex = 5;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Ingrese los puntos de la Línea:";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(119, 102);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(90, 20);
            this.txtY2.TabIndex = 7;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(119, 76);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(90, 20);
            this.txtX2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Punto Final (Y):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Punto Final (X):";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(119, 50);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(90, 20);
            this.txtY1.TabIndex = 3;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(119, 24);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(90, 20);
            this.txtX1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Punto Inicial (Y):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto Inicial (X):";
            // 
            // FrmDDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 384);
            this.Controls.Add(this.dgvSteps);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbGraph);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "FrmDDA";
            this.Text = "Algoritmo DDA";
            this.Load += new System.EventHandler(this.FrmDDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grbGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbProcess.ResumeLayout(false);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSteps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbInputMode;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.GroupBox grbGraph;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnReseat;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasos;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}