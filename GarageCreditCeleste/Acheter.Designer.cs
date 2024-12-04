
namespace GarageCreditCeleste
{
    partial class Acheter
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
            this.gpbDescription = new System.Windows.Forms.GroupBox();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbVoituresDispo = new System.Windows.Forms.ListBox();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(359, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Acheter";
            // 
            // gpbDescription
            // 
            this.gpbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.gpbDescription.Location = new System.Drawing.Point(295, 55);
            this.gpbDescription.Name = "gpbDescription";
            this.gpbDescription.Size = new System.Drawing.Size(493, 338);
            this.gpbDescription.TabIndex = 28;
            this.gpbDescription.TabStop = false;
            this.gpbDescription.Text = "Description du véhicule";
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnFiltrer.Location = new System.Drawing.Point(219, 41);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(70, 25);
            this.btnFiltrer.TabIndex = 27;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Voitures disponibles";
            // 
            // lsbVoituresDispo
            // 
            this.lsbVoituresDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lsbVoituresDispo.FormattingEnabled = true;
            this.lsbVoituresDispo.ItemHeight = 18;
            this.lsbVoituresDispo.Location = new System.Drawing.Point(15, 65);
            this.lsbVoituresDispo.Name = "lsbVoituresDispo";
            this.lsbVoituresDispo.Size = new System.Drawing.Size(274, 328);
            this.lsbVoituresDispo.TabIndex = 25;
            // 
            // btnChoisir
            // 
            this.btnChoisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnChoisir.Location = new System.Drawing.Point(602, 410);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(90, 30);
            this.btnChoisir.TabIndex = 24;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnFermer.Location = new System.Drawing.Point(698, 410);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(90, 30);
            this.btnFermer.TabIndex = 23;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(698, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "HDR Garage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Strasbourg";
            // 
            // Acheter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gpbDescription);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbVoituresDispo);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Acheter";
            this.Text = "Acheter";
            this.Load += new System.EventHandler(this.Acheter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpbDescription;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsbVoituresDispo;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}