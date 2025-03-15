
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
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblImmat = new System.Windows.Forms.Label();
            this.lblKilometrage = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblPuissance = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gpbDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(479, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Acheter";
            // 
            // gpbDescription
            // 
            this.gpbDescription.Controls.Add(this.label4);
            this.gpbDescription.Controls.Add(this.lblPrix);
            this.gpbDescription.Controls.Add(this.label5);
            this.gpbDescription.Controls.Add(this.label6);
            this.gpbDescription.Controls.Add(this.lblCouleur);
            this.gpbDescription.Controls.Add(this.label7);
            this.gpbDescription.Controls.Add(this.lblImmat);
            this.gpbDescription.Controls.Add(this.label9);
            this.gpbDescription.Controls.Add(this.lblKilometrage);
            this.gpbDescription.Controls.Add(this.label10);
            this.gpbDescription.Controls.Add(this.lblMarque);
            this.gpbDescription.Controls.Add(this.label11);
            this.gpbDescription.Controls.Add(this.lblAnnee);
            this.gpbDescription.Controls.Add(this.label12);
            this.gpbDescription.Controls.Add(this.lblPuissance);
            this.gpbDescription.Controls.Add(this.lblModele);
            this.gpbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.gpbDescription.Location = new System.Drawing.Point(393, 68);
            this.gpbDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDescription.Name = "gpbDescription";
            this.gpbDescription.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDescription.Size = new System.Drawing.Size(657, 416);
            this.gpbDescription.TabIndex = 28;
            this.gpbDescription.TabStop = false;
            this.gpbDescription.Text = "Description du véhicule";
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnFiltrer.Location = new System.Drawing.Point(292, 50);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(93, 31);
            this.btnFiltrer.TabIndex = 27;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Voitures disponibles";
            // 
            // lsbVoituresDispo
            // 
            this.lsbVoituresDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lsbVoituresDispo.FormattingEnabled = true;
            this.lsbVoituresDispo.ItemHeight = 24;
            this.lsbVoituresDispo.Location = new System.Drawing.Point(20, 80);
            this.lsbVoituresDispo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbVoituresDispo.Name = "lsbVoituresDispo";
            this.lsbVoituresDispo.Size = new System.Drawing.Size(364, 388);
            this.lsbVoituresDispo.TabIndex = 25;
            this.lsbVoituresDispo.SelectedIndexChanged += new System.EventHandler(this.lsbVoituresDispo_SelectedIndexChanged);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnChoisir.Location = new System.Drawing.Point(803, 505);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(120, 37);
            this.btnChoisir.TabIndex = 24;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnFermer.Location = new System.Drawing.Point(931, 505);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(120, 37);
            this.btnFermer.TabIndex = 23;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(931, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "HDR Garage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Strasbourg";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPrix.Location = new System.Drawing.Point(493, 278);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(42, 24);
            this.lblPrix.TabIndex = 61;
            this.lblPrix.Text = "Prix";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCouleur.Location = new System.Drawing.Point(493, 106);
            this.lblCouleur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(77, 24);
            this.lblCouleur.TabIndex = 58;
            this.lblCouleur.Text = "Couleur";
            // 
            // lblImmat
            // 
            this.lblImmat.AutoSize = true;
            this.lblImmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblImmat.Location = new System.Drawing.Point(493, 221);
            this.lblImmat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImmat.Name = "lblImmat";
            this.lblImmat.Size = new System.Drawing.Size(135, 24);
            this.lblImmat.TabIndex = 60;
            this.lblImmat.Text = "Immatriculation";
            // 
            // lblKilometrage
            // 
            this.lblKilometrage.AutoSize = true;
            this.lblKilometrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblKilometrage.Location = new System.Drawing.Point(167, 278);
            this.lblKilometrage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilometrage.Name = "lblKilometrage";
            this.lblKilometrage.Size = new System.Drawing.Size(110, 24);
            this.lblKilometrage.TabIndex = 57;
            this.lblKilometrage.Text = "Kilométrage";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMarque.Location = new System.Drawing.Point(167, 106);
            this.lblMarque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(75, 24);
            this.lblMarque.TabIndex = 54;
            this.lblMarque.Text = "Marque";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAnnee.Location = new System.Drawing.Point(167, 221);
            this.lblAnnee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(67, 24);
            this.lblAnnee.TabIndex = 56;
            this.lblAnnee.Text = "Année";
            // 
            // lblPuissance
            // 
            this.lblPuissance.AutoSize = true;
            this.lblPuissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPuissance.Location = new System.Drawing.Point(493, 168);
            this.lblPuissance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuissance.Name = "lblPuissance";
            this.lblPuissance.Size = new System.Drawing.Size(97, 24);
            this.lblPuissance.TabIndex = 59;
            this.lblPuissance.Text = "Puissance";
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblModele.Location = new System.Drawing.Point(167, 168);
            this.lblModele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(74, 24);
            this.lblModele.TabIndex = 55;
            this.lblModele.Text = "Modèle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(341, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "Prix :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(341, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "Couleur :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(341, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 68;
            this.label6.Text = "Immatriculation :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(42, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Kilométrage :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(42, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 24);
            this.label9.TabIndex = 62;
            this.label9.Text = "Marque :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(42, 221);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 64;
            this.label10.Text = "Année :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label11.Location = new System.Drawing.Point(341, 168);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 24);
            this.label11.TabIndex = 67;
            this.label11.Text = "Puissance :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label12.Location = new System.Drawing.Point(42, 168);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 24);
            this.label12.TabIndex = 63;
            this.label12.Text = "Modèle :";
            // 
            // Acheter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gpbDescription);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbVoituresDispo);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Acheter";
            this.Text = "Acheter";
            this.Load += new System.EventHandler(this.Acheter_Load);
            this.gpbDescription.ResumeLayout(false);
            this.gpbDescription.PerformLayout();
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
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblImmat;
        private System.Windows.Forms.Label lblKilometrage;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblPuissance;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}