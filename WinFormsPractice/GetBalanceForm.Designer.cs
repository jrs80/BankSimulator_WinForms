namespace BankingApp
{
    partial class GetBalanceForm
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
            this.acctInfoBox = new System.Windows.Forms.GroupBox();
            this.btnDispAcctBal = new System.Windows.Forms.Button();
            this.btnDispAcctType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrderChecks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.acctInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // acctInfoBox
            // 
            this.acctInfoBox.Controls.Add(this.btnDispAcctBal);
            this.acctInfoBox.Controls.Add(this.btnDispAcctType);
            this.acctInfoBox.Controls.Add(this.btnCancel);
            this.acctInfoBox.Controls.Add(this.btnOrderChecks);
            this.acctInfoBox.Controls.Add(this.label2);
            this.acctInfoBox.Controls.Add(this.label1);
            this.acctInfoBox.Location = new System.Drawing.Point(30, 29);
            this.acctInfoBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acctInfoBox.Name = "acctInfoBox";
            this.acctInfoBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acctInfoBox.Size = new System.Drawing.Size(496, 262);
            this.acctInfoBox.TabIndex = 0;
            this.acctInfoBox.TabStop = false;
            this.acctInfoBox.Text = "Account Information";
            // 
            // btnDispAcctBal
            // 
            this.btnDispAcctBal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDispAcctBal.Enabled = false;
            this.btnDispAcctBal.Location = new System.Drawing.Point(224, 103);
            this.btnDispAcctBal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAcctBal.Name = "btnDispAcctBal";
            this.btnDispAcctBal.Size = new System.Drawing.Size(192, 40);
            this.btnDispAcctBal.TabIndex = 6;
            this.btnDispAcctBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDispAcctBal.UseVisualStyleBackColor = false;
            // 
            // btnDispAcctType
            // 
            this.btnDispAcctType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDispAcctType.Enabled = false;
            this.btnDispAcctType.Location = new System.Drawing.Point(224, 42);
            this.btnDispAcctType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAcctType.Name = "btnDispAcctType";
            this.btnDispAcctType.Size = new System.Drawing.Size(192, 40);
            this.btnDispAcctType.TabIndex = 5;
            this.btnDispAcctType.Text = "Checking";
            this.btnDispAcctType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDispAcctType.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(264, 194);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(126, 48);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOrderChecks
            // 
            this.btnOrderChecks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOrderChecks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderChecks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrderChecks.Location = new System.Drawing.Point(100, 194);
            this.btnOrderChecks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrderChecks.Name = "btnOrderChecks";
            this.btnOrderChecks.Size = new System.Drawing.Size(126, 48);
            this.btnOrderChecks.TabIndex = 2;
            this.btnOrderChecks.Text = "Order Checks";
            this.btnOrderChecks.UseVisualStyleBackColor = false;
            this.btnOrderChecks.Click += new System.EventHandler(this.btnOrderChecks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Type";
            // 
            // GetBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 314);
            this.Controls.Add(this.acctInfoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GetBalanceForm";
            this.Text = "Account Balance";
            this.acctInfoBox.ResumeLayout(false);
            this.acctInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox acctInfoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDispAcctBal;
        private System.Windows.Forms.Button btnDispAcctType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrderChecks;

    }
}