namespace PuntoVenta
{
    partial class serCierraTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serCierraTurno));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usrMontoFin = new PuntoVenta.UsrNumeros();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.usrMonto = new PuntoVenta.UsrNumeros();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbtnPrimero = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblturno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.usrCerrar1 = new PuntoVenta.UsrCerrar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.usrMontoFin);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.usrMonto);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblturno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCajero);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // usrMontoFin
            // 
            this.usrMontoFin.bColor = false;
            this.usrMontoFin.bDecimal = false;
            this.usrMontoFin.Location = new System.Drawing.Point(129, 172);
            this.usrMontoFin.Margin = new System.Windows.Forms.Padding(4);
            this.usrMontoFin.Name = "usrMontoFin";
            this.usrMontoFin.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.usrMontoFin.Size = new System.Drawing.Size(139, 39);
            this.usrMontoFin.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // usrMonto
            // 
            this.usrMonto.bColor = false;
            this.usrMonto.bDecimal = true;
            this.usrMonto.Location = new System.Drawing.Point(300, 324);
            this.usrMonto.Margin = new System.Windows.Forms.Padding(6);
            this.usrMonto.Name = "usrMonto";
            this.usrMonto.nValor = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.usrMonto.Size = new System.Drawing.Size(219, 58);
            this.usrMonto.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.rbtnPrimero);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(36, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(186, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Definitivo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbtnPrimero
            // 
            this.rbtnPrimero.AutoSize = true;
            this.rbtnPrimero.Checked = true;
            this.rbtnPrimero.Location = new System.Drawing.Point(77, 22);
            this.rbtnPrimero.Name = "rbtnPrimero";
            this.rbtnPrimero.Size = new System.Drawing.Size(90, 22);
            this.rbtnPrimero.TabIndex = 1;
            this.rbtnPrimero.TabStop = true;
            this.rbtnPrimero.Text = "Temporal";
            this.rbtnPrimero.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cierre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cajero";
            // 
            // lblturno
            // 
            this.lblturno.AutoSize = true;
            this.lblturno.Location = new System.Drawing.Point(110, 60);
            this.lblturno.Name = "lblturno";
            this.lblturno.Size = new System.Drawing.Size(0, 18);
            this.lblturno.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto Final";
            // 
            // txtCajero
            // 
            this.txtCajero.Enabled = false;
            this.txtCajero.Location = new System.Drawing.Point(129, 110);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Size = new System.Drawing.Size(211, 26);
            this.txtCajero.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.btnAceptar);
            this.groupBox3.Controls.Add(this.usrCerrar1);
            this.groupBox3.Location = new System.Drawing.Point(13, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 58);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(353, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 32);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // usrCerrar1
            // 
            this.usrCerrar1.bPregunta = false;
            this.usrCerrar1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrCerrar1.Location = new System.Drawing.Point(19, 13);
            this.usrCerrar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usrCerrar1.Name = "usrCerrar1";
            this.usrCerrar1.Size = new System.Drawing.Size(108, 38);
            this.usrCerrar1.sTexto = "Cerrar";
            this.usrCerrar1.TabIndex = 1;
            // 
            // serCierraTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 407);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "serCierraTurno";
            this.Text = "CierraTurno";
            this.Load += new System.EventHandler(this.serCierraTurno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbtnPrimero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private UsrNumeros usrMontoFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private UsrNumeros usrMonto;
        private System.Windows.Forms.Label lblturno;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAceptar;
        private UsrCerrar usrCerrar1;
    }
}