
namespace GarageCreditCeleste
{
    partial class ChoixAssurance
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
            this.btnOui = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOui
            // 
            this.btnOui.Location = new System.Drawing.Point(111, 118);
            this.btnOui.Margin = new System.Windows.Forms.Padding(4);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(100, 28);
            this.btnOui.TabIndex = 0;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = true;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // btnNon
            // 
            this.btnNon.Location = new System.Drawing.Point(269, 118);
            this.btnNon.Margin = new System.Windows.Forms.Padding(4);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(100, 28);
            this.btnNon.TabIndex = 1;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = true;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voulez vous souscrire à une assurance pour votre nouvelle voiture ?";
            // 
            // ChoixAssurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.btnOui);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChoixAssurance";
            this.Text = "ChoixAssurance";
            this.Load += new System.EventHandler(this.ChoixAssurance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOui;
        private System.Windows.Forms.Button btnNon;
        private System.Windows.Forms.Label label1;
    }
}