
namespace GarageCreditCeleste
{
    partial class ChoixCredit
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
            this.btnNonCredit = new System.Windows.Forms.Button();
            this.btnOuiCredit = new System.Windows.Forms.Button();
            this.lblChoixCredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNonCredit
            // 
            this.btnNonCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnNonCredit.Location = new System.Drawing.Point(145, 81);
            this.btnNonCredit.Name = "btnNonCredit";
            this.btnNonCredit.Size = new System.Drawing.Size(60, 30);
            this.btnNonCredit.TabIndex = 72;
            this.btnNonCredit.Text = "Non";
            this.btnNonCredit.UseVisualStyleBackColor = true;
            // 
            // btnOuiCredit
            // 
            this.btnOuiCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnOuiCredit.Location = new System.Drawing.Point(67, 81);
            this.btnOuiCredit.Name = "btnOuiCredit";
            this.btnOuiCredit.Size = new System.Drawing.Size(60, 30);
            this.btnOuiCredit.TabIndex = 73;
            this.btnOuiCredit.Text = "Oui";
            this.btnOuiCredit.UseVisualStyleBackColor = true;
            // 
            // lblChoixCredit
            // 
            this.lblChoixCredit.AutoSize = true;
            this.lblChoixCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblChoixCredit.Location = new System.Drawing.Point(32, 39);
            this.lblChoixCredit.Name = "lblChoixCredit";
            this.lblChoixCredit.Size = new System.Drawing.Size(225, 17);
            this.lblChoixCredit.TabIndex = 74;
            this.lblChoixCredit.Text = "Voulez-vous contracter un crédit ?";
            // 
            // ChoixCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 151);
            this.Controls.Add(this.lblChoixCredit);
            this.Controls.Add(this.btnNonCredit);
            this.Controls.Add(this.btnOuiCredit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChoixCredit";
            this.Text = "ChoixCredit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNonCredit;
        private System.Windows.Forms.Button btnOuiCredit;
        private System.Windows.Forms.Label lblChoixCredit;
    }
}