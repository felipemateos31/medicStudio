namespace MedicStudio_1._0
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Lbl_ErrorName = new System.Windows.Forms.Label();
            this.Lbl_ErrorPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_User
            // 
            this.Txt_User.Location = new System.Drawing.Point(415, 46);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(160, 20);
            this.Txt_User.TabIndex = 0;
            this.Txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_User.Enter += new System.EventHandler(this.Txt_User_Enter);
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Location = new System.Drawing.Point(415, 92);
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.Size = new System.Drawing.Size(160, 20);
            this.Txt_Pass.TabIndex = 1;
            this.Txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Pass.UseSystemPasswordChar = true;
            this.Txt_Pass.Enter += new System.EventHandler(this.Txt_Pass_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Ingresar.Location = new System.Drawing.Point(500, 134);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ingresar.TabIndex = 4;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, -5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_ErrorName
            // 
            this.Lbl_ErrorName.AutoSize = true;
            this.Lbl_ErrorName.BackColor = System.Drawing.Color.White;
            this.Lbl_ErrorName.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorName.Location = new System.Drawing.Point(412, 69);
            this.Lbl_ErrorName.Name = "Lbl_ErrorName";
            this.Lbl_ErrorName.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ErrorName.TabIndex = 7;
            // 
            // Lbl_ErrorPass
            // 
            this.Lbl_ErrorPass.AutoSize = true;
            this.Lbl_ErrorPass.BackColor = System.Drawing.Color.White;
            this.Lbl_ErrorPass.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbl_ErrorPass.Location = new System.Drawing.Point(412, 117);
            this.Lbl_ErrorPass.Name = "Lbl_ErrorPass";
            this.Lbl_ErrorPass.Size = new System.Drawing.Size(0, 13);
            this.Lbl_ErrorPass.TabIndex = 8;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MedicStudio_1._0.Properties.Resources.intefaz_une;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 266);
            this.ControlBox = false;
            this.Controls.Add(this.Lbl_ErrorPass);
            this.Controls.Add(this.Lbl_ErrorName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.Txt_User);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.TextBox Txt_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lbl_ErrorName;
        private System.Windows.Forms.Label Lbl_ErrorPass;
    }
}