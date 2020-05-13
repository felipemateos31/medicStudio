namespace MedicStudio.UI.Nutricion
{
    partial class Nutricion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nutricion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMotivo = new System.Windows.Forms.RichTextBox();
            this.txtProblemas = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMed = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTipoC = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbsi = new System.Windows.Forms.CheckBox();
            this.rbno = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtEI = new System.Windows.Forms.RichTextBox();
            this.txtEC = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtPecho = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAbd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBrazo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCuello = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtActFis = new System.Windows.Forms.RichTextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btmBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPaciente);
            this.groupBox1.Controls.Add(this.cmbMedico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(247, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 46);
            this.groupBox1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medico";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Controls.Add(this.txtProblemas);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 98);
            this.groupBox2.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Problemas Actuales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Motivo de la Consulta";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtMed);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(222, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 132);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Medicamentos";
            // 
            // txtMed
            // 
            this.txtMed.Location = new System.Drawing.Point(6, 36);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(192, 90);
            this.txtMed.TabIndex = 3;
            this.txtMed.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtTipoC);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.rbsi);
            this.groupBox4.Controls.Add(this.rbno);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox4.Location = new System.Drawing.Point(12, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 132);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // txtTipoC
            // 
            this.txtTipoC.Location = new System.Drawing.Point(12, 72);
            this.txtTipoC.Name = "txtTipoC";
            this.txtTipoC.Size = new System.Drawing.Size(182, 54);
            this.txtTipoC.TabIndex = 5;
            this.txtTipoC.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo de cirugia";
            // 
            // rbsi
            // 
            this.rbsi.AutoSize = true;
            this.rbsi.Location = new System.Drawing.Point(59, 30);
            this.rbsi.Name = "rbsi";
            this.rbsi.Size = new System.Drawing.Size(35, 20);
            this.rbsi.TabIndex = 6;
            this.rbsi.Text = "Si";
            this.rbsi.UseVisualStyleBackColor = true;
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Location = new System.Drawing.Point(109, 30);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(42, 20);
            this.rbno.TabIndex = 5;
            this.rbno.Text = "No";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Presenta cirugias";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.txtEI);
            this.groupBox5.Controls.Add(this.txtEC);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox5.Location = new System.Drawing.Point(432, 332);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(450, 132);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // txtEI
            // 
            this.txtEI.Location = new System.Drawing.Point(253, 37);
            this.txtEI.Name = "txtEI";
            this.txtEI.Size = new System.Drawing.Size(182, 88);
            this.txtEI.TabIndex = 8;
            this.txtEI.Text = "";
            // 
            // txtEC
            // 
            this.txtEC.Location = new System.Drawing.Point(24, 37);
            this.txtEC.Name = "txtEC";
            this.txtEC.Size = new System.Drawing.Size(182, 88);
            this.txtEC.TabIndex = 5;
            this.txtEC.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Enfermedades importantes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Enfermedades Cronicas";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.txtObs);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.txtActFis);
            this.groupBox6.Controls.Add(this.txtIMC);
            this.groupBox6.Controls.Add(this.txtEstatura);
            this.groupBox6.Controls.Add(this.txtTalla);
            this.groupBox6.Controls.Add(this.txtPeso);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox6.Location = new System.Drawing.Point(12, 220);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(876, 112);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
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
            this.label19.Location = new System.Drawing.Point(448, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 16);
            this.label19.TabIndex = 9;
            this.label19.Text = "Obsevaciones";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtPecho);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.txtAbd);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.txtBrazo);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.txtCuello);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.groupBox7.Location = new System.Drawing.Point(269, 8);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(145, 98);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Medidas";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // txtPecho
            // 
            this.txtPecho.Location = new System.Drawing.Point(74, 71);
            this.txtPecho.Name = "txtPecho";
            this.txtPecho.Size = new System.Drawing.Size(55, 21);
            this.txtPecho.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "Pecho";
            // 
            // txtAbd
            // 
            this.txtAbd.Location = new System.Drawing.Point(74, 32);
            this.txtAbd.Name = "txtAbd";
            this.txtAbd.Size = new System.Drawing.Size(55, 21);
            this.txtAbd.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(71, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Abdomen";
            // 
            // txtBrazo
            // 
            this.txtBrazo.Location = new System.Drawing.Point(6, 71);
            this.txtBrazo.Name = "txtBrazo";
            this.txtBrazo.Size = new System.Drawing.Size(55, 21);
            this.txtBrazo.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Brazo";
            // 
            // txtCuello
            // 
            this.txtCuello.Location = new System.Drawing.Point(6, 32);
            this.txtCuello.Name = "txtCuello";
            this.txtCuello.Size = new System.Drawing.Size(55, 21);
            this.txtCuello.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Cuello";
            // 
            // txtActFis
            // 
            this.txtActFis.Location = new System.Drawing.Point(160, 68);
            this.txtActFis.Name = "txtActFis";
            this.txtActFis.Size = new System.Drawing.Size(90, 38);
            this.txtActFis.TabIndex = 8;
            this.txtActFis.Text = "";
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(197, 14);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(55, 21);
            this.txtIMC.TabIndex = 16;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(79, 85);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(55, 21);
            this.txtEstatura.TabIndex = 15;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(79, 50);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(55, 21);
            this.txtTalla.TabIndex = 14;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(79, 14);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(55, 21);
            this.txtPeso.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(160, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Actividad Fisica";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "IMC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Estatura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Talla";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Peso";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(807, 71);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 12;
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
            this.btnSave.Location = new System.Drawing.Point(726, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guradar";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(84, 49);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(109, 37);
            this.lbHora.TabIndex = 14;
            this.lbHora.Text = "HORA";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btmBack
            // 
            this.btmBack.BackColor = System.Drawing.Color.DarkRed;
            this.btmBack.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btmBack.ForeColor = System.Drawing.Color.Transparent;
            this.btmBack.Image = ((System.Drawing.Image)(resources.GetObject("btmBack.Image")));
            this.btmBack.Location = new System.Drawing.Point(12, 49);
            this.btmBack.Name = "btmBack";
            this.btmBack.Size = new System.Drawing.Size(71, 68);
            this.btmBack.TabIndex = 40;
            this.btmBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btmBack.UseVisualStyleBackColor = false;
            this.btmBack.Click += new System.EventHandler(this.btmBack_Click);
            // 
            // Nutricion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::MedicStudio.UI.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.btmBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nutricion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutrición";
            this.Load += new System.EventHandler(this.Nutricion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtProblemas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtMotivo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtMed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox txtTipoC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox rbsi;
        private System.Windows.Forms.CheckBox rbno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox txtEI;
        private System.Windows.Forms.RichTextBox txtEC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtPecho;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAbd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBrazo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCuello;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtActFis;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btmBack;
    }
}