
namespace GarageCreditCeleste
{
    partial class Accueil
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
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.rdbCivFemme = new System.Windows.Forms.RadioButton();
            this.rdbCivHomme = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnVendre = new System.Windows.Forms.Button();
            this.btnAcheter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(363, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Accueil";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnEnvoyer.Location = new System.Drawing.Point(602, 410);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(90, 30);
            this.btnEnvoyer.TabIndex = 27;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnregistrer);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.rdbCivFemme);
            this.groupBox1.Controls.Add(this.rdbCivHomme);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(15, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 350);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vos informations";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnEnregistrer.Location = new System.Drawing.Point(185, 305);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(90, 30);
            this.btnEnregistrer.TabIndex = 11;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtAdresse
            // 
            this.txtAdresse.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAdresse.Location = new System.Drawing.Point(78, 243);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(197, 24);
            this.txtAdresse.TabIndex = 20;
            this.txtAdresse.Text = "ex. 1 rue Marechal Foch";
            this.txtAdresse.Click += new System.EventHandler(this.txtAdresse_Click);
            // 
            // txtPrenom
            // 
            this.txtPrenom.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrenom.Location = new System.Drawing.Point(78, 143);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(197, 24);
            this.txtPrenom.TabIndex = 19;
            this.txtPrenom.Text = "ex. Jean";
            this.txtPrenom.Click += new System.EventHandler(this.txtPrenom_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmail.Location = new System.Drawing.Point(78, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 24);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Text = "ex. jean.dupont@email.fr";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtNom
            // 
            this.txtNom.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNom.Location = new System.Drawing.Point(78, 93);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(197, 24);
            this.txtNom.TabIndex = 17;
            this.txtNom.Text = "ex. Dupont";
            this.txtNom.Click += new System.EventHandler(this.txtNom_Click);
            // 
            // rdbCivFemme
            // 
            this.rdbCivFemme.AutoSize = true;
            this.rdbCivFemme.Location = new System.Drawing.Point(171, 44);
            this.rdbCivFemme.Name = "rdbCivFemme";
            this.rdbCivFemme.Size = new System.Drawing.Size(64, 22);
            this.rdbCivFemme.TabIndex = 16;
            this.rdbCivFemme.TabStop = true;
            this.rdbCivFemme.Text = "Mme.";
            this.rdbCivFemme.UseVisualStyleBackColor = true;
            // 
            // rdbCivHomme
            // 
            this.rdbCivHomme.AutoSize = true;
            this.rdbCivHomme.Location = new System.Drawing.Point(104, 44);
            this.rdbCivHomme.Name = "rdbCivHomme";
            this.rdbCivHomme.Size = new System.Drawing.Size(48, 22);
            this.rdbCivHomme.TabIndex = 15;
            this.rdbCivHomme.TabStop = true;
            this.rdbCivHomme.Text = "Mr.";
            this.rdbCivHomme.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Civilité";
            // 
            // btnServices
            // 
            this.btnServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnServices.Location = new System.Drawing.Point(627, 198);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(110, 50);
            this.btnServices.TabIndex = 25;
            this.btnServices.Text = "Nos services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnVendre
            // 
            this.btnVendre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnVendre.Location = new System.Drawing.Point(511, 198);
            this.btnVendre.Name = "btnVendre";
            this.btnVendre.Size = new System.Drawing.Size(110, 50);
            this.btnVendre.TabIndex = 24;
            this.btnVendre.Text = "Vendre votre véhicule";
            this.btnVendre.UseVisualStyleBackColor = true;
            this.btnVendre.Click += new System.EventHandler(this.btnVendre_Click);
            // 
            // btnAcheter
            // 
            this.btnAcheter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAcheter.Location = new System.Drawing.Point(395, 198);
            this.btnAcheter.Name = "btnAcheter";
            this.btnAcheter.Size = new System.Drawing.Size(110, 50);
            this.btnAcheter.TabIndex = 23;
            this.btnAcheter.Text = "Acheter un de nos véhicules";
            this.btnAcheter.UseVisualStyleBackColor = true;
            this.btnAcheter.Click += new System.EventHandler(this.btnAcheter_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnFermer.Location = new System.Drawing.Point(698, 410);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(90, 30);
            this.btnFermer.TabIndex = 22;
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
            this.label2.TabIndex = 21;
            this.label2.Text = "HDR Garage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Strasbourg";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnVendre);
            this.Controls.Add(this.btnAcheter);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.RadioButton rdbCivFemme;
        private System.Windows.Forms.RadioButton rdbCivHomme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnVendre;
        private System.Windows.Forms.Button btnAcheter;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}