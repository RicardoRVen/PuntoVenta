namespace PuntoVenta
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.tbnNuevo = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usrNumTasa = new PuntoVenta.UsrNumeros();
            this.usrNumProd = new PuntoVenta.UsrNumeros();
            this.chkSecuenta = new System.Windows.Forms.CheckBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCodBar = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBusca = new System.Windows.Forms.TabPage();
            this.dtGridProd = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.usrCerrar1 = new PuntoVenta.UsrCerrar();
            this.label7 = new System.Windows.Forms.Label();
            this.usrPrecio = new PuntoVenta.UsrNumeros();
            this.groupBox1.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.tbnNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.tabProductos);
            this.groupBox1.Location = new System.Drawing.Point(67, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 381);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.tbnNuevo);
            this.tabProductos.Controls.Add(this.tbBusca);
            this.tabProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProductos.Location = new System.Drawing.Point(44, 19);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(840, 344);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.SelectedIndexChanged += new System.EventHandler(this.tabProductos_SelectedIndexChanged);
            // 
            // tbnNuevo
            // 
            this.tbnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbnNuevo.Controls.Add(this.usrPrecio);
            this.tbnNuevo.Controls.Add(this.label7);
            this.tbnNuevo.Controls.Add(this.pictureBox1);
            this.tbnNuevo.Controls.Add(this.usrNumTasa);
            this.tbnNuevo.Controls.Add(this.usrNumProd);
            this.tbnNuevo.Controls.Add(this.chkSecuenta);
            this.tbnNuevo.Controls.Add(this.cbxDepartamento);
            this.tbnNuevo.Controls.Add(this.txtClave);
            this.tbnNuevo.Controls.Add(this.txtCodBar);
            this.tbnNuevo.Controls.Add(this.txtProducto);
            this.tbnNuevo.Controls.Add(this.label3);
            this.tbnNuevo.Controls.Add(this.label6);
            this.tbnNuevo.Controls.Add(this.label5);
            this.tbnNuevo.Controls.Add(this.label4);
            this.tbnNuevo.Controls.Add(this.label2);
            this.tbnNuevo.Controls.Add(this.label1);
            this.tbnNuevo.Location = new System.Drawing.Point(4, 27);
            this.tbnNuevo.Name = "tbnNuevo";
            this.tbnNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tbnNuevo.Size = new System.Drawing.Size(832, 313);
            this.tbnNuevo.TabIndex = 0;
            this.tbnNuevo.Text = "Nuevo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 200);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // usrNumTasa
            // 
            this.usrNumTasa.bColor = false;
            this.usrNumTasa.bDecimal = true;
            this.usrNumTasa.Location = new System.Drawing.Point(468, 268);
            this.usrNumTasa.Margin = new System.Windows.Forms.Padding(4);
            this.usrNumTasa.Name = "usrNumTasa";
            this.usrNumTasa.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.usrNumTasa.Size = new System.Drawing.Size(144, 40);
            this.usrNumTasa.TabIndex = 7;
            // 
            // usrNumProd
            // 
            this.usrNumProd.bColor = false;
            this.usrNumProd.bDecimal = false;
            this.usrNumProd.Location = new System.Drawing.Point(468, 41);
            this.usrNumProd.Margin = new System.Windows.Forms.Padding(4);
            this.usrNumProd.Name = "usrNumProd";
            this.usrNumProd.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.usrNumProd.Size = new System.Drawing.Size(130, 31);
            this.usrNumProd.TabIndex = 1;
            this.usrNumProd.Validated += new System.EventHandler(this.usrNumProd_Validated);
            // 
            // chkSecuenta
            // 
            this.chkSecuenta.AutoSize = true;
            this.chkSecuenta.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSecuenta.Location = new System.Drawing.Point(693, 132);
            this.chkSecuenta.Name = "chkSecuenta";
            this.chkSecuenta.Size = new System.Drawing.Size(98, 20);
            this.chkSecuenta.TabIndex = 4;
            this.chkSecuenta.Text = "Se_Cuenta";
            this.chkSecuenta.UseVisualStyleBackColor = true;
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(471, 91);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(277, 26);
            this.cbxDepartamento.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(471, 235);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(277, 26);
            this.txtClave.TabIndex = 6;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new System.Drawing.Point(471, 203);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new System.Drawing.Size(277, 26);
            this.txtCodBar.TabIndex = 5;
            this.txtCodBar.TextChanged += new System.EventHandler(this.txtCodBar_TextChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(471, 129);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(201, 26);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departamentos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Impuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo de barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folio";
            // 
            // tbBusca
            // 
            this.tbBusca.Controls.Add(this.dtGridProd);
            this.tbBusca.Location = new System.Drawing.Point(4, 27);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tbBusca.Size = new System.Drawing.Size(832, 313);
            this.tbBusca.TabIndex = 1;
            this.tbBusca.Text = "Busqueda";
            this.tbBusca.UseVisualStyleBackColor = true;
            // 
            // dtGridProd
            // 
            this.dtGridProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridProd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtGridProd.Location = new System.Drawing.Point(18, 15);
            this.dtGridProd.Name = "dtGridProd";
            this.dtGridProd.ReadOnly = true;
            this.dtGridProd.Size = new System.Drawing.Size(787, 281);
            this.dtGridProd.TabIndex = 0;
            this.dtGridProd.DoubleClick += new System.EventHandler(this.dtGridProd_DoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(488, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 25);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "   &Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(757, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 27);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "  &Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(275, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 25);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.btnDeshacer);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.usrCerrar1);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(67, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(917, 55);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.Image")));
            this.btnDeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshacer.Location = new System.Drawing.Point(663, 13);
            this.btnDeshacer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(87, 27);
            this.btnDeshacer.TabIndex = 10;
            this.btnDeshacer.Text = "  &Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(382, 13);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 26);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "  &Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // usrCerrar1
            // 
            this.usrCerrar1.bPregunta = false;
            this.usrCerrar1.Location = new System.Drawing.Point(43, 13);
            this.usrCerrar1.Name = "usrCerrar1";
            this.usrCerrar1.Size = new System.Drawing.Size(93, 31);
            this.usrCerrar1.sTexto = "Cerrar";
            this.usrCerrar1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio";
            // 
            // usrPrecio
            // 
            this.usrPrecio.bColor = false;
            this.usrPrecio.bDecimal = true;
            this.usrPrecio.Location = new System.Drawing.Point(468, 162);
            this.usrPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usrPrecio.Name = "usrPrecio";
            this.usrPrecio.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.usrPrecio.Size = new System.Drawing.Size(144, 30);
            this.usrPrecio.TabIndex = 16;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.tbnNuevo.ResumeLayout(false);
            this.tbnNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbBusca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage tbnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkSecuenta;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbBusca;
        private System.Windows.Forms.DataGridView dtGridProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private UsrCerrar usrCerrar1;
        private UsrNumeros usrNumProd;
        private UsrNumeros usrNumTasa;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCodBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnModificar;
        private UsrNumeros usrPrecio;
        private System.Windows.Forms.Label label7;
    }
}