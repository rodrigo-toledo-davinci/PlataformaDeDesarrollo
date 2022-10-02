namespace ventaVideojuegos.UsersControls
{
    partial class UC_Admin
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conexion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModoJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevaCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnEditarCat = new System.Windows.Forms.Button();
            this.btnNuevaCon = new System.Windows.Forms.Button();
            this.btnEliminarCon = new System.Windows.Forms.Button();
            this.btnEditarCon = new System.Windows.Forms.Button();
            this.dataGridViewCon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabAdmin = new Guna.UI2.WinForms.Guna2TabControl();
            this.TabProductos = new System.Windows.Forms.TabPage();
            this.filtroNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnVaciarFiltros = new System.Windows.Forms.Button();
            this.btn_actual_page = new Guna.UI2.WinForms.Guna2Button();
            this.btn_FirstPage = new Guna.UI2.WinForms.Guna2Button();
            this.btn_prev_page = new Guna.UI2.WinForms.Guna2Button();
            this.btn_next_page = new Guna.UI2.WinForms.Guna2Button();
            this.btn_last_page = new Guna.UI2.WinForms.Guna2Button();
            this.label_paginacion = new System.Windows.Forms.Label();
            this.paginacionTxt = new System.Windows.Forms.Label();
            this.boxPaginacion = new System.Windows.Forms.ComboBox();
            this.boxConsolas = new System.Windows.Forms.ComboBox();
            this.boxCategorias = new System.Windows.Forms.ComboBox();
            this.TabCategorias = new System.Windows.Forms.TabPage();
            this.TabConsolas = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCon)).BeginInit();
            this.TabAdmin.SuspendLayout();
            this.TabProductos.SuspendLayout();
            this.TabCategorias.SuspendLayout();
            this.TabConsolas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Precio,
            this.Stock,
            this.Categoria,
            this.Consola,
            this.Conexion,
            this.ModoJuego,
            this.Imagen});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(6, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(678, 205);
            this.dataGridView1.TabIndex = 5;
            // 
            // Id
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Id.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Consola
            // 
            this.Consola.HeaderText = "Consola";
            this.Consola.Name = "Consola";
            // 
            // Conexion
            // 
            this.Conexion.HeaderText = "Conexion";
            this.Conexion.Name = "Conexion";
            // 
            // ModoJuego
            // 
            this.ModoJuego.HeaderText = "ModoJuego";
            this.ModoJuego.Name = "ModoJuego";
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Location = new System.Drawing.Point(373, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 26);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(578, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 26);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(475, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 26);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCat.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCat.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewCat.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCat.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCat.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCat.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewCat.Size = new System.Drawing.Size(173, 163);
            this.dataGridViewCat.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnNuevaCat
            // 
            this.btnNuevaCat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNuevaCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevaCat.Location = new System.Drawing.Point(222, 29);
            this.btnNuevaCat.Name = "btnNuevaCat";
            this.btnNuevaCat.Size = new System.Drawing.Size(105, 26);
            this.btnNuevaCat.TabIndex = 10;
            this.btnNuevaCat.Text = "Nueva Categoria";
            this.btnNuevaCat.UseVisualStyleBackColor = false;
            this.btnNuevaCat.Click += new System.EventHandler(this.btnNuevaCat_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarCat.Location = new System.Drawing.Point(222, 90);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(105, 23);
            this.btnEliminarCat.TabIndex = 12;
            this.btnEliminarCat.Text = "Eliminar Categoria";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // btnEditarCat
            // 
            this.btnEditarCat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarCat.Location = new System.Drawing.Point(222, 61);
            this.btnEditarCat.Name = "btnEditarCat";
            this.btnEditarCat.Size = new System.Drawing.Size(105, 23);
            this.btnEditarCat.TabIndex = 11;
            this.btnEditarCat.Text = "Editar Categoria";
            this.btnEditarCat.UseVisualStyleBackColor = false;
            this.btnEditarCat.Click += new System.EventHandler(this.btnEditarCat_Click);
            // 
            // btnNuevaCon
            // 
            this.btnNuevaCon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnNuevaCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaCon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevaCon.Location = new System.Drawing.Point(221, 29);
            this.btnNuevaCon.Name = "btnNuevaCon";
            this.btnNuevaCon.Size = new System.Drawing.Size(105, 26);
            this.btnNuevaCon.TabIndex = 14;
            this.btnNuevaCon.Text = "Nueva Consola";
            this.btnNuevaCon.UseVisualStyleBackColor = false;
            this.btnNuevaCon.Click += new System.EventHandler(this.btnNuevaCon_Click);
            // 
            // btnEliminarCon
            // 
            this.btnEliminarCon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarCon.Location = new System.Drawing.Point(221, 90);
            this.btnEliminarCon.Name = "btnEliminarCon";
            this.btnEliminarCon.Size = new System.Drawing.Size(105, 23);
            this.btnEliminarCon.TabIndex = 16;
            this.btnEliminarCon.Text = "Eliminar Consola";
            this.btnEliminarCon.UseVisualStyleBackColor = false;
            this.btnEliminarCon.Click += new System.EventHandler(this.btnEliminarCon_Click);
            // 
            // btnEditarCon
            // 
            this.btnEditarCon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditarCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarCon.Location = new System.Drawing.Point(221, 61);
            this.btnEditarCon.Name = "btnEditarCon";
            this.btnEditarCon.Size = new System.Drawing.Size(105, 23);
            this.btnEditarCon.TabIndex = 15;
            this.btnEditarCon.Text = "Editar Consola";
            this.btnEditarCon.UseVisualStyleBackColor = false;
            this.btnEditarCon.Click += new System.EventHandler(this.btnEditarCon_Click);
            // 
            // dataGridViewCon
            // 
            this.dataGridViewCon.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewCon.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCon.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewCon.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCon.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCon.Name = "dataGridViewCon";
            this.dataGridViewCon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCon.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCon.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewCon.Size = new System.Drawing.Size(174, 171);
            this.dataGridViewCon.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // TabAdmin
            // 
            this.TabAdmin.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabAdmin.Controls.Add(this.TabProductos);
            this.TabAdmin.Controls.Add(this.TabCategorias);
            this.TabAdmin.Controls.Add(this.TabConsolas);
            this.TabAdmin.ItemSize = new System.Drawing.Size(180, 40);
            this.TabAdmin.Location = new System.Drawing.Point(15, 14);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.SelectedIndex = 0;
            this.TabAdmin.Size = new System.Drawing.Size(884, 384);
            this.TabAdmin.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabAdmin.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabAdmin.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabAdmin.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabAdmin.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabAdmin.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabAdmin.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabAdmin.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabAdmin.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabAdmin.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabAdmin.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabAdmin.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabAdmin.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabAdmin.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabAdmin.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabAdmin.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TabAdmin.TabIndex = 17;
            this.TabAdmin.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // TabProductos
            // 
            this.TabProductos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TabProductos.Controls.Add(this.filtroNombre);
            this.TabProductos.Controls.Add(this.lblCon);
            this.TabProductos.Controls.Add(this.lblCat);
            this.TabProductos.Controls.Add(this.btnVaciarFiltros);
            this.TabProductos.Controls.Add(this.btn_actual_page);
            this.TabProductos.Controls.Add(this.btn_FirstPage);
            this.TabProductos.Controls.Add(this.btn_prev_page);
            this.TabProductos.Controls.Add(this.btn_next_page);
            this.TabProductos.Controls.Add(this.btn_last_page);
            this.TabProductos.Controls.Add(this.label_paginacion);
            this.TabProductos.Controls.Add(this.paginacionTxt);
            this.TabProductos.Controls.Add(this.boxPaginacion);
            this.TabProductos.Controls.Add(this.boxConsolas);
            this.TabProductos.Controls.Add(this.boxCategorias);
            this.TabProductos.Controls.Add(this.dataGridView1);
            this.TabProductos.Controls.Add(this.btnNuevo);
            this.TabProductos.Controls.Add(this.btnEditar);
            this.TabProductos.Controls.Add(this.btnEliminar);
            this.TabProductos.Location = new System.Drawing.Point(184, 4);
            this.TabProductos.Name = "TabProductos";
            this.TabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.TabProductos.Size = new System.Drawing.Size(696, 376);
            this.TabProductos.TabIndex = 0;
            this.TabProductos.Text = "Productos";
            // 
            // filtroNombre
            // 
            this.filtroNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filtroNombre.DefaultText = "";
            this.filtroNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filtroNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filtroNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filtroNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filtroNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filtroNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filtroNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filtroNombre.Location = new System.Drawing.Point(83, 68);
            this.filtroNombre.Name = "filtroNombre";
            this.filtroNombre.PasswordChar = '\0';
            this.filtroNombre.PlaceholderText = "";
            this.filtroNombre.SelectedText = "";
            this.filtroNombre.Size = new System.Drawing.Size(84, 23);
            this.filtroNombre.TabIndex = 22;
            this.filtroNombre.TextChanged += new System.EventHandler(this.filtroNombre_TextChanged);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCon.Location = new System.Drawing.Point(481, 51);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(45, 13);
            this.lblCon.TabIndex = 21;
            this.lblCon.Text = "Consola";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCat.Location = new System.Drawing.Point(380, 51);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 20;
            this.lblCat.Text = "Categoria";
            // 
            // btnVaciarFiltros
            // 
            this.btnVaciarFiltros.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVaciarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarFiltros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVaciarFiltros.Location = new System.Drawing.Point(578, 68);
            this.btnVaciarFiltros.Name = "btnVaciarFiltros";
            this.btnVaciarFiltros.Size = new System.Drawing.Size(100, 23);
            this.btnVaciarFiltros.TabIndex = 19;
            this.btnVaciarFiltros.Text = "reiniciar filtros";
            this.btnVaciarFiltros.UseVisualStyleBackColor = false;
            this.btnVaciarFiltros.Click += new System.EventHandler(this.btnVaciarFiltros_Click);
            // 
            // btn_actual_page
            // 
            this.btn_actual_page.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_actual_page.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_actual_page.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_actual_page.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_actual_page.FillColor = System.Drawing.Color.Silver;
            this.btn_actual_page.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_actual_page.ForeColor = System.Drawing.Color.White;
            this.btn_actual_page.Location = new System.Drawing.Point(322, 320);
            this.btn_actual_page.Name = "btn_actual_page";
            this.btn_actual_page.Size = new System.Drawing.Size(39, 21);
            this.btn_actual_page.TabIndex = 18;
            // 
            // btn_FirstPage
            // 
            this.btn_FirstPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_FirstPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_FirstPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_FirstPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_FirstPage.FillColor = System.Drawing.Color.Silver;
            this.btn_FirstPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_FirstPage.ForeColor = System.Drawing.Color.Black;
            this.btn_FirstPage.Location = new System.Drawing.Point(199, 320);
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.Size = new System.Drawing.Size(43, 21);
            this.btn_FirstPage.TabIndex = 17;
            this.btn_FirstPage.Text = "<<";
            this.btn_FirstPage.Click += new System.EventHandler(this.btn_FirstPage_Click);
            // 
            // btn_prev_page
            // 
            this.btn_prev_page.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_prev_page.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_prev_page.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_prev_page.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_prev_page.FillColor = System.Drawing.Color.Silver;
            this.btn_prev_page.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_prev_page.ForeColor = System.Drawing.Color.Black;
            this.btn_prev_page.Location = new System.Drawing.Point(261, 320);
            this.btn_prev_page.Name = "btn_prev_page";
            this.btn_prev_page.Size = new System.Drawing.Size(39, 21);
            this.btn_prev_page.TabIndex = 16;
            this.btn_prev_page.Text = " <";
            this.btn_prev_page.Click += new System.EventHandler(this.btn_prev_page_Click);
            // 
            // btn_next_page
            // 
            this.btn_next_page.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_next_page.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_next_page.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_next_page.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_next_page.FillColor = System.Drawing.Color.Silver;
            this.btn_next_page.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_next_page.ForeColor = System.Drawing.Color.Black;
            this.btn_next_page.Location = new System.Drawing.Point(389, 321);
            this.btn_next_page.Name = "btn_next_page";
            this.btn_next_page.Size = new System.Drawing.Size(39, 21);
            this.btn_next_page.TabIndex = 15;
            this.btn_next_page.Text = ">";
            this.btn_next_page.Click += new System.EventHandler(this.btn_next_page_Click);
            // 
            // btn_last_page
            // 
            this.btn_last_page.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_last_page.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_last_page.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_last_page.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_last_page.FillColor = System.Drawing.Color.Silver;
            this.btn_last_page.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_last_page.ForeColor = System.Drawing.Color.Black;
            this.btn_last_page.Location = new System.Drawing.Point(449, 321);
            this.btn_last_page.Name = "btn_last_page";
            this.btn_last_page.Size = new System.Drawing.Size(43, 21);
            this.btn_last_page.TabIndex = 14;
            this.btn_last_page.Text = ">>";
            this.btn_last_page.Click += new System.EventHandler(this.btn_last_page_Click);
            // 
            // label_paginacion
            // 
            this.label_paginacion.AutoSize = true;
            this.label_paginacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_paginacion.Location = new System.Drawing.Point(3, 321);
            this.label_paginacion.Name = "label_paginacion";
            this.label_paginacion.Size = new System.Drawing.Size(117, 13);
            this.label_paginacion.TabIndex = 13;
            this.label_paginacion.Text = "Mostrando 1 - 10 de 40";
            // 
            // paginacionTxt
            // 
            this.paginacionTxt.AutoSize = true;
            this.paginacionTxt.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paginacionTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paginacionTxt.Location = new System.Drawing.Point(3, 350);
            this.paginacionTxt.Name = "paginacionTxt";
            this.paginacionTxt.Size = new System.Drawing.Size(64, 15);
            this.paginacionTxt.TabIndex = 12;
            this.paginacionTxt.Text = "Paginación";
            // 
            // boxPaginacion
            // 
            this.boxPaginacion.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPaginacion.FormattingEnabled = true;
            this.boxPaginacion.Location = new System.Drawing.Point(70, 347);
            this.boxPaginacion.Name = "boxPaginacion";
            this.boxPaginacion.Size = new System.Drawing.Size(37, 23);
            this.boxPaginacion.TabIndex = 11;
            this.boxPaginacion.SelectedIndexChanged += new System.EventHandler(this.boxPaginacion_SelectedIndexChanged);
            // 
            // boxConsolas
            // 
            this.boxConsolas.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxConsolas.FormattingEnabled = true;
            this.boxConsolas.Location = new System.Drawing.Point(478, 69);
            this.boxConsolas.Name = "boxConsolas";
            this.boxConsolas.Size = new System.Drawing.Size(84, 23);
            this.boxConsolas.TabIndex = 10;
            this.boxConsolas.SelectedIndexChanged += new System.EventHandler(this.boxConsolas_SelectedIndexChanged);
            // 
            // boxCategorias
            // 
            this.boxCategorias.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCategorias.FormattingEnabled = true;
            this.boxCategorias.Location = new System.Drawing.Point(377, 69);
            this.boxCategorias.Name = "boxCategorias";
            this.boxCategorias.Size = new System.Drawing.Size(84, 23);
            this.boxCategorias.TabIndex = 9;
            this.boxCategorias.SelectedIndexChanged += new System.EventHandler(this.boxCategorias_SelectedIndexChanged);
            // 
            // TabCategorias
            // 
            this.TabCategorias.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TabCategorias.Controls.Add(this.dataGridViewCat);
            this.TabCategorias.Controls.Add(this.btnNuevaCat);
            this.TabCategorias.Controls.Add(this.btnEditarCat);
            this.TabCategorias.Controls.Add(this.btnEliminarCat);
            this.TabCategorias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TabCategorias.Location = new System.Drawing.Point(184, 4);
            this.TabCategorias.Name = "TabCategorias";
            this.TabCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.TabCategorias.Size = new System.Drawing.Size(696, 376);
            this.TabCategorias.TabIndex = 1;
            this.TabCategorias.Text = "Categorias";
            // 
            // TabConsolas
            // 
            this.TabConsolas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TabConsolas.Controls.Add(this.dataGridViewCon);
            this.TabConsolas.Controls.Add(this.btnNuevaCon);
            this.TabConsolas.Controls.Add(this.btnEliminarCon);
            this.TabConsolas.Controls.Add(this.btnEditarCon);
            this.TabConsolas.Location = new System.Drawing.Point(184, 4);
            this.TabConsolas.Name = "TabConsolas";
            this.TabConsolas.Padding = new System.Windows.Forms.Padding(3);
            this.TabConsolas.Size = new System.Drawing.Size(696, 376);
            this.TabConsolas.TabIndex = 2;
            this.TabConsolas.Text = "Consolas";
            // 
            // UC_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabAdmin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UC_Admin";
            this.Size = new System.Drawing.Size(911, 411);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCon)).EndInit();
            this.TabAdmin.ResumeLayout(false);
            this.TabProductos.ResumeLayout(false);
            this.TabProductos.PerformLayout();
            this.TabCategorias.ResumeLayout(false);
            this.TabConsolas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dataGridViewCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnNuevaCat;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnEditarCat;
        private System.Windows.Forms.Button btnNuevaCon;
        private System.Windows.Forms.Button btnEliminarCon;
        private System.Windows.Forms.Button btnEditarCon;
        private System.Windows.Forms.DataGridView dataGridViewCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModoJuego;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private Guna.UI2.WinForms.Guna2TabControl TabAdmin;
        private System.Windows.Forms.TabPage TabProductos;
        private System.Windows.Forms.TabPage TabCategorias;
        private System.Windows.Forms.TabPage TabConsolas;
        private System.Windows.Forms.ComboBox boxConsolas;
        private System.Windows.Forms.ComboBox boxCategorias;
        private System.Windows.Forms.Label paginacionTxt;
        private System.Windows.Forms.ComboBox boxPaginacion;
        private System.Windows.Forms.Label label_paginacion;
        private Guna.UI2.WinForms.Guna2Button btn_FirstPage;
        private Guna.UI2.WinForms.Guna2Button btn_prev_page;
        private Guna.UI2.WinForms.Guna2Button btn_next_page;
        private Guna.UI2.WinForms.Guna2Button btn_last_page;
        private Guna.UI2.WinForms.Guna2Button btn_actual_page;
        private System.Windows.Forms.Button btnVaciarFiltros;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblCat;
        private Guna.UI2.WinForms.Guna2TextBox filtroNombre;
    }
}
