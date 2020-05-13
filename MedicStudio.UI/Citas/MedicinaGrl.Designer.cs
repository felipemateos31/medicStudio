namespace MedicStudio.UI.Citas
{
    partial class MedicinaGrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicinaGrl));
            this.lbhora = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMed = new System.Windows.Forms.RichTextBox();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtEI = new System.Windows.Forms.RichTextBox();
            this.txtEC = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.txtProblemas = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDiag = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btmBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.Location = new System.Drawing.Point(96, 37);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(109, 37);
            this.lbhora.TabIndex = 32;
            this.lbhora.Text = "HORA";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(66, 10);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(800, 81);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Cancelar";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(719, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Guradar";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPaciente);
            this.groupBox1.Controls.Add(this.cmbMedico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(240, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 46);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(271, 15);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(140, 24);
            this.cmbPaciente.TabIndex = 3;
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(62, 15);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(140, 24);
            this.cmbMedico.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medico";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtMed);
            this.groupBox6.Controls.Add(this.txtObs);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox6.Location = new System.Drawing.Point(12, 227);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(876, 112);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Medicamentos";
            // 
            // txtMed
            // 
            this.txtMed.Location = new System.Drawing.Point(130, 14);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(310, 90);
            this.txtMed.TabIndex = 10;
            this.txtMed.Text = "";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(560, 14);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(310, 90);
            this.txtObs.TabIndex = 5;
            this.txtObs.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(467, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 16);
            this.label19.TabIndex = 9;
            this.label19.Text = "Obsevaciones";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.txtEI);
            this.groupBox5.Controls.Add(this.txtEC);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox5.Location = new System.Drawing.Point(7, 340);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(425, 132);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            // 
            // txtEI
            // 
            this.txtEI.Location = new System.Drawing.Point(222, 36);
            this.txtEI.Name = "txtEI";
            this.txtEI.Size = new System.Drawing.Size(188, 88);
            this.txtEI.TabIndex = 8;
            this.txtEI.Text = "";
            // 
            // txtEC
            // 
            this.txtEC.Location = new System.Drawing.Point(18, 36);
            this.txtEC.Name = "txtEC";
            this.txtEC.Size = new System.Drawing.Size(188, 88);
            this.txtEC.TabIndex = 5;
            this.txtEC.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Enfermedades importantes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Enfermedades Cronicas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Controls.Add(this.txtProblemas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 98);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.Location = new System.Drawing.Point(130, 15);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(310, 77);
            this.txtMotivo.TabIndex = 4;
            this.txtMotivo.Text = "";
            // 
            // txtProblemas
            // 
            this.txtProblemas.BackColor = System.Drawing.SystemColors.Window;
            this.txtProblemas.Location = new System.Drawing.Point(560, 15);
            this.txtProblemas.Name = "txtProblemas";
            this.txtProblemas.Size = new System.Drawing.Size(310, 77);
            this.txtProblemas.TabIndex = 2;
            this.txtProblemas.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Problemas Actuales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Motivo de la Consulta";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtDiag);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(438, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 132);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // txtDiag
            // 
            this.txtDiag.Location = new System.Drawing.Point(24, 37);
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(395, 88);
            this.txtDiag.TabIndex = 5;
            this.txtDiag.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Diagnostico ";
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
            this.btmBack.Location = new System.Drawing.Point(16, 51);
            this.btmBack.Name = "btmBack";
            this.btmBack.Size = new System.Drawing.Size(71, 68);
            this.btmBack.TabIndex = 41;
            this.btmBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btmBack.UseVisualStyleBackColor = false;
            this.btmBack.Click += new System.EventHandler(this.btmBack_Click);
            // 
            // MedicinaGrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::MedicStudio.UI.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.btmBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbhora);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicinaGrl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicina General";
            this.Load += new System.EventHandler(this.MedicinaGrl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtMed;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox txtEI;
        private System.Windows.Forms.RichTextBox txtEC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.RichTextBox txtProblemas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtDiag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btmBack;
    }
}