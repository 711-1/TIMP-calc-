namespace Calc
{
    partial class FormHistory
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
            this.llCalc = new System.Windows.Forms.LinkLabel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // llExit
            // 
            this.llExit.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.llExit.AutoSize = true;
            this.llExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llExit.LinkColor = System.Drawing.Color.White;
            this.llExit.Location = new System.Drawing.Point(21, 685);
            this.llExit.Name = "llExit";
            this.llExit.Size = new System.Drawing.Size(206, 25);
            this.llExit.TabIndex = 3;
            this.llExit.TabStop = true;
            this.llExit.Text = "Выход из приложения";
            this.llExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExit_LinkClicked);
            // 
            // llCalc
            // 
            this.llCalc.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.llCalc.AutoSize = true;
            this.llCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llCalc.LinkColor = System.Drawing.Color.White;
            this.llCalc.Location = new System.Drawing.Point(21, 641);
            this.llCalc.Name = "llCalc";
            this.llCalc.Size = new System.Drawing.Size(233, 25);
            this.llCalc.TabIndex = 4;
            this.llCalc.TabStop = true;
            this.llCalc.Text = "Вернуться к калькулятору";
            this.llCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCalc_LinkClicked);
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(26, 22);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(630, 596);
            this.dgvData.TabIndex = 5;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(681, 732);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.llCalc);
            this.Controls.Add(this.llExit);
            this.Name = "FormHistory";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llExit;
        private System.Windows.Forms.LinkLabel llCalc;
        private System.Windows.Forms.DataGridView dgvData;
    }
}