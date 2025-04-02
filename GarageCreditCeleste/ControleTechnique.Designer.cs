
namespace GarageCreditCeleste
{
    partial class ControleTechnique
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cboHeureCT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateHeureRDV = new System.Windows.Forms.Label();
            this.calControleTechnique = new System.Windows.Forms.MonthCalendar();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblImmat = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblKilometrage = new System.Windows.Forms.Label();
            this.lblPuissance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnEnregistrer.Location = new System.Drawing.Point(602, 409);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(90, 30);
            this.btnEnregistrer.TabIndex = 64;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(112, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "Heure :";
            // 
            // cboHeureCT
            // 
            this.cboHeureCT.FormattingEnabled = true;
            this.cboHeureCT.Location = new System.Drawing.Point(173, 202);
            this.cboHeureCT.Name = "cboHeureCT";
            this.cboHeureCT.Size = new System.Drawing.Size(124, 25);
            this.cboHeureCT.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cboHeureCT);
            this.groupBox2.Controls.Add(this.lblDateHeureRDV);
            this.groupBox2.Controls.Add(this.calControleTechnique);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(395, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 351);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date du contrôle technique";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.Location = new System.Drawing.Point(20, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 65;
            this.button1.Text = "Valider date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(17, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Prix du CT : 80€";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDateHeureRDV
            // 
            this.lblDateHeureRDV.AutoSize = true;
            this.lblDateHeureRDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDateHeureRDV.Location = new System.Drawing.Point(17, 245);
            this.lblDateHeureRDV.Name = "lblDateHeureRDV";
            this.lblDateHeureRDV.Size = new System.Drawing.Size(210, 17);
            this.lblDateHeureRDV.TabIndex = 46;
            this.lblDateHeureRDV.Text = "Date et heure du rendez-vous : ";
            // 
            // calControleTechnique
            // 
            this.calControleTechnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.calControleTechnique.Location = new System.Drawing.Point(92, 28);
            this.calControleTechnique.Name = "calControleTechnique";
            this.calControleTechnique.TabIndex = 55;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCouleur.Location = new System.Drawing.Point(36, 236);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(69, 17);
            this.lblCouleur.TabIndex = 38;
            this.lblCouleur.Text = "Couleur : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblImmat);
            this.groupBox1.Controls.Add(this.lblMarque);
            this.groupBox1.Controls.Add(this.lblModele);
            this.groupBox1.Controls.Add(this.lblAnnee);
            this.groupBox1.Controls.Add(this.lblKilometrage);
            this.groupBox1.Controls.Add(this.lblPuissance);
            this.groupBox1.Controls.Add(this.lblCouleur);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 387);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du véhicule";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblImmat
            // 
            this.lblImmat.AutoSize = true;
            this.lblImmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblImmat.Location = new System.Drawing.Point(36, 336);
            this.lblImmat.Name = "lblImmat";
            this.lblImmat.Size = new System.Drawing.Size(110, 17);
            this.lblImmat.TabIndex = 45;
            this.lblImmat.Text = "Immatriculation :";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblMarque.Location = new System.Drawing.Point(36, 39);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(64, 17);
            this.lblMarque.TabIndex = 30;
            this.lblMarque.Text = "Marque :";
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblModele.Location = new System.Drawing.Point(36, 89);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(62, 17);
            this.lblModele.TabIndex = 31;
            this.lblModele.Text = "Modèle :";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAnnee.Location = new System.Drawing.Point(36, 139);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(61, 17);
            this.lblAnnee.TabIndex = 32;
            this.lblAnnee.Text = "Année : ";
            // 
            // lblKilometrage
            // 
            this.lblKilometrage.AutoSize = true;
            this.lblKilometrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblKilometrage.Location = new System.Drawing.Point(36, 189);
            this.lblKilometrage.Name = "lblKilometrage";
            this.lblKilometrage.Size = new System.Drawing.Size(95, 17);
            this.lblKilometrage.TabIndex = 33;
            this.lblKilometrage.Text = "Kilométrage : ";
            // 
            // lblPuissance
            // 
            this.lblPuissance.AutoSize = true;
            this.lblPuissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPuissance.Location = new System.Drawing.Point(36, 286);
            this.lblPuissance.Name = "lblPuissance";
            this.lblPuissance.Size = new System.Drawing.Size(81, 17);
            this.lblPuissance.TabIndex = 39;
            this.lblPuissance.Text = "Puissance :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(332, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Contrôle technique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(698, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "HDR Garage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Strasbourg";
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnFermer.Location = new System.Drawing.Point(698, 409);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(90, 30);
            this.btnFermer.TabIndex = 61;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // ControleTechnique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Name = "ControleTechnique";
            this.Text = "ControleTechnique";
            this.Load += new System.EventHandler(this.ControleTechnique_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboHeureCT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDateHeureRDV;
        private System.Windows.Forms.MonthCalendar calControleTechnique;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblImmat;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblKilometrage;
        private System.Windows.Forms.Label lblPuissance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}