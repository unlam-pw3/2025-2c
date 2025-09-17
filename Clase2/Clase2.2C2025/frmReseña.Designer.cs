namespace Clase2._2C2025
{
    partial class frmReseña
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpFecha = new DateTimePicker();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTipoLocal = new Label();
            cboTipoLocal = new ComboBox();
            cboPuntuacion = new ComboBox();
            lblPuntuacion = new Label();
            btnGuardarReseña = new Button();
            dgvReseñas = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TipoLocal = new DataGridViewTextBoxColumn();
            Puntuacion = new DataGridViewTextBoxColumn();
            btnAlta = new Button();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReseñas).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(12, 12);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(318, 23);
            dtpFecha.TabIndex = 0;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(12, 54);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 72);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(318, 23);
            txtDireccion.TabIndex = 2;
            // 
            // lblTipoLocal
            // 
            lblTipoLocal.AutoSize = true;
            lblTipoLocal.Location = new Point(12, 115);
            lblTipoLocal.Name = "lblTipoLocal";
            lblTipoLocal.Size = new Size(77, 15);
            lblTipoLocal.TabIndex = 3;
            lblTipoLocal.Text = "Tipo de Local";
            // 
            // cboTipoLocal
            // 
            cboTipoLocal.FormattingEnabled = true;
            cboTipoLocal.Items.AddRange(new object[] { "Parrilla", "Cafe de especialidad", "Panadería", "Fabrica de pastas" });
            cboTipoLocal.Location = new Point(12, 133);
            cboTipoLocal.Name = "cboTipoLocal";
            cboTipoLocal.Size = new Size(318, 23);
            cboTipoLocal.TabIndex = 4;
            // 
            // cboPuntuacion
            // 
            cboPuntuacion.FormattingEnabled = true;
            cboPuntuacion.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboPuntuacion.Location = new Point(12, 186);
            cboPuntuacion.Name = "cboPuntuacion";
            cboPuntuacion.Size = new Size(318, 23);
            cboPuntuacion.TabIndex = 6;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(12, 168);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(68, 15);
            lblPuntuacion.TabIndex = 5;
            lblPuntuacion.Text = "Puntuacion";
            // 
            // btnGuardarReseña
            // 
            btnGuardarReseña.Location = new Point(12, 224);
            btnGuardarReseña.Name = "btnGuardarReseña";
            btnGuardarReseña.Size = new Size(134, 59);
            btnGuardarReseña.TabIndex = 7;
            btnGuardarReseña.Text = "Guardar Reseña";
            btnGuardarReseña.UseVisualStyleBackColor = true;
            btnGuardarReseña.Click += btnGuardarReseña_Click;
            // 
            // dgvReseñas
            // 
            dgvReseñas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReseñas.Columns.AddRange(new DataGridViewColumn[] { Fecha, Direccion, TipoLocal, Puntuacion });
            dgvReseñas.Location = new Point(12, 299);
            dgvReseñas.Name = "dgvReseñas";
            dgvReseñas.Size = new Size(559, 122);
            dgvReseñas.TabIndex = 8;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // TipoLocal
            // 
            TipoLocal.HeaderText = "Tipo Local";
            TipoLocal.Name = "TipoLocal";
            TipoLocal.ReadOnly = true;
            // 
            // Puntuacion
            // 
            Puntuacion.HeaderText = "Puntuacion";
            Puntuacion.Name = "Puntuacion";
            Puntuacion.ReadOnly = true;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(501, 100);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(70, 56);
            btnAlta.TabIndex = 9;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(196, 224);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(134, 59);
            btnRefrescar.TabIndex = 10;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // frmReseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 455);
            Controls.Add(btnRefrescar);
            Controls.Add(btnAlta);
            Controls.Add(dgvReseñas);
            Controls.Add(btnGuardarReseña);
            Controls.Add(cboPuntuacion);
            Controls.Add(lblPuntuacion);
            Controls.Add(cboTipoLocal);
            Controls.Add(lblTipoLocal);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(dtpFecha);
            Name = "frmReseña";
            Text = "Formulario de Reseñas";
            ((System.ComponentModel.ISupportInitialize)dgvReseñas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTipoLocal;
        private ComboBox cboTipoLocal;
        private ComboBox cboPuntuacion;
        private Label lblPuntuacion;
        private Button btnGuardarReseña;
        private DataGridView dgvReseñas;
        private Button btnAlta;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn TipoLocal;
        private DataGridViewTextBoxColumn Puntuacion;
        private Button btnRefrescar;
    }
}
