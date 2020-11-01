namespace PuntoVenta
{
    partial class frmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabFamilias = new System.Windows.Forms.TabControl();
            this.tbNuevo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usrNumeros1 = new PuntoVenta.UsrNumeros();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usrCerrar1 = new PuntoVenta.UsrCerrar();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TabPage();
            this.dtgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.tabFamilias.SuspendLayout();
            this.tbNuevo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tbBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartamentos)).BeginInit();
            this.SuspendLayout();
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // tabFamilias
            // 
            this.tabFamilias.Controls.Add(this.tbNuevo);
            this.tabFamilias.Controls.Add(this.tbBusca);
            this.tabFamilias.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabFamilias.Font = new System.Drawing.Font("Arial", 12F);
            this.tabFamilias.Location = new System.Drawing.Point(43, 12);
            this.tabFamilias.Name = "tabFamilias";
            this.tabFamilias.SelectedIndex = 0;
            this.tabFamilias.Size = new System.Drawing.Size(807, 466);
            this.tabFamilias.TabIndex = 5;
            this.tabFamilias.SelectedIndexChanged += new System.EventHandler(this.tabFamilias_SelectedIndexChanged);
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
            this.tbNuevo.Size = new System.Drawing.Size(799, 435);
            this.tbNuevo.TabIndex = 0;
            this.tbNuevo.Text = "Nuevo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.usrNumeros1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDepartamento);
            this.groupBox1.Controls.Add(this.lblFamilia);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 307);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departamentos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 170);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // usrNumeros1
            // 
            this.usrNumeros1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrNumeros1.bColor = false;
            this.usrNumeros1.bDecimal = false;
            this.usrNumeros1.Cursor = System.Windows.Forms.Cursors.Default;
            this.usrNumeros1.Location = new System.Drawing.Point(430, 116);
            this.usrNumeros1.Margin = new System.Windows.Forms.Padding(5);
            this.usrNumeros1.Name = "usrNumeros1";
            this.usrNumeros1.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.usrNumeros1.Size = new System.Drawing.Size(143, 39);
            this.usrNumeros1.TabIndex = 12;
            this.usrNumeros1.Validated += new System.EventHandler(this.usrNumeros1_Validated_1);
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
            // txtDepartamento
            // 
            this.txtDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartamento.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDepartamento.Location = new System.Drawing.Point(434, 166);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(241, 25);
            this.txtDepartamento.TabIndex = 10;
            // 
            // lblFamilia
            // 
            this.lblFamilia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFamilia.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFamilia.Location = new System.Drawing.Point(320, 168);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(108, 18);
            this.lblFamilia.TabIndex = 9;
            this.lblFamilia.Text = "Departamento";
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // tbBusca
            // 
            this.tbBusca.Controls.Add(this.dtgvDepartamentos);
            this.tbBusca.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbBusca.Location = new System.Drawing.Point(4, 27);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tbBusca.Size = new System.Drawing.Size(799, 435);
            this.tbBusca.TabIndex = 1;
            this.tbBusca.Text = "Busqueda";
            this.tbBusca.UseVisualStyleBackColor = true;
            // 
            // dtgvDepartamentos
            // 
            this.dtgvDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDepartamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvDepartamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvDepartamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvDepartamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDepartamentos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgvDepartamentos.Location = new System.Drawing.Point(0, 3);
            this.dtgvDepartamentos.Name = "dtgvDepartamentos";
            this.dtgvDepartamentos.ReadOnly = true;
            this.dtgvDepartamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvDepartamentos.Size = new System.Drawing.Size(793, 441);
            this.dtgvDepartamentos.TabIndex = 0;
            this.dtgvDepartamentos.DoubleClick += new System.EventHandler(this.dtgvDepartamentos_DoubleClick);
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 501);
            this.Controls.Add(this.tabFamilias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.frmDepartamentos_Load);
            this.tabFamilias.ResumeLayout(false);
            this.tbNuevo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbBusca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabControl tabFamilias;
        private System.Windows.Forms.TabPage tbNuevo;
        private System.Windows.Forms.TabPage tbBusca;
        private System.Windows.Forms.DataGridView dtgvDepartamentos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private UsrCerrar usrCerrar1;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UsrNumeros usrNumeros1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblFamilia;

    }
}