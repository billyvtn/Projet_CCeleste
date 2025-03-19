
namespace GarageCreditCeleste
{
    partial class Assurance
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
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbChoixAssurance = new System.Windows.Forms.GroupBox();
            this.rdbTiers = new System.Windows.Forms.RadioButton();
            this.rdbTiersPlus = new System.Windows.Forms.RadioButton();
            this.rdbTousRisque = new System.Windows.Forms.RadioButton();
            this.gpbChoixAssurance.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(484, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Acheter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(926, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "HDR Garage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Strasbourg";
            // 
            // gpbChoixAssurance
            // 
            this.gpbChoixAssurance.Controls.Add(this.rdbTousRisque);
            this.gpbChoixAssurance.Controls.Add(this.rdbTiersPlus);
            this.gpbChoixAssurance.Controls.Add(this.rdbTiers);
            this.gpbChoixAssurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbChoixAssurance.Location = new System.Drawing.Point(66, 142);
            this.gpbChoixAssurance.Name = "gpbChoixAssurance";
            this.gpbChoixAssurance.Size = new System.Drawing.Size(235, 185);
            this.gpbChoixAssurance.TabIndex = 33;
            this.gpbChoixAssurance.TabStop = false;
            this.gpbChoixAssurance.Text = "Type d\'assurance";
            // 
            // rdbTiers
            // 
            this.rdbTiers.AutoSize = true;
            this.rdbTiers.Location = new System.Drawing.Point(24, 48);
            this.rdbTiers.Name = "rdbTiers";
            this.rdbTiers.Size = new System.Drawing.Size(73, 28);
            this.rdbTiers.TabIndex = 0;
            this.rdbTiers.TabStop = true;
            this.rdbTiers.Text = "Tiers";
            this.rdbTiers.UseVisualStyleBackColor = true;
            // 
            // rdbTiersPlus
            // 
            this.rdbTiersPlus.AutoSize = true;
            this.rdbTiersPlus.Location = new System.Drawing.Point(24, 95);
            this.rdbTiersPlus.Name = "rdbTiersPlus";
            this.rdbTiersPlus.Size = new System.Drawing.Size(89, 28);
            this.rdbTiersPlus.TabIndex = 1;
            this.rdbTiersPlus.TabStop = true;
            this.rdbTiersPlus.Text = "Tiers +";
            this.rdbTiersPlus.UseVisualStyleBackColor = true;
            // 
            // rdbTousRisque
            // 
            this.rdbTousRisque.AutoSize = true;
            this.rdbTousRisque.Location = new System.Drawing.Point(24, 140);
            this.rdbTousRisque.Name = "rdbTousRisque";
            this.rdbTousRisque.Size = new System.Drawing.Size(140, 28);
            this.rdbTousRisque.TabIndex = 2;
            this.rdbTousRisque.TabStop = true;
            this.rdbTousRisque.Text = "Tous risques";
            this.rdbTousRisque.UseVisualStyleBackColor = true;
            // 
            // Assurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gpbChoixAssurance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Assurance";
            this.Text = "Assurance";
            this.Load += new System.EventHandler(this.Assurance_Load);
            this.gpbChoixAssurance.ResumeLayout(false);
            this.gpbChoixAssurance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbChoixAssurance;
        private System.Windows.Forms.RadioButton rdbTousRisque;
        private System.Windows.Forms.RadioButton rdbTiersPlus;
        private System.Windows.Forms.RadioButton rdbTiers;
    }
}