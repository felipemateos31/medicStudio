namespace MedicStudio.UI.Pacientes
{
    partial class PacientesEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesEdit));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtLugarR = new System.Windows.Forms.TextBox();
            this.recidencia = new System.Windows.Forms.Label();
            this.txtLugarNa = new System.Windows.Forms.TextBox();
            this.nacimiento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtOcupa = new System.Windows.Forms.TextBox();
            this.cmbEsco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstadoCi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.txtDirecion = new System.Windows.Forms.TextBox();
            this.lbDirec = new System.Windows.Forms.Label();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btmBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(405, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guradar";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(486, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Cancelar";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtLugarR);
            this.groupBox1.Controls.Add(this.recidencia);
            this.groupBox1.Controls.Add(this.txtLugarNa);
            this.groupBox1.Controls.Add(this.nacimiento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtOcupa);
            this.groupBox1.Controls.Add(this.cmbEsco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEstadoCi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbFecha);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbTel);
            this.groupBox1.Controls.Add(this.txtDirecion);
            this.groupBox1.Controls.Add(this.lbDirec);
            this.groupBox1.Controls.Add(this.txtApMaterno);
            this.groupBox1.Controls.Add(this.txtApPaterno);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(39, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.Location = new System.Drawing.Point(213, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Apellido Paterno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label6.Location = new System.Drawing.Point(386, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Apellido Materno:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(118, 58);
            this.txtEdad.Mask = "00";
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(26, 21);
            this.txtEdad.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(118, 195);
            this.txtTel.Mask = "0000000000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 21);
            this.txtTel.TabIndex = 11;
            // 
            // txtLugarR
            // 
            this.txtLugarR.Location = new System.Drawing.Point(383, 118);
            this.txtLugarR.MaxLength = 100;
            this.txtLugarR.Name = "txtLugarR";
            this.txtLugarR.Size = new System.Drawing.Size(124, 21);
            this.txtLugarR.TabIndex = 8;
            // 
            // recidencia
            // 
            this.recidencia.AutoSize = true;
            this.recidencia.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.recidencia.Location = new System.Drawing.Point(254, 120);
            this.recidencia.Name = "recidencia";
            this.recidencia.Size = new System.Drawing.Size(120, 16);
            this.recidencia.TabIndex = 24;
            this.recidencia.Text = "Lugar de recidencia:";
            // 
            // txtLugarNa
            // 
            this.txtLugarNa.Location = new System.Drawing.Point(118, 118);
            this.txtLugarNa.Name = "txtLugarNa";
            this.txtLugarNa.Size = new System.Drawing.Size(111, 21);
            this.txtLugarNa.TabIndex = 7;
            // 
            // nacimiento
            // 
            this.nacimiento.AutoSize = true;
            this.nacimiento.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.nacimiento.Location = new System.Drawing.Point(-3, 121);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(123, 16);
            this.nacimiento.TabIndex = 22;
            this.nacimiento.Text = "Lugar de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label5.Location = new System.Drawing.Point(244, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(294, 193);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(213, 21);
            this.txtCorreo.TabIndex = 12;
            // 
            // txtOcupa
            // 
            this.txtOcupa.Location = new System.Drawing.Point(118, 167);
            this.txtOcupa.Name = "txtOcupa";
            this.txtOcupa.Size = new System.Drawing.Size(389, 21);
            this.txtOcupa.TabIndex = 10;
            // 
            // cmbEsco
            // 
            this.cmbEsco.DisplayMember = "Selecciona un elemento";
            this.cmbEsco.FormattingEnabled = true;
            this.cmbEsco.Items.AddRange(new object[] {
            "Inicial",
            "Básica",
            "Media Superior",
            "Superior"});
            this.cmbEsco.Location = new System.Drawing.Point(383, 88);
            this.cmbEsco.Name = "cmbEsco";
            this.cmbEsco.Size = new System.Drawing.Size(124, 24);
            this.cmbEsco.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(300, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Escolaridad:";
            // 
            // cmbEstadoCi
            // 
            this.cmbEstadoCi.DisplayMember = "Selecciona un elemento";
            this.cmbEstadoCi.FormattingEnabled = true;
            this.cmbEstadoCi.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)"});
            this.cmbEstadoCi.Location = new System.Drawing.Point(118, 86);
            this.cmbEstadoCi.Name = "cmbEstadoCi";
            this.cmbEstadoCi.Size = new System.Drawing.Size(111, 24);
            this.cmbEstadoCi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Estado Civil:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lbFecha.Location = new System.Drawing.Point(247, 64);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(128, 16);
            this.lbFecha.TabIndex = 13;
            this.lbFecha.Text = "Fecha de Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(383, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(67, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edad:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lbTel.Location = new System.Drawing.Point(56, 200);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(56, 16);
            this.lbTel.TabIndex = 9;
            this.lbTel.Text = "Telefono:";
            // 
            // txtDirecion
            // 
            this.txtDirecion.Location = new System.Drawing.Point(118, 142);
            this.txtDirecion.Name = "txtDirecion";
            this.txtDirecion.Size = new System.Drawing.Size(389, 21);
            this.txtDirecion.TabIndex = 9;
            // 
            // lbDirec
            // 
            this.lbDirec.AutoSize = true;
            this.lbDirec.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lbDirec.Location = new System.Drawing.Point(51, 145);
            this.lbDirec.Name = "lbDirec";
            this.lbDirec.Size = new System.Drawing.Size(61, 16);
            this.lbDirec.TabIndex = 6;
            this.lbDirec.Text = "Direccion:";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(360, 32);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(147, 21);
            this.txtApMaterno.TabIndex = 2;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(185, 32);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(157, 21);
            this.txtApPaterno.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 21);
            this.txtNombre.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lbNombre.Location = new System.Drawing.Point(62, 13);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.Location = new System.Drawing.Point(41, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ocupación:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btmBack
            // 
            this.btmBack.BackColor = System.Drawing.Color.DarkRed;
            this.btmBack.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btmBack.ForeColor = System.Drawing.Color.Transparent;
            this.btmBack.Image = ((System.Drawing.Image)(resources.GetObject("btmBack.Image")));
            this.btmBack.Location = new System.Drawing.Point(43, 6);
            this.btmBack.Name = "btmBack";
            this.btmBack.Size = new System.Drawing.Size(58, 59);
            this.btmBack.TabIndex = 32;
            this.btmBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btmBack.UseVisualStyleBackColor = false;
            this.btmBack.Click += new System.EventHandler(this.btmBack_Click);
            // 
            // PacientesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::MedicStudio.UI.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.btmBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PacientesEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.PacientesEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDirecion;
        private System.Windows.Forms.Label lbDirec;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOcupa;
        private System.Windows.Forms.ComboBox cmbEsco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstadoCi;
        private System.Windows.Forms.TextBox txtLugarR;
        private System.Windows.Forms.Label recidencia;
        private System.Windows.Forms.TextBox txtLugarNa;
        private System.Windows.Forms.Label nacimiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtEdad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btmBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}