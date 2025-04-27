
namespace GarageCreditCeleste
{
    partial class Demarrage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDemarrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDemarrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemarrer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemarrer.Location = new System.Drawing.Point(561, 80);
            this.btnDemarrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(135, 58);
            this.btnDemarrer.TabIndex = 20;
            this.btnDemarrer.Text = "Démarrer";
            this.btnDemarrer.UseVisualStyleBackColor = false;
            this.btnDemarrer.Click += new System.EventHandler(this.btnDemarrer_Click);
            // 
            // Demarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::GarageCreditCeleste.Properties.Resources.garage;
            this.ClientSize = new System.Drawing.Size(778, 521);
            this.Controls.Add(this.btnDemarrer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Demarrage";
            this.Text = "Demarrage";
            this.Load += new System.EventHandler(this.Demarrage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemarrer;
    }
}

