namespace BankingApp
{
    partial class WithdrawForm
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
            if(disposing && (components != null)) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbWdAmt = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmWd = new System.Windows.Forms.Button();
            this.lblWdAmt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "$";
            // 
            // tbWdAmt
            // 
            this.tbWdAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWdAmt.Location = new System.Drawing.Point(444, 61);
            this.tbWdAmt.MaxLength = 12;
            this.tbWdAmt.Name = "tbWdAmt";
            this.tbWdAmt.Size = new System.Drawing.Size(154, 35);
            this.tbWdAmt.TabIndex = 11;
            this.tbWdAmt.Text = "0.00";
            this.tbWdAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(376, 191);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 48);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmWd
            // 
            this.btnConfirmWd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirmWd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmWd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmWd.Location = new System.Drawing.Point(171, 191);
            this.btnConfirmWd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmWd.Name = "btnConfirmWd";
            this.btnConfirmWd.Size = new System.Drawing.Size(159, 48);
            this.btnConfirmWd.TabIndex = 9;
            this.btnConfirmWd.Text = "Confirm Withdrawal";
            this.btnConfirmWd.UseVisualStyleBackColor = false;
            this.btnConfirmWd.Click += new System.EventHandler(this.btnConfirmWd_Click);
            // 
            // lblWdAmt
            // 
            this.lblWdAmt.AutoSize = true;
            this.lblWdAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWdAmt.Location = new System.Drawing.Point(111, 63);
            this.lblWdAmt.Name = "lblWdAmt";
            this.lblWdAmt.Size = new System.Drawing.Size(288, 29);
            this.lblWdAmt.TabIndex = 8;
            this.lblWdAmt.Text = "Enter Withdrawal Amount:";
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWdAmt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmWd);
            this.Controls.Add(this.lblWdAmt);
            this.Name = "WithdrawForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Withdraw Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWdAmt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmWd;
        private System.Windows.Forms.Label lblWdAmt;
    }
}