namespace PuntoVenta
{
    partial class frmCajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCajas));
            this.dtgvCajas = new System.Windows.Forms.DataGridView();
            this.usrCerrar1 = new PuntoVenta.UsrCerrar();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usrNumCajas = new PuntoVenta.UsrNumeros();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tbBusca = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHabilitada = new System.Windows.Forms.CheckBox();
            this.txtMaccaddres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.tbNuevo = new System.Windows.Forms.TabPage();
            this.tabCajas = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tbBusca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            this.tabCajas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvCajas
            // 
            this.dtgvCajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCajas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvCajas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvCajas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvCajas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCajas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgvCajas.Location = new System.Drawing.Point(0, 3);
            this.dtgvCajas.Name = "dtgvCajas";
            this.dtgvCajas.ReadOnly = true;
            this.dtgvCajas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvCajas.Size = new System.Drawing.Size(793, 441);
            this.dtgvCajas.TabIndex = 0;
            this.dtgvCajas.DoubleClick += new System.EventHandler(this.dtgvCajas_DoubleClick);
            // 
            // usrCerrar1
            // 
            this.usrCerrar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrCerrar1.AutoSize = true;
            this.usrCerrar1.bPregunta = false;
            this.usrCerrar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.usrCerrar1.Location = new System.Drawing.Point(6, 17);
            this.usrCerrar1.Name = "usrCerrar1";
            this.usrCerrar1.Size = new System.Drawing.Size(112, 35);
            this.usrCerrar1.sTexto = "Cerrar";
            this.usrCerrar1.TabIndex = 7;
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.Image")));
            this.btnDeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshacer.Location = new System.Drawing.Point(475, 22);
            this.btnDeshacer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(103, 30);
            this.btnDeshacer.TabIndex = 12;
            this.btnDeshacer.Text = "  &Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(138, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 30);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "    &Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(338, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "   &Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 209);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // usrNumCajas
            // 
            this.usrNumCajas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrNumCajas.bColor = false;
            this.usrNumCajas.bDecimal = false;
            this.usrNumCajas.Cursor = System.Windows.Forms.Cursors.Default;
            this.usrNumCajas.Location = new System.Drawing.Point(430, 116);
            this.usrNumCajas.Margin = new System.Windows.Forms.Padding(5);
            this.usrNumCajas.Name = "usrNumCajas";
            this.usrNumCajas.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.usrNumCajas.Size = new System.Drawing.Size(143, 39);
            this.usrNumCajas.TabIndex = 12;
            this.usrNumCajas.Validated += new System.EventHandler(this.usrNumCajas_Validated);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(333, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Folio";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.usrCerrar1);
            this.groupBox2.Controls.Add(this.btnDeshacer);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 64);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(235, 22);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 30);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "  &Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(585, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 29);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "   &Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNombre.Location = new System.Drawing.Point(434, 169);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 25);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // tbBusca
            // 
            this.tbBusca.Controls.Add(this.dtgvCajas);
            this.tbBusca.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbBusca.Location = new System.Drawing.Point(4, 27);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tbBusca.Size = new System.Drawing.Size(799, 435);
            this.tbBusca.TabIndex = 1;
            this.tbBusca.Text = "Busqueda";
            this.tbBusca.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.chkHabilitada);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.usrNumCajas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaccaddres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblFamilia);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 307);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cajas";
            // 
            // chkHabilitada
            // 
            this.chkHabilitada.AutoSize = true;
            this.chkHabilitada.Checked = true;
            this.chkHabilitada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitada.Location = new System.Drawing.Point(471, 275);
            this.chkHabilitada.Name = "chkHabilitada";
            this.chkHabilitada.Size = new System.Drawing.Size(90, 21);
            this.chkHabilitada.TabIndex = 14;
            this.chkHabilitada.Text = "Habilitada";
            this.chkHabilitada.UseVisualStyleBackColor = true;
            // 
            // txtMaccaddres
            // 
            this.txtMaccaddres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaccaddres.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaccaddres.Location = new System.Drawing.Point(434, 227);
            this.txtMaccaddres.Name = "txtMaccaddres";
            this.txtMaccaddres.Size = new System.Drawing.Size(241, 25);
            this.txtMaccaddres.TabIndex = 10;
            this.txtMaccaddres.TextChanged += new System.EventHandler(this.txtMaccaddres_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(320, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Macaddress";
            // 
            // lblFamilia
            // 
            this.lblFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFamilia.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFamilia.Location = new System.Drawing.Point(320, 171);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(64, 18);
            this.lblFamilia.TabIndex = 9;
            this.lblFamilia.Text = "Nombre";
            // 
            // tbNuevo
            // 
            this.tbNuevo.BackColor = System.Drawing.Color.White;
            this.tbNuevo.Controls.Add(this.groupBox1);
            this.tbNuevo.Controls.Add(this.groupBox2);
            this.tbNuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbNuevo.Location = new System.Drawing.Point(4, 27);
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tbNuevo.Size = new System.Drawing.Size(807, 440);
            this.tbNuevo.TabIndex = 0;
            this.tbNuevo.Text = "Nuevo";
            // 
            // tabCajas
            // 
            this.tabCajas.Controls.Add(this.tbNuevo);
            this.tabCajas.Controls.Add(this.tbBusca);
            this.tabCajas.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabCajas.Font = new System.Drawing.Font("Arial", 12F);
            this.tabCajas.Location = new System.Drawing.Point(-2, 1);
            this.tabCajas.Name = "tabCajas";
            this.tabCajas.SelectedIndex = 0;
            this.tabCajas.Size = new System.Drawing.Size(815, 471);
            this.tabCajas.TabIndex = 6;
            this.tabCajas.SelectedIndexChanged += new System.EventHandler(this.tabCajas_SelectedIndexChanged);
            // 
            // frmCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 473);
            this.Controls.Add(this.tabCajas);
            this.Name = "frmCajas";
            this.Text = "Administracion de Cajas";
            this.Load += new System.EventHandler(this.frmCajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbBusca.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbNuevo.ResumeLayout(false);
            this.tabCajas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCajas;
        private UsrCerrar usrCerrar1;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UsrNumeros usrNumCajas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabPage tbBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.TabPage tbNuevo;
        private System.Windows.Forms.TabControl tabCajas;
        private System.Windows.Forms.CheckBox chkHabilitada;
        private System.Windows.Forms.TextBox txtMaccaddres;
        private System.Windows.Forms.Label label2;
    }
}