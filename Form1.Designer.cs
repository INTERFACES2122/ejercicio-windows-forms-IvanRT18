
namespace Ejercicio_Formularios
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.LabelAgregar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelApellidoPaterno = new System.Windows.Forms.Label();
            this.textboxApellido = new System.Windows.Forms.TextBox();
            this.labelApellidoMaterno = new System.Windows.Forms.Label();
            this.textBoxApellidoMaterno = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellidosPaternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(30, 107);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(211, 22);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // LabelAgregar
            // 
            this.LabelAgregar.AutoSize = true;
            this.LabelAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.LabelAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAgregar.ForeColor = System.Drawing.Color.Firebrick;
            this.LabelAgregar.Location = new System.Drawing.Point(222, 9);
            this.LabelAgregar.Name = "LabelAgregar";
            this.LabelAgregar.Size = new System.Drawing.Size(220, 32);
            this.LabelAgregar.TabIndex = 1;
            this.LabelAgregar.Text = "Agregar Alumno";
            this.LabelAgregar.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelApellidoPaterno
            // 
            this.labelApellidoPaterno.AutoSize = true;
            this.labelApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoPaterno.Location = new System.Drawing.Point(319, 66);
            this.labelApellidoPaterno.Name = "labelApellidoPaterno";
            this.labelApellidoPaterno.Size = new System.Drawing.Size(198, 29);
            this.labelApellidoPaterno.TabIndex = 3;
            this.labelApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // textboxApellido
            // 
            this.textboxApellido.Location = new System.Drawing.Point(324, 107);
            this.textboxApellido.Name = "textboxApellido";
            this.textboxApellido.Size = new System.Drawing.Size(236, 22);
            this.textboxApellido.TabIndex = 4;
            this.textboxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxApellido_KeyPress);
            // 
            // labelApellidoMaterno
            // 
            this.labelApellidoMaterno.AutoSize = true;
            this.labelApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoMaterno.Location = new System.Drawing.Point(25, 164);
            this.labelApellidoMaterno.Name = "labelApellidoMaterno";
            this.labelApellidoMaterno.Size = new System.Drawing.Size(202, 29);
            this.labelApellidoMaterno.TabIndex = 5;
            this.labelApellidoMaterno.Text = "Apellido Materno:";
            // 
            // textBoxApellidoMaterno
            // 
            this.textBoxApellidoMaterno.Location = new System.Drawing.Point(30, 208);
            this.textBoxApellidoMaterno.Name = "textBoxApellidoMaterno";
            this.textBoxApellidoMaterno.Size = new System.Drawing.Size(236, 22);
            this.textBoxApellidoMaterno.TabIndex = 6;
            this.textBoxApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidoMaterno_KeyPress);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(341, 208);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 7;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(435, 208);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 8;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.LimpiarGrid);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.Firebrick;
            this.labelBuscar.Location = new System.Drawing.Point(24, 262);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(111, 32);
            this.labelBuscar.TabIndex = 9;
            this.labelBuscar.Text = "Buscar:";
            this.labelBuscar.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(30, 297);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(474, 22);
            this.textBoxBuscar.TabIndex = 10;
            // 
            // dataGridAlumnos
            // 
            this.dataGridAlumnos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaApellidosPaternos,
            this.ColumnaApellidoMaterno});
            this.dataGridAlumnos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridAlumnos.Location = new System.Drawing.Point(30, 343);
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.ReadOnly = true;
            this.dataGridAlumnos.RowHeadersWidth = 51;
            this.dataGridAlumnos.RowTemplate.Height = 24;
            this.dataGridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAlumnos.Size = new System.Drawing.Size(570, 362);
            this.dataGridAlumnos.TabIndex = 11;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.MinimumWidth = 6;
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.Width = 125;
            // 
            // ColumnaApellidosPaternos
            // 
            this.ColumnaApellidosPaternos.HeaderText = "Apellido paterno";
            this.ColumnaApellidosPaternos.MinimumWidth = 6;
            this.ColumnaApellidosPaternos.Name = "ColumnaApellidosPaternos";
            this.ColumnaApellidosPaternos.Width = 125;
            // 
            // ColumnaApellidoMaterno
            // 
            this.ColumnaApellidoMaterno.HeaderText = "Apellido Materno";
            this.ColumnaApellidoMaterno.MinimumWidth = 6;
            this.ColumnaApellidoMaterno.Name = "ColumnaApellidoMaterno";
            this.ColumnaApellidoMaterno.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 736);
            this.Controls.Add(this.dataGridAlumnos);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.textBoxApellidoMaterno);
            this.Controls.Add(this.labelApellidoMaterno);
            this.Controls.Add(this.textboxApellido);
            this.Controls.Add(this.labelApellidoPaterno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelAgregar);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Agregar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label LabelAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelApellidoPaterno;
        private System.Windows.Forms.TextBox textboxApellido;
        private System.Windows.Forms.Label labelApellidoMaterno;
        private System.Windows.Forms.TextBox textBoxApellidoMaterno;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellidosPaternos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellidoMaterno;
    }
}

