namespace Calc
{
    partial class FormReg
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.llExit = new System.Windows.Forms.LinkLabel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(145, 91);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(319, 41);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.Text = "Введите пароль";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(145, 23);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(319, 41);
            this.tbLogin.TabIndex = 8;
            this.tbLogin.Text = "Введите логин";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin.Click += new System.EventHandler(this.tbLogin_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.Location = new System.Drawing.Point(457, 456);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(145, 49);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // llExit
            // 
            this.llExit.AutoSize = true;
            this.llExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llExit.LinkColor = System.Drawing.Color.White;
            this.llExit.Location = new System.Drawing.Point(12, 477);
            this.llExit.Name = "llExit";
            this.llExit.Size = new System.Drawing.Size(227, 28);
            this.llExit.TabIndex = 5;
            this.llExit.TabStop = true;
            this.llExit.Text = "Выход из приложения";
            this.llExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExit_LinkClicked);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(145, 164);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(319, 41);
            this.tbName.TabIndex = 10;
            this.tbName.Text = "Введите имя";
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(457, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 49);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(113, 66);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(0, 16);
            this.lbLogin.TabIndex = 12;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(113, 136);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(0, 16);
            this.lbPassword.TabIndex = 13;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(113, 219);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 16);
            this.lbName.TabIndex = 14;
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(145, 240);
            this.tbSurname.Multiline = true;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(319, 41);
            this.tbSurname.TabIndex = 15;
            this.tbSurname.Text = "Введите фамилию";
            this.tbSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSurname.Click += new System.EventHandler(this.tbSurname_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastName.Location = new System.Drawing.Point(145, 307);
            this.tbLastName.Multiline = true;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(319, 41);
            this.tbLastName.TabIndex = 16;
            this.tbLastName.Text = "Введите отчество (при наличии)";
            this.tbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLastName.Click += new System.EventHandler(this.tbLastName_Click);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(614, 530);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.llExit);
            this.Name = "FormReg";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.LinkLabel llExit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbLastName;
    }
}