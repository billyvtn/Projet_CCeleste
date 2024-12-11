
namespace GarageCreditCeleste
{
    partial class Credit
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
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontantFinnance = new System.Windows.Forms.TextBox();
            this.txtMensualité = new System.Windows.Forms.TextBox();
            this.txtTauxAnnuel = new System.Windows.Forms.TextBox();
            this.cbxDurée = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(284, 378);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(84, 44);
            this.cmdCalcul.TabIndex = 17;
            this.cmdCalcul.Text = "Calcul";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mensualité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Taux annuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Durée en mois";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Montant Finnancée";
            // 
            // txtMontantFinnance
            // 
            this.txtMontantFinnance.Location = new System.Drawing.Point(51, 36);
            this.txtMontantFinnance.Name = "txtMontantFinnance";
            this.txtMontantFinnance.Size = new System.Drawing.Size(100, 26);
            this.txtMontantFinnance.TabIndex = 12;
            // 
            // txtMensualité
            // 
            this.txtMensualité.Location = new System.Drawing.Point(51, 336);
            this.txtMensualité.Name = "txtMensualité";
            this.txtMensualité.Size = new System.Drawing.Size(100, 26);
            this.txtMensualité.TabIndex = 11;
            // 
            // txtTauxAnnuel
            // 
            this.txtTauxAnnuel.Location = new System.Drawing.Point(51, 242);
            this.txtTauxAnnuel.Name = "txtTauxAnnuel";
            this.txtTauxAnnuel.Size = new System.Drawing.Size(100, 26);
            this.txtTauxAnnuel.TabIndex = 10;
            // 
            // cbxDurée
            // 
            this.cbxDurée.FormattingEnabled = true;
            this.cbxDurée.ItemHeight = 20;
            this.cbxDurée.Location = new System.Drawing.Point(51, 145);
            this.cbxDurée.Name = "cbxDurée";
            this.cbxDurée.Size = new System.Drawing.Size(121, 28);
            this.cbxDurée.TabIndex = 9;
            this.cbxDurée.SelectedIndexChanged += new System.EventHandler(this.cbxDurée_SelectedIndexChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(471, 378);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(83, 44);
            this.btnRetour.TabIndex = 18;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontantFinnance);
            this.Controls.Add(this.txtMensualité);
            this.Controls.Add(this.txtTauxAnnuel);
            this.Controls.Add(this.cbxDurée);
            this.Name = "Credit";
            this.Text = "Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontantFinnance;
        private System.Windows.Forms.TextBox txtMensualité;
        private System.Windows.Forms.TextBox txtTauxAnnuel;
        private System.Windows.Forms.ComboBox cbxDurée;
        private System.Windows.Forms.Button btnRetour;
    }
}