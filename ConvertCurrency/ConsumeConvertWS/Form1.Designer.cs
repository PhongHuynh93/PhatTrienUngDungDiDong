namespace ConsumeConvertWS
{
    partial class Form1
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
            this.btnVND2USD = new System.Windows.Forms.Button();
            this.btnUSD2VND = new System.Windows.Forms.Button();
            this.btnVND2EUR = new System.Windows.Forms.Button();
            this.btnEUR2VND = new System.Windows.Forms.Button();
            this.lblTiendoi = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVND2USD
            // 
            this.btnVND2USD.Location = new System.Drawing.Point(12, 134);
            this.btnVND2USD.Name = "btnVND2USD";
            this.btnVND2USD.Size = new System.Drawing.Size(94, 23);
            this.btnVND2USD.TabIndex = 0;
            this.btnVND2USD.Text = "VND2USD";
            this.btnVND2USD.UseVisualStyleBackColor = true;
            this.btnVND2USD.Click += new System.EventHandler(this.btnVND2USD_Click);
            // 
            // btnUSD2VND
            // 
            this.btnUSD2VND.Location = new System.Drawing.Point(285, 134);
            this.btnUSD2VND.Name = "btnUSD2VND";
            this.btnUSD2VND.Size = new System.Drawing.Size(94, 23);
            this.btnUSD2VND.TabIndex = 1;
            this.btnUSD2VND.Text = "USD2VND";
            this.btnUSD2VND.UseVisualStyleBackColor = true;
            this.btnUSD2VND.Click += new System.EventHandler(this.btnUSD2VND_Click);
            // 
            // btnVND2EUR
            // 
            this.btnVND2EUR.Location = new System.Drawing.Point(141, 134);
            this.btnVND2EUR.Name = "btnVND2EUR";
            this.btnVND2EUR.Size = new System.Drawing.Size(94, 23);
            this.btnVND2EUR.TabIndex = 2;
            this.btnVND2EUR.Text = "VND2EUR";
            this.btnVND2EUR.UseVisualStyleBackColor = true;
            this.btnVND2EUR.Click += new System.EventHandler(this.btnVND2EUR_Click);
            // 
            // btnEUR2VND
            // 
            this.btnEUR2VND.Location = new System.Drawing.Point(417, 134);
            this.btnEUR2VND.Name = "btnEUR2VND";
            this.btnEUR2VND.Size = new System.Drawing.Size(94, 23);
            this.btnEUR2VND.TabIndex = 3;
            this.btnEUR2VND.Text = "EUR2VND";
            this.btnEUR2VND.UseVisualStyleBackColor = true;
            this.btnEUR2VND.Click += new System.EventHandler(this.btnEUR2VND_Click);
            // 
            // lblTiendoi
            // 
            this.lblTiendoi.AutoSize = true;
            this.lblTiendoi.Location = new System.Drawing.Point(40, 64);
            this.lblTiendoi.Name = "lblTiendoi";
            this.lblTiendoi.Size = new System.Drawing.Size(66, 13);
            this.lblTiendoi.TabIndex = 4;
            this.lblTiendoi.Text = "Tiền quy đổi";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(62, 205);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(44, 13);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "Kết quả";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(141, 61);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(347, 20);
            this.txtMoney.TabIndex = 6;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(141, 198);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(347, 20);
            this.txtKetQua.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(540, 262);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblTiendoi);
            this.Controls.Add(this.btnEUR2VND);
            this.Controls.Add(this.btnVND2EUR);
            this.Controls.Add(this.btnUSD2VND);
            this.Controls.Add(this.btnVND2USD);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVND2USD;
        private System.Windows.Forms.Button btnUSD2VND;
        private System.Windows.Forms.Button btnVND2EUR;
        private System.Windows.Forms.Button btnEUR2VND;
        private System.Windows.Forms.Label lblTiendoi;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

