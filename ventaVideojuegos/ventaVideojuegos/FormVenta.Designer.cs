namespace ventaVideojuegos
{
    partial class FormVenta
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnFinalCompra = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.errCantidad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errEmpleado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.boxClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(4, 71);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(141, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Ingrese la cantidad deseada";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(192, 64);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(43, 20);
            this.numCantidad.TabIndex = 1;
            // 
            // btnFinalCompra
            // 
            this.btnFinalCompra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalCompra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinalCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinalCompra.FillColor = System.Drawing.Color.White;
            this.btnFinalCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinalCompra.ForeColor = System.Drawing.Color.Black;
            this.btnFinalCompra.Location = new System.Drawing.Point(78, 249);
            this.btnFinalCompra.Name = "btnFinalCompra";
            this.btnFinalCompra.Size = new System.Drawing.Size(141, 30);
            this.btnFinalCompra.TabIndex = 9;
            this.btnFinalCompra.Text = "Finalizar Compra";
            this.btnFinalCompra.Click += new System.EventHandler(this.btnFinalCompra_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpleado.DefaultText = "";
            this.txtEmpleado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmpleado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmpleado.Location = new System.Drawing.Point(160, 175);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.PasswordChar = '\0';
            this.txtEmpleado.PlaceholderText = "";
            this.txtEmpleado.SelectedText = "";
            this.txtEmpleado.Size = new System.Drawing.Size(119, 27);
            this.txtEmpleado.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese nombre del empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID VENTA";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.Enabled = false;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(160, 18);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(119, 27);
            this.txtID.TabIndex = 11;
            // 
            // errCantidad
            // 
            this.errCantidad.BackColor = System.Drawing.Color.Transparent;
            this.errCantidad.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errCantidad.ForeColor = System.Drawing.Color.Red;
            this.errCantidad.Location = new System.Drawing.Point(7, 87);
            this.errCantidad.Name = "errCantidad";
            this.errCantidad.Size = new System.Drawing.Size(182, 17);
            this.errCantidad.TabIndex = 34;
            this.errCantidad.Text = "Debe ingresar la cantidad deseada";
            // 
            // errEmpleado
            // 
            this.errEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.errEmpleado.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errEmpleado.ForeColor = System.Drawing.Color.Red;
            this.errEmpleado.Location = new System.Drawing.Point(7, 202);
            this.errEmpleado.Name = "errEmpleado";
            this.errEmpleado.Size = new System.Drawing.Size(209, 17);
            this.errEmpleado.TabIndex = 36;
            this.errEmpleado.Text = "Debe ingresar el nombre del empleado";
            // 
            // boxClientes
            // 
            this.boxClientes.FormattingEnabled = true;
            this.boxClientes.Location = new System.Drawing.Point(160, 125);
            this.boxClientes.Name = "boxClientes";
            this.boxClientes.Size = new System.Drawing.Size(121, 21);
            this.boxClientes.TabIndex = 37;
            this.boxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 303);
            this.Controls.Add(this.boxClientes);
            this.Controls.Add(this.errEmpleado);
            this.Controls.Add(this.errCantidad);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFinalCompra);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private Guna.UI2.WinForms.Guna2Button btnFinalCompra;
        private Guna.UI2.WinForms.Guna2TextBox txtEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2HtmlLabel errCantidad;
        private Guna.UI2.WinForms.Guna2HtmlLabel errEmpleado;
        private System.Windows.Forms.ComboBox boxClientes;
    }
}