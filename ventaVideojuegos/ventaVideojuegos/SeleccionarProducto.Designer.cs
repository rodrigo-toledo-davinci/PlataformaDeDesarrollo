namespace ventaVideojuegos
{
    partial class SeleccionarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filtroNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnVaciarFiltros = new System.Windows.Forms.Button();
            this.boxConsolas = new System.Windows.Forms.ComboBox();
            this.boxCategorias = new System.Windows.Forms.ComboBox();
            this.btn_actual_page = new Guna.UI2.WinForms.Guna2Button();
            this.btn_FirstPage = new Guna.UI2.WinForms.Guna2Button();
            this.btn_prev_page = new Guna.UI2.WinForms.Guna2Button();
            this.btn_next_page = new Guna.UI2.WinForms.Guna2Button();
            this.btn_last_page = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conexion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModoJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.filtroNombre.Location = new System.Drawing.Point(97, 53);
            this.filtroNombre.Name = "filtroNombre";
            this.filtroNombre.PasswordChar = '\0';
            this.filtroNombre.PlaceholderText = "";
            this.filtroNombre.SelectedText = "";
            this.filtroNombre.Size = new System.Drawing.Size(84, 23);
            this.filtroNombre.TabIndex = 43;
            this.filtroNombre.TextChanged += new System.EventHandler(this.filtroNombre_TextChanged);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCon.Location = new System.Drawing.Point(392, 35);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(45, 13);
            this.lblCon.TabIndex = 42;
            this.lblCon.Text = "Consola";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCat.Location = new System.Drawing.Point(291, 35);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 41;
            this.lblCat.Text = "Categoria";
            // 
            // btnVaciarFiltros
            // 
            this.btnVaciarFiltros.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVaciarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarFiltros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVaciarFiltros.Location = new System.Drawing.Point(688, 54);
            this.btnVaciarFiltros.Name = "btnVaciarFiltros";
            this.btnVaciarFiltros.Size = new System.Drawing.Size(100, 23);
            this.btnVaciarFiltros.TabIndex = 40;
            this.btnVaciarFiltros.Text = "Reiniciar filtros";
            this.btnVaciarFiltros.UseVisualStyleBackColor = false;
            this.btnVaciarFiltros.Click += new System.EventHandler(this.btnVaciarFiltros_Click);
            // 
            // boxConsolas
            // 
            this.boxConsolas.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxConsolas.FormattingEnabled = true;
            this.boxConsolas.Location = new System.Drawing.Point(389, 53);
            this.boxConsolas.Name = "boxConsolas";
            this.boxConsolas.Size = new System.Drawing.Size(84, 23);
            this.boxConsolas.TabIndex = 39;
            this.boxConsolas.SelectedIndexChanged += new System.EventHandler(this.boxConsolas_SelectedIndexChanged);
            // 
            // boxCategorias
            // 
            this.boxCategorias.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCategorias.FormattingEnabled = true;
            this.boxCategorias.Location = new System.Drawing.Point(288, 53);
            this.boxCategorias.Name = "boxCategorias";
            this.boxCategorias.Size = new System.Drawing.Size(84, 23);
            this.boxCategorias.TabIndex = 38;
            this.boxCategorias.SelectedIndexChanged += new System.EventHandler(this.boxCategorias_SelectedIndexChanged);
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
            this.btn_actual_page.Location = new System.Drawing.Point(402, 329);
            this.btn_actual_page.Name = "btn_actual_page";
            this.btn_actual_page.Size = new System.Drawing.Size(39, 21);
            this.btn_actual_page.TabIndex = 37;
            this.btn_actual_page.Click += new System.EventHandler(this.btn_actual_page_Click);
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
            this.btn_FirstPage.Location = new System.Drawing.Point(279, 329);
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.Size = new System.Drawing.Size(43, 21);
            this.btn_FirstPage.TabIndex = 36;
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
            this.btn_prev_page.Location = new System.Drawing.Point(341, 329);
            this.btn_prev_page.Name = "btn_prev_page";
            this.btn_prev_page.Size = new System.Drawing.Size(39, 21);
            this.btn_prev_page.TabIndex = 35;
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
            this.btn_next_page.Location = new System.Drawing.Point(469, 330);
            this.btn_next_page.Name = "btn_next_page";
            this.btn_next_page.Size = new System.Drawing.Size(39, 21);
            this.btn_next_page.TabIndex = 34;
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
            this.btn_last_page.Location = new System.Drawing.Point(529, 330);
            this.btn_last_page.Name = "btn_last_page";
            this.btn_last_page.Size = new System.Drawing.Size(43, 21);
            this.btn_last_page.TabIndex = 33;
            this.btn_last_page.Text = ">>";
            this.btn_last_page.Click += new System.EventHandler(this.btn_last_page_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.Location = new System.Drawing.Point(688, 330);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 26);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Precio,
            this.Categoria,
            this.Consola,
            this.Conexion,
            this.ModoJuego,
            this.Imagen});
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(15, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridView1.Size = new System.Drawing.Size(773, 241);
            this.dataGridView1.TabIndex = 31;
            // 
            // Id
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            this.Id.DefaultCellStyle = dataGridViewCellStyle33;
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
            // SeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.filtroNombre);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.btnVaciarFiltros);
            this.Controls.Add(this.boxConsolas);
            this.Controls.Add(this.boxCategorias);
            this.Controls.Add(this.btn_actual_page);
            this.Controls.Add(this.btn_FirstPage);
            this.Controls.Add(this.btn_prev_page);
            this.Controls.Add(this.btn_next_page);
            this.Controls.Add(this.btn_last_page);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeleccionarProducto";
            this.Text = "SeleccionarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox filtroNombre;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnVaciarFiltros;
        private System.Windows.Forms.ComboBox boxConsolas;
        private System.Windows.Forms.ComboBox boxCategorias;
        private Guna.UI2.WinForms.Guna2Button btn_actual_page;
        private Guna.UI2.WinForms.Guna2Button btn_FirstPage;
        private Guna.UI2.WinForms.Guna2Button btn_prev_page;
        private Guna.UI2.WinForms.Guna2Button btn_next_page;
        private Guna.UI2.WinForms.Guna2Button btn_last_page;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModoJuego;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
    }
}