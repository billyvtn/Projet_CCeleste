
namespace GarageCreditCeleste
{
    partial class Sortie
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 24);
            this.label8.TabIndex = 100;
            this.label8.Text = "Merci pour votre visite !";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnFermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFermer.Location = new System.Drawing.Point(495, 128);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(126, 43);
            this.btnFermer.TabIndex = 101;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 102;
            this.label1.Text = "A bientôt !";
            // 
            // Sortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GarageCreditCeleste.Properties.Resources.garage;
            this.ClientSize = new System.Drawing.Size(731, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sortie";
            this.Text = "Sortie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label1;
    }
}