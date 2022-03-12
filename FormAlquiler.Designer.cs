namespace Repaso2
{
    partial class FormAlquiler
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
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.textBoxKmRecorridos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaAlquiler = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGuardarAlquiler = new System.Windows.Forms.Button();
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.labelKmRecorridos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(225, 90);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(457, 22);
            this.textBoxNit.TabIndex = 0;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(225, 151);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(457, 22);
            this.textBoxPlaca.TabIndex = 1;
            // 
            // textBoxKmRecorridos
            // 
            this.textBoxKmRecorridos.Location = new System.Drawing.Point(225, 351);
            this.textBoxKmRecorridos.Name = "textBoxKmRecorridos";
            this.textBoxKmRecorridos.Size = new System.Drawing.Size(457, 22);
            this.textBoxKmRecorridos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "NIT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de alquiler:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de devolucion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kilometros recorridos:";
            // 
            // dateTimePickerFechaAlquiler
            // 
            this.dateTimePickerFechaAlquiler.Location = new System.Drawing.Point(225, 218);
            this.dateTimePickerFechaAlquiler.Name = "dateTimePickerFechaAlquiler";
            this.dateTimePickerFechaAlquiler.Size = new System.Drawing.Size(457, 22);
            this.dateTimePickerFechaAlquiler.TabIndex = 10;
            // 
            // dateTimePickerFechaDevolucion
            // 
            this.dateTimePickerFechaDevolucion.Location = new System.Drawing.Point(225, 287);
            this.dateTimePickerFechaDevolucion.Name = "dateTimePickerFechaDevolucion";
            this.dateTimePickerFechaDevolucion.Size = new System.Drawing.Size(457, 22);
            this.dateTimePickerFechaDevolucion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ingrese los datos para el alquiler:";
            // 
            // buttonGuardarAlquiler
            // 
            this.buttonGuardarAlquiler.Location = new System.Drawing.Point(189, 411);
            this.buttonGuardarAlquiler.Name = "buttonGuardarAlquiler";
            this.buttonGuardarAlquiler.Size = new System.Drawing.Size(251, 66);
            this.buttonGuardarAlquiler.TabIndex = 13;
            this.buttonGuardarAlquiler.Text = "Guardar";
            this.buttonGuardarAlquiler.UseVisualStyleBackColor = true;
            this.buttonGuardarAlquiler.Click += new System.EventHandler(this.buttonGuardarAlquiler_Click);
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrar.Location = new System.Drawing.Point(702, 12);
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.RowHeadersWidth = 51;
            this.dataGridViewMostrar.RowTemplate.Height = 24;
            this.dataGridViewMostrar.Size = new System.Drawing.Size(464, 361);
            this.dataGridViewMostrar.TabIndex = 14;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(820, 411);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(251, 66);
            this.buttonMostrar.TabIndex = 15;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // labelKmRecorridos
            // 
            this.labelKmRecorridos.AutoSize = true;
            this.labelKmRecorridos.Location = new System.Drawing.Point(474, 436);
            this.labelKmRecorridos.Name = "labelKmRecorridos";
            this.labelKmRecorridos.Size = new System.Drawing.Size(131, 16);
            this.labelKmRecorridos.TabIndex = 16;
            this.labelKmRecorridos.Text = "Mas Km Recorridos: ";
            // 
            // FormAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 489);
            this.Controls.Add(this.labelKmRecorridos);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridViewMostrar);
            this.Controls.Add(this.buttonGuardarAlquiler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerFechaDevolucion);
            this.Controls.Add(this.dateTimePickerFechaAlquiler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKmRecorridos);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.textBoxNit);
            this.Name = "FormAlquiler";
            this.Text = "FormAlquiler";
            this.Load += new System.EventHandler(this.FormAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.TextBox textBoxKmRecorridos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaAlquiler;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDevolucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGuardarAlquiler;
        private System.Windows.Forms.DataGridView dataGridViewMostrar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Label labelKmRecorridos;
    }
}