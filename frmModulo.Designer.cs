namespace PuntoVenta
{
    partial class frmModulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModulo));
            this.tbBusca = new System.Windows.Forms.TabPage();
            this.dtGridMod = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkEs_administrador = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.usrCerrar1 = new PuntoVenta.UsrCerrar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnNuevo = new System.Windows.Forms.TabPage();
            this.usrNumMod = new PuntoVenta.UsrNumeros();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tbnNuevo.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBusca
            // 
            this.tbBusca.Controls.Add(this.dtGridMod);
            this.tbBusca.Location = new System.Drawing.Point(4, 27);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tbBusca.Size = new System.Drawing.Size(832, 313);
            this.tbBusca.TabIndex = 1;
            this.tbBusca.Text = "Busqueda";
            this.tbBusca.UseVisualStyleBackColor = true;
            // 
            // dtGridMod
            // 
            this.dtGridMod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridMod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtGridMod.Location = new System.Drawing.Point(18, 15);
            this.dtGridMod.Name = "dtGridMod";
            this.dtGridMod.ReadOnly = true;
            this.dtGridMod.Size = new System.Drawing.Size(787, 281);
            this.dtGridMod.TabIndex = 0;
            this.dtGridMod.DoubleClick += new System.EventHandler(this.dtGridMod_DoubleClick);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // chkEs_administrador
            // 
            this.chkEs_administrador.AutoSize = true;
            this.chkEs_administrador.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEs_administrador.Location = new System.Drawing.Point(463, 214);
            this.chkEs_administrador.Name = "chkEs_administrador";
            this.chkEs_administrador.Size = new System.Drawing.Size(138, 20);
            this.chkEs_administrador.TabIndex = 4;
            this.chkEs_administrador.Text = "Es_Administrador";
            this.chkEs_administrador.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(261, 15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 25);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtFormato
            // 
            this.txtFormato.Location = new System.Drawing.Point(463, 169);
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(201, 26);
            this.txtFormato.TabIndex = 3;
            this.txtFormato.TextChanged += new System.EventHandler(this.txtFormato_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre del Modulo";
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
            this.groupBox2.Location = new System.Drawing.Point(15, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 55);
            this.groupBox2.TabIndex = 19;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formato";
            // 
            // tbnNuevo
            // 
            this.tbnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbnNuevo.Controls.Add(this.pictureBox1);
            this.tbnNuevo.Controls.Add(this.usrNumMod);
            this.tbnNuevo.Controls.Add(this.chkEs_administrador);
            this.tbnNuevo.Controls.Add(this.txtNombreMod);
            this.tbnNuevo.Controls.Add(this.txtFormato);
            this.tbnNuevo.Controls.Add(this.label3);
            this.tbnNuevo.Controls.Add(this.label2);
            this.tbnNuevo.Controls.Add(this.label1);
            this.tbnNuevo.Location = new System.Drawing.Point(4, 27);
            this.tbnNuevo.Name = "tbnNuevo";
            this.tbnNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tbnNuevo.Size = new System.Drawing.Size(832, 313);
            this.tbnNuevo.TabIndex = 0;
            this.tbnNuevo.Text = "Nuevo";
            // 
            // usrNumMod
            // 
            this.usrNumMod.bColor = false;
            this.usrNumMod.bDecimal = false;
            this.usrNumMod.Location = new System.Drawing.Point(460, 90);
            this.usrNumMod.Margin = new System.Windows.Forms.Padding(4);
            this.usrNumMod.Name = "usrNumMod";
            this.usrNumMod.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.usrNumMod.Size = new System.Drawing.Size(130, 31);
            this.usrNumMod.TabIndex = 1;
            this.usrNumMod.Validated += new System.EventHandler(this.usrNumMod_Validated);
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(463, 137);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(201, 26);
            this.txtNombreMod.TabIndex = 3;
            this.txtNombreMod.TextChanged += new System.EventHandler(this.txtNombreMod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folio";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.tabProductos);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 381);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modulos";
            // 
            // frmModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas ,Bajas y Cambios";
            this.Load += new System.EventHandler(this.frmModulo_Load);
            this.tbBusca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tbnNuevo.ResumeLayout(false);
            this.tbnNuevo.PerformLayout();
            this.tabProductos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbBusca;
        private System.Windows.Forms.DataGridView dtGridMod;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UsrNumeros usrNumMod;
        private System.Windows.Forms.CheckBox chkEs_administrador;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtFormato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Button btnModificar;
        private UsrCerrar usrCerrar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreMod;
    }
}