namespace SwBiblioteca
{
    partial class FormLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            lblTitulo2 = new Label();
            btnBuscar = new Button();
            txtBuscarISBN = new TextBox();
            pnlDatos = new Panel();
            txtExistencias = new TextBox();
            txtAnio = new TextBox();
            txtCategoria = new TextBox();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAnio = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblTitulo3 = new Label();
            lblISBN = new Label();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            pnlBotones = new Panel();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1353, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(392, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(243, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(lblTitulo2);
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscarISBN);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1353, 54);
            pnlBusqueda.TabIndex = 1;
            pnlBusqueda.Paint += pnlBusqueda_Paint;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo2.Location = new Point(311, 20);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(35, 15);
            lblTitulo2.TabIndex = 3;
            lblTitulo2.Text = "ISBN";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(712, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarISBN
            // 
            txtBuscarISBN.Location = new Point(426, 17);
            txtBuscarISBN.Name = "txtBuscarISBN";
            txtBuscarISBN.Size = new Size(184, 23);
            txtBuscarISBN.TabIndex = 1;
            txtBuscarISBN.Text = "\r\n";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAnio);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAnio);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTitulo3);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 114);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1353, 227);
            pnlDatos.TabIndex = 2;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(585, 192);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(202, 23);
            txtExistencias.TabIndex = 13;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(585, 158);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(202, 23);
            txtAnio.TabIndex = 12;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(585, 126);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(202, 23);
            txtCategoria.TabIndex = 11;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(585, 97);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(202, 23);
            cmbEditorial.TabIndex = 10;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(585, 65);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(202, 23);
            cmbAutor.TabIndex = 9;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(585, 37);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(202, 23);
            txtTitulo.TabIndex = 8;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(585, 8);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(202, 23);
            txtISBN.TabIndex = 7;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(426, 195);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(64, 15);
            lblExistencias.TabIndex = 6;
            lblExistencias.Text = "Existencias";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAnio.Location = new Point(429, 161);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(29, 15);
            lblAnio.TabIndex = 5;
            lblAnio.Text = "Año";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(426, 129);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(426, 102);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(52, 15);
            lblEditorial.TabIndex = 3;
            lblEditorial.Text = "Editorial";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(426, 73);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(38, 15);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "Autor";
            // 
            // lblTitulo3
            // 
            lblTitulo3.AutoSize = true;
            lblTitulo3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo3.Location = new Point(426, 45);
            lblTitulo3.Name = "lblTitulo3";
            lblTitulo3.Size = new Size(38, 15);
            lblTitulo3.TabIndex = 1;
            lblTitulo3.Text = "Titulo";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(426, 16);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(32, 15);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "ISBN";
            lblISBN.Click += txtISBN_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 20;
            btnEditar.Location = new Point(249, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Ethernet;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 20;
            btnEliminar.Location = new Point(358, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(79, 36);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 20;
            btnCancelar.Location = new Point(468, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Location = new Point(311, 365);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(577, 73);
            pnlBotones.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Gift;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 20;
            btnNuevo.Location = new Point(22, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 36);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 20;
            btnGuardar.Location = new Point(134, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(226, 453);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(723, 110);
            dgvLibros.TabIndex = 6;
            dgvLibros.CellDoubleClick += CargarLibroSeleccionado;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 749);
            Controls.Add(dgvLibros);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FormLibros";
            Text = "FormLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private TextBox txtBuscarISBN;
        private Button btnBuscar;
        private Label lblTitulo2;
        private Panel pnlDatos;
        private Label lblISBN;
        private Label lblAutor;
        private Label lblTitulo3;
        private Label lblExistencias;
        private Label lblAnio;
        private Label lblCategoria;
        private Label lblEditorial;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private Panel pnlBotones;
        private DataGridView dgvLibros;
        private TextBox txtISBN;
        private TextBox txtTitulo;
        private ComboBox cmbAutor;
        private ComboBox cmbEditorial;
        private TextBox txtCategoria;
        private TextBox txtExistencias;
        private TextBox txtAnio;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}