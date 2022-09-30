namespace CRUDcarreras
{
    partial class AltaCarrera
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
            this.lblNextCarrera = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAni0Cursado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantMateria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuatri = new System.Windows.Forms.TextBox();
            this.colIdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAñoCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNextCarrera
            // 
            this.lblNextCarrera.AutoSize = true;
            this.lblNextCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextCarrera.Location = new System.Drawing.Point(12, 18);
            this.lblNextCarrera.Name = "lblNextCarrera";
            this.lblNextCarrera.Size = new System.Drawing.Size(135, 25);
            this.lblNextCarrera.TabIndex = 0;
            this.lblNextCarrera.Text = "Nro Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Materia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(405, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(98, 136);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(405, 21);
            this.cboMateria.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(98, 99);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(405, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.AllowUserToAddRows = false;
            this.dgvCarreras.AllowUserToDeleteRows = false;
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdMateria,
            this.colMateria,
            this.colAñoCursado,
            this.colCuatrimestre,
            this.colAcciones});
            this.dgvCarreras.Location = new System.Drawing.Point(57, 216);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.ReadOnly = true;
            this.dgvCarreras.Size = new System.Drawing.Size(556, 150);
            this.dgvCarreras.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Año Cursado";
            // 
            // txtAni0Cursado
            // 
            this.txtAni0Cursado.Location = new System.Drawing.Point(98, 177);
            this.txtAni0Cursado.Name = "txtAni0Cursado";
            this.txtAni0Cursado.Size = new System.Drawing.Size(109, 20);
            this.txtAni0Cursado.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(428, 177);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(344, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(438, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad Materias";
            // 
            // txtCantMateria
            // 
            this.txtCantMateria.Location = new System.Drawing.Point(519, 380);
            this.txtCantMateria.Name = "txtCantMateria";
            this.txtCantMateria.Size = new System.Drawing.Size(86, 20);
            this.txtCantMateria.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cuatrimestre";
            // 
            // txtCuatri
            // 
            this.txtCuatri.Location = new System.Drawing.Point(293, 177);
            this.txtCuatri.Name = "txtCuatri";
            this.txtCuatri.Size = new System.Drawing.Size(109, 20);
            this.txtCuatri.TabIndex = 4;
            // 
            // colIdMateria
            // 
            this.colIdMateria.HeaderText = "id";
            this.colIdMateria.Name = "colIdMateria";
            this.colIdMateria.ReadOnly = true;
            this.colIdMateria.Visible = false;
            // 
            // colMateria
            // 
            this.colMateria.HeaderText = "Materia";
            this.colMateria.Name = "colMateria";
            this.colMateria.ReadOnly = true;
            this.colMateria.Width = 200;
            // 
            // colAñoCursado
            // 
            this.colAñoCursado.HeaderText = "Año De Cursado";
            this.colAñoCursado.Name = "colAñoCursado";
            this.colAñoCursado.ReadOnly = true;
            // 
            // colCuatrimestre
            // 
            this.colCuatrimestre.HeaderText = "Cuatrimestre";
            this.colCuatrimestre.Name = "colCuatrimestre";
            this.colCuatrimestre.ReadOnly = true;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Acciones";
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Text = "Eliminar";
            this.colAcciones.UseColumnTextForButtonValue = true;
            // 
            // AltaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.txtCuatri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCantMateria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAni0Cursado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCarreras);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNextCarrera);
            this.Name = "AltaCarrera";
            this.Text = "AltaCarrera";
            this.Load += new System.EventHandler(this.AltaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNextCarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAni0Cursado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantMateria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuatri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAñoCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
    }
}

