namespace Calc
{
    partial class FormMain
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
            this.llExit = new System.Windows.Forms.LinkLabel();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbDec = new System.Windows.Forms.RadioButton();
            this.rbOct = new System.Windows.Forms.RadioButton();
            this.rbBin = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.llMenu = new System.Windows.Forms.LinkLabel();
            this.llInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llExit
            // 
            this.llExit.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.llExit.AutoSize = true;
            this.llExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llExit.LinkColor = System.Drawing.Color.White;
            this.llExit.Location = new System.Drawing.Point(12, 371);
            this.llExit.Name = "llExit";
            this.llExit.Size = new System.Drawing.Size(206, 25);
            this.llExit.TabIndex = 2;
            this.llExit.TabStop = true;
            this.llExit.Text = "Выход из приложения";
            this.llExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExit_LinkClicked);
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValue.Location = new System.Drawing.Point(22, 24);
            this.tbValue.Multiline = true;
            this.tbValue.Name = "tbValue";
            this.tbValue.ReadOnly = true;
            this.tbValue.Size = new System.Drawing.Size(648, 62);
            this.tbValue.TabIndex = 3;
            this.tbValue.Text = "0";
            this.tbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            this.tbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValue_KeyPress);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(250, 268);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(71, 54);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(361, 268);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(71, 54);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(468, 268);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(71, 54);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(250, 189);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(71, 54);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(361, 189);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(71, 54);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(468, 189);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(71, 54);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(250, 111);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(71, 54);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(361, 111);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(71, 54);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(468, 111);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(71, 54);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(250, 342);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(71, 54);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnA.Enabled = false;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnA.Location = new System.Drawing.Point(574, 113);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(71, 54);
            this.btnA.TabIndex = 14;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnB.Enabled = false;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnB.Location = new System.Drawing.Point(574, 189);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(71, 54);
            this.btnB.TabIndex = 15;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnC.Enabled = false;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC.Location = new System.Drawing.Point(574, 268);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(71, 54);
            this.btnC.TabIndex = 16;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnD.Enabled = false;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnD.Location = new System.Drawing.Point(574, 342);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(71, 54);
            this.btnD.TabIndex = 17;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnE.Enabled = false;
            this.btnE.FlatAppearance.BorderSize = 0;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnE.Location = new System.Drawing.Point(361, 342);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(71, 54);
            this.btnE.TabIndex = 18;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnF.Enabled = false;
            this.btnF.FlatAppearance.BorderSize = 0;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnF.Location = new System.Drawing.Point(468, 342);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(71, 54);
            this.btnF.TabIndex = 19;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHex.ForeColor = System.Drawing.Color.White;
            this.rbHex.Location = new System.Drawing.Point(22, 113);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(70, 32);
            this.rbHex.TabIndex = 20;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "HEX";
            this.rbHex.UseVisualStyleBackColor = true;
            this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // rbDec
            // 
            this.rbDec.AutoSize = true;
            this.rbDec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDec.ForeColor = System.Drawing.Color.White;
            this.rbDec.Location = new System.Drawing.Point(21, 160);
            this.rbDec.Name = "rbDec";
            this.rbDec.Size = new System.Drawing.Size(69, 32);
            this.rbDec.TabIndex = 21;
            this.rbDec.TabStop = true;
            this.rbDec.Text = "DEC";
            this.rbDec.UseVisualStyleBackColor = true;
            this.rbDec.CheckedChanged += new System.EventHandler(this.rbDec_CheckedChanged);
            // 
            // rbOct
            // 
            this.rbOct.AutoSize = true;
            this.rbOct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOct.ForeColor = System.Drawing.Color.White;
            this.rbOct.Location = new System.Drawing.Point(21, 207);
            this.rbOct.Name = "rbOct";
            this.rbOct.Size = new System.Drawing.Size(71, 32);
            this.rbOct.TabIndex = 22;
            this.rbOct.TabStop = true;
            this.rbOct.Text = "OCT";
            this.rbOct.UseVisualStyleBackColor = true;
            this.rbOct.CheckedChanged += new System.EventHandler(this.rbOct_CheckedChanged);
            // 
            // rbBin
            // 
            this.rbBin.AutoSize = true;
            this.rbBin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBin.ForeColor = System.Drawing.Color.White;
            this.rbBin.Location = new System.Drawing.Point(21, 252);
            this.rbBin.Name = "rbBin";
            this.rbBin.Size = new System.Drawing.Size(66, 32);
            this.rbBin.TabIndex = 23;
            this.rbBin.TabStop = true;
            this.rbBin.Text = "BIN";
            this.rbBin.UseVisualStyleBackColor = true;
            this.rbBin.CheckedChanged += new System.EventHandler(this.rbBin_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(140, 111);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 54);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "⬅";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(140, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 54);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // llMenu
            // 
            this.llMenu.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.llMenu.AutoSize = true;
            this.llMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llMenu.LinkColor = System.Drawing.Color.White;
            this.llMenu.Location = new System.Drawing.Point(12, 331);
            this.llMenu.Name = "llMenu";
            this.llMenu.Size = new System.Drawing.Size(85, 25);
            this.llMenu.TabIndex = 26;
            this.llMenu.TabStop = true;
            this.llMenu.Text = "История";
            this.llMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMenu_LinkClicked);
            // 
            // llInfo
            // 
            this.llInfo.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.llInfo.AutoSize = true;
            this.llInfo.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llInfo.LinkColor = System.Drawing.Color.White;
            this.llInfo.Location = new System.Drawing.Point(423, 409);
            this.llInfo.Name = "llInfo";
            this.llInfo.Size = new System.Drawing.Size(222, 24);
            this.llInfo.TabIndex = 27;
            this.llInfo.TabStop = true;
            this.llInfo.Text = "Как работать с калькулятором?";
            this.llInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llInfo_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(694, 442);
            this.Controls.Add(this.llInfo);
            this.Controls.Add(this.llMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbBin);
            this.Controls.Add(this.rbOct);
            this.Controls.Add(this.rbDec);
            this.Controls.Add(this.rbHex);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.llExit);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llExit;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.RadioButton rbDec;
        private System.Windows.Forms.RadioButton rbOct;
        private System.Windows.Forms.RadioButton rbBin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel llMenu;
        private System.Windows.Forms.LinkLabel llInfo;
    }
}