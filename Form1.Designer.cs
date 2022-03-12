namespace Repaso2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIngresarVehiculos = new System.Windows.Forms.Button();
            this.buttonIngresarAlquiler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIngresarVehiculos
            // 
            this.buttonIngresarVehiculos.Location = new System.Drawing.Point(133, 454);
            this.buttonIngresarVehiculos.Name = "buttonIngresarVehiculos";
            this.buttonIngresarVehiculos.Size = new System.Drawing.Size(275, 83);
            this.buttonIngresarVehiculos.TabIndex = 0;
            this.buttonIngresarVehiculos.Text = "Ingresar los datos de los vehiculos";
            this.buttonIngresarVehiculos.UseVisualStyleBackColor = true;
            this.buttonIngresarVehiculos.Click += new System.EventHandler(this.buttonIngresarVehiculos_Click);
            // 
            // buttonIngresarAlquiler
            // 
            this.buttonIngresarAlquiler.Location = new System.Drawing.Point(717, 454);
            this.buttonIngresarAlquiler.Name = "buttonIngresarAlquiler";
            this.buttonIngresarAlquiler.Size = new System.Drawing.Size(275, 83);
            this.buttonIngresarAlquiler.TabIndex = 1;
            this.buttonIngresarAlquiler.Text = "Ingresar los datos para el alquiler";
            this.buttonIngresarAlquiler.UseVisualStyleBackColor = true;
            this.buttonIngresarAlquiler.Click += new System.EventHandler(this.buttonIngresarAlquiler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 401);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(556, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(539, 401);
            this.dataGridView2.TabIndex = 3;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(458, 454);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(187, 83);
            this.buttonCargar.TabIndex = 4;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 583);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonIngresarAlquiler);
            this.Controls.Add(this.buttonIngresarVehiculos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIngresarVehiculos;
        private System.Windows.Forms.Button buttonIngresarAlquiler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonCargar;
    }
}

