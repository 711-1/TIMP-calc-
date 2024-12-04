namespace Calc
{
    partial class FormAuto
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.llExit = new System.Windows.Forms.LinkLabel();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnEye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llExit
            // 
            this.llExit.AutoSize = true;
            this.llExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llExit.LinkColor = System.Drawing.Color.SeaShell;
            this.llExit.Location = new System.Drawing.Point(60, 363);
            this.llExit.Name = "llExit";
            this.llExit.Size = new System.Drawing.Size(227, 28);
            this.llExit.TabIndex = 0;
            this.llExit.TabStop = true;
            this.llExit.Text = "Выход из приложения";
            this.llExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExit_LinkClicked);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAuto.FlatAppearance.BorderSize = 0;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuto.Location = new System.Drawing.Point(479, 269);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(140, 49);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Войти";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.Location = new System.Drawing.Point(479, 342);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(140, 49);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(65, 78);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(435, 48);
            this.tbLogin.TabIndex = 3;
            this.tbLogin.Text = "Введите логин";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLogin.Click += new System.EventHandler(this.tbLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(65, 163);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(435, 46);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "Введите пароль";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // btnEye
            // 
            this.btnEye.AutoSize = true;
            this.btnEye.FlatAppearance.BorderSize = 0;
            this.btnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEye.ForeColor = System.Drawing.Color.Black;
            this.btnEye.Location = new System.Drawing.Point(523, 160);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(70, 49);
            this.btnEye.TabIndex = 5;
            this.btnEye.Text = "👁";
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(663, 416);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.llExit);
            this.Name = "FormAuto";
            this.Load += new System.EventHandler(this.FormAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llExit;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnEye;
    }
}

