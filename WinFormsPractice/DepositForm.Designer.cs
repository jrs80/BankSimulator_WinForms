namespace BankingApp
{
    partial class DepositForm
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
            this.lblDepAmt = new System.Windows.Forms.Label();
            this.btnConfirmDep = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbDepAmt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepAmt
            // 
            this.lblDepAmt.AutoSize = true;
            this.lblDepAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepAmt.Location = new System.Drawing.Point(139, 76);
            this.lblDepAmt.Name = "lblDepAmt";
            this.lblDepAmt.Size = new System.Drawing.Size(252, 29);
            this.lblDepAmt.TabIndex = 0;
            this.lblDepAmt.Text = "Enter Deposit Amount:";
            // 
            // btnConfirmDep
            // 
            this.btnConfirmDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirmDep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmDep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmDep.Location = new System.Drawing.Point(185, 206);
            this.btnConfirmDep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmDep.Name = "btnConfirmDep";
            this.btnConfirmDep.Size = new System.Drawing.Size(140, 48);
            this.btnConfirmDep.TabIndex = 3;
            this.btnConfirmDep.Text = "Confirm Deposit";
            this.btnConfirmDep.UseVisualStyleBackColor = false;
            this.btnConfirmDep.Click += new System.EventHandler(this.btnConfirmDep_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(390, 206);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbDepAmt
            // 
            this.tbDepAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepAmt.Location = new System.Drawing.Point(458, 76);
            this.tbDepAmt.MaxLength = 12;
            this.tbDepAmt.Name = "tbDepAmt";
            this.tbDepAmt.Size = new System.Drawing.Size(154, 35);
            this.tbDepAmt.TabIndex = 6;
            this.tbDepAmt.Text = "0.00";
            this.tbDepAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDepAmt.TextChanged += new System.EventHandler(this.tbDepAmt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "$";
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDepAmt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmDep);
            this.Controls.Add(this.lblDepAmt);
            this.Name = "DepositForm";
            this.Text = "Make a Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepAmt;
        private System.Windows.Forms.Button btnConfirmDep;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbDepAmt;
        private System.Windows.Forms.Label label1;
    }
}