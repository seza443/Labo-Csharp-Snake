namespace snake
{
    partial class FenetrePrincipale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            this.panneauPrincipal = new System.Windows.Forms.Panel();
            this.panneauGameOver = new System.Windows.Forms.Panel();
            this.labelPerduScore = new System.Windows.Forms.Label();
            this.labelEtiquettePerduScore = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.panneauDifficulte = new System.Windows.Forms.Panel();
            this.labelDifficulte = new System.Windows.Forms.Label();
            this.curseurDifficulte = new System.Windows.Forms.TrackBar();
            this.panneauPause = new System.Windows.Forms.Panel();
            this.bouttonReprendre = new System.Windows.Forms.Button();
            this.labelPause = new System.Windows.Forms.Label();
            this.panneauTitre = new System.Windows.Forms.Panel();
            this.zoneTexteNomJoueur = new System.Windows.Forms.TextBox();
            this.labelNomJoueur = new System.Windows.Forms.Label();
            this.labelExplication = new System.Windows.Forms.Label();
            this.boutonJouer = new System.Windows.Forms.Button();
            this.labelTitreSnake = new System.Windows.Forms.Label();
            this.panneauScore = new System.Windows.Forms.Panel();
            this.labelDifficulteAffiche = new System.Windows.Forms.Label();
            this.labelEtiquetteDifficulte = new System.Windows.Forms.Label();
            this.labelFruits = new System.Windows.Forms.Label();
            this.labelEtiquetteFruits = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelEtiquetteScore = new System.Windows.Forms.Label();
            this.labelJoueur = new System.Windows.Forms.Label();
            this.panneauJeu = new System.Windows.Forms.Panel();
            this.iconeBarreTaches = new System.Windows.Forms.NotifyIcon(this.components);
            this.panneauPrincipal.SuspendLayout();
            this.panneauGameOver.SuspendLayout();
            this.panneauDifficulte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curseurDifficulte)).BeginInit();
            this.panneauPause.SuspendLayout();
            this.panneauTitre.SuspendLayout();
            this.panneauScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // panneauPrincipal
            // 
            this.panneauPrincipal.BackColor = System.Drawing.Color.YellowGreen;
            this.panneauPrincipal.Controls.Add(this.panneauGameOver);
            this.panneauPrincipal.Controls.Add(this.panneauDifficulte);
            this.panneauPrincipal.Controls.Add(this.panneauPause);
            this.panneauPrincipal.Controls.Add(this.panneauTitre);
            this.panneauPrincipal.Controls.Add(this.labelTitreSnake);
            this.panneauPrincipal.Controls.Add(this.panneauScore);
            this.panneauPrincipal.Controls.Add(this.panneauJeu);
            this.panneauPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panneauPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panneauPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.panneauPrincipal.Name = "panneauPrincipal";
            this.panneauPrincipal.Size = new System.Drawing.Size(512, 410);
            this.panneauPrincipal.TabIndex = 0;
            // 
            // panneauGameOver
            // 
            this.panneauGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panneauGameOver.Controls.Add(this.labelPerduScore);
            this.panneauGameOver.Controls.Add(this.labelEtiquettePerduScore);
            this.panneauGameOver.Controls.Add(this.labelGameOver);
            this.panneauGameOver.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panneauGameOver.Location = new System.Drawing.Point(103, 116);
            this.panneauGameOver.Name = "panneauGameOver";
            this.panneauGameOver.Size = new System.Drawing.Size(303, 146);
            this.panneauGameOver.TabIndex = 0;
            // 
            // labelPerduScore
            // 
            this.labelPerduScore.AutoSize = true;
            this.labelPerduScore.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerduScore.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelPerduScore.Location = new System.Drawing.Point(174, 77);
            this.labelPerduScore.Name = "labelPerduScore";
            this.labelPerduScore.Size = new System.Drawing.Size(22, 23);
            this.labelPerduScore.TabIndex = 2;
            this.labelPerduScore.Text = "0";
            // 
            // labelEtiquettePerduScore
            // 
            this.labelEtiquettePerduScore.AutoSize = true;
            this.labelEtiquettePerduScore.Font = new System.Drawing.Font("OCR A Extended", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtiquettePerduScore.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelEtiquettePerduScore.Location = new System.Drawing.Point(16, 77);
            this.labelEtiquettePerduScore.Name = "labelEtiquettePerduScore";
            this.labelEtiquettePerduScore.Size = new System.Drawing.Size(152, 20);
            this.labelEtiquettePerduScore.TabIndex = 1;
            this.labelEtiquettePerduScore.Text = "Votre Score :";
            // 
            // labelGameOver
            // 
            this.labelGameOver.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelGameOver.Location = new System.Drawing.Point(17, 3);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(272, 41);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "Vous avez perdu. Dommage! N\'hésiter pas à rejouer. ;)";
            // 
            // panneauDifficulte
            // 
            this.panneauDifficulte.BackColor = System.Drawing.Color.Transparent;
            this.panneauDifficulte.Controls.Add(this.labelDifficulte);
            this.panneauDifficulte.Controls.Add(this.curseurDifficulte);
            this.panneauDifficulte.Location = new System.Drawing.Point(110, 185);
            this.panneauDifficulte.Name = "panneauDifficulte";
            this.panneauDifficulte.Size = new System.Drawing.Size(273, 20);
            this.panneauDifficulte.TabIndex = 0;
            // 
            // labelDifficulte
            // 
            this.labelDifficulte.AutoSize = true;
            this.labelDifficulte.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulte.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelDifficulte.Location = new System.Drawing.Point(4, 0);
            this.labelDifficulte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDifficulte.Name = "labelDifficulte";
            this.labelDifficulte.Size = new System.Drawing.Size(103, 15);
            this.labelDifficulte.TabIndex = 4;
            this.labelDifficulte.Text = "Difficulté :";
            // 
            // curseurDifficulte
            // 
            this.curseurDifficulte.AutoSize = false;
            this.curseurDifficulte.BackColor = System.Drawing.Color.YellowGreen;
            this.curseurDifficulte.LargeChange = 1;
            this.curseurDifficulte.Location = new System.Drawing.Point(115, 0);
            this.curseurDifficulte.Margin = new System.Windows.Forms.Padding(4);
            this.curseurDifficulte.Minimum = 1;
            this.curseurDifficulte.Name = "curseurDifficulte";
            this.curseurDifficulte.Size = new System.Drawing.Size(139, 25);
            this.curseurDifficulte.TabIndex = 5;
            this.curseurDifficulte.Value = 1;
            this.curseurDifficulte.ValueChanged += new System.EventHandler(this.curseurDifficulte_ValueChanged);
            // 
            // panneauPause
            // 
            this.panneauPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panneauPause.Controls.Add(this.bouttonReprendre);
            this.panneauPause.Controls.Add(this.labelPause);
            this.panneauPause.Location = new System.Drawing.Point(104, 117);
            this.panneauPause.Margin = new System.Windows.Forms.Padding(4);
            this.panneauPause.Name = "panneauPause";
            this.panneauPause.Size = new System.Drawing.Size(302, 145);
            this.panneauPause.TabIndex = 0;
            this.panneauPause.Visible = false;
            // 
            // bouttonReprendre
            // 
            this.bouttonReprendre.Image = global::snake.Properties.Resources.play;
            this.bouttonReprendre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bouttonReprendre.Location = new System.Drawing.Point(51, 99);
            this.bouttonReprendre.Name = "bouttonReprendre";
            this.bouttonReprendre.Size = new System.Drawing.Size(189, 38);
            this.bouttonReprendre.TabIndex = 1;
            this.bouttonReprendre.Text = "Reprendre";
            this.bouttonReprendre.UseVisualStyleBackColor = true;
            this.bouttonReprendre.Click += new System.EventHandler(this.bouttonReprendre_Click);
            // 
            // labelPause
            // 
            this.labelPause.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPause.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelPause.Location = new System.Drawing.Point(3, 2);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(285, 35);
            this.labelPause.TabIndex = 0;
            this.labelPause.Text = "Jeu en pause. Vous pouvez modifier la difficulté ci dessous.";
            // 
            // panneauTitre
            // 
            this.panneauTitre.BackColor = System.Drawing.Color.Transparent;
            this.panneauTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panneauTitre.Controls.Add(this.zoneTexteNomJoueur);
            this.panneauTitre.Controls.Add(this.labelNomJoueur);
            this.panneauTitre.Controls.Add(this.labelExplication);
            this.panneauTitre.Controls.Add(this.boutonJouer);
            this.panneauTitre.Location = new System.Drawing.Point(104, 117);
            this.panneauTitre.Margin = new System.Windows.Forms.Padding(4);
            this.panneauTitre.Name = "panneauTitre";
            this.panneauTitre.Size = new System.Drawing.Size(302, 145);
            this.panneauTitre.TabIndex = 0;
            this.panneauTitre.Visible = false;
            // 
            // zoneTexteNomJoueur
            // 
            this.zoneTexteNomJoueur.BackColor = System.Drawing.Color.YellowGreen;
            this.zoneTexteNomJoueur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoneTexteNomJoueur.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneTexteNomJoueur.ForeColor = System.Drawing.Color.DarkMagenta;
            this.zoneTexteNomJoueur.Location = new System.Drawing.Point(128, 34);
            this.zoneTexteNomJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.zoneTexteNomJoueur.Name = "zoneTexteNomJoueur";
            this.zoneTexteNomJoueur.Size = new System.Drawing.Size(133, 22);
            this.zoneTexteNomJoueur.TabIndex = 3;
            this.zoneTexteNomJoueur.Text = "Joueur1";
            // 
            // labelNomJoueur
            // 
            this.labelNomJoueur.AutoSize = true;
            this.labelNomJoueur.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomJoueur.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelNomJoueur.Location = new System.Drawing.Point(67, 37);
            this.labelNomJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomJoueur.Name = "labelNomJoueur";
            this.labelNomJoueur.Size = new System.Drawing.Size(47, 15);
            this.labelNomJoueur.TabIndex = 2;
            this.labelNomJoueur.Text = "Nom :";
            // 
            // labelExplication
            // 
            this.labelExplication.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExplication.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelExplication.Location = new System.Drawing.Point(4, 0);
            this.labelExplication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExplication.Name = "labelExplication";
            this.labelExplication.Size = new System.Drawing.Size(297, 37);
            this.labelExplication.TabIndex = 1;
            this.labelExplication.Text = "Entrez votre nom et choissisez votre difficulté :";
            // 
            // boutonJouer
            // 
            this.boutonJouer.BackColor = System.Drawing.Color.Transparent;
            this.boutonJouer.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonJouer.Image = global::snake.Properties.Resources.play;
            this.boutonJouer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonJouer.Location = new System.Drawing.Point(65, 97);
            this.boutonJouer.Margin = new System.Windows.Forms.Padding(4);
            this.boutonJouer.Name = "boutonJouer";
            this.boutonJouer.Size = new System.Drawing.Size(175, 42);
            this.boutonJouer.TabIndex = 0;
            this.boutonJouer.Text = "Jouer!";
            this.boutonJouer.UseVisualStyleBackColor = false;
            this.boutonJouer.Click += new System.EventHandler(this.boutonJouer_Click);
            // 
            // labelTitreSnake
            // 
            this.labelTitreSnake.BackColor = System.Drawing.Color.Transparent;
            this.labelTitreSnake.CausesValidation = false;
            this.labelTitreSnake.Font = new System.Drawing.Font("OCR A Extended", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreSnake.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelTitreSnake.Location = new System.Drawing.Point(100, 8);
            this.labelTitreSnake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitreSnake.Name = "labelTitreSnake";
            this.labelTitreSnake.Size = new System.Drawing.Size(307, 162);
            this.labelTitreSnake.TabIndex = 0;
            this.labelTitreSnake.Text = "Snake";
            // 
            // panneauScore
            // 
            this.panneauScore.BackColor = System.Drawing.Color.DarkKhaki;
            this.panneauScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panneauScore.Controls.Add(this.labelDifficulteAffiche);
            this.panneauScore.Controls.Add(this.labelEtiquetteDifficulte);
            this.panneauScore.Controls.Add(this.labelFruits);
            this.panneauScore.Controls.Add(this.labelEtiquetteFruits);
            this.panneauScore.Controls.Add(this.labelScore);
            this.panneauScore.Controls.Add(this.labelEtiquetteScore);
            this.panneauScore.Controls.Add(this.labelJoueur);
            this.panneauScore.Location = new System.Drawing.Point(0, 384);
            this.panneauScore.Name = "panneauScore";
            this.panneauScore.Size = new System.Drawing.Size(512, 26);
            this.panneauScore.TabIndex = 0;
            // 
            // labelDifficulteAffiche
            // 
            this.labelDifficulteAffiche.AutoSize = true;
            this.labelDifficulteAffiche.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulteAffiche.Location = new System.Drawing.Point(485, 6);
            this.labelDifficulteAffiche.Name = "labelDifficulteAffiche";
            this.labelDifficulteAffiche.Size = new System.Drawing.Size(15, 15);
            this.labelDifficulteAffiche.TabIndex = 6;
            this.labelDifficulteAffiche.Text = "1";
            // 
            // labelEtiquetteDifficulte
            // 
            this.labelEtiquetteDifficulte.AutoSize = true;
            this.labelEtiquetteDifficulte.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtiquetteDifficulte.Location = new System.Drawing.Point(376, 6);
            this.labelEtiquetteDifficulte.Name = "labelEtiquetteDifficulte";
            this.labelEtiquetteDifficulte.Size = new System.Drawing.Size(103, 15);
            this.labelEtiquetteDifficulte.TabIndex = 5;
            this.labelEtiquetteDifficulte.Text = "Difficulté :";
            // 
            // labelFruits
            // 
            this.labelFruits.AutoSize = true;
            this.labelFruits.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFruits.Location = new System.Drawing.Point(339, 6);
            this.labelFruits.Name = "labelFruits";
            this.labelFruits.Size = new System.Drawing.Size(15, 15);
            this.labelFruits.TabIndex = 4;
            this.labelFruits.Text = "0";
            // 
            // labelEtiquetteFruits
            // 
            this.labelEtiquetteFruits.AutoSize = true;
            this.labelEtiquetteFruits.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtiquetteFruits.Location = new System.Drawing.Point(206, 6);
            this.labelEtiquetteFruits.Name = "labelEtiquetteFruits";
            this.labelEtiquetteFruits.Size = new System.Drawing.Size(127, 15);
            this.labelEtiquetteFruits.TabIndex = 3;
            this.labelEtiquetteFruits.Text = "Fruits mangés :";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(153, 6);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(15, 15);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            // 
            // labelEtiquetteScore
            // 
            this.labelEtiquetteScore.AutoSize = true;
            this.labelEtiquetteScore.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtiquetteScore.Location = new System.Drawing.Point(90, 6);
            this.labelEtiquetteScore.Name = "labelEtiquetteScore";
            this.labelEtiquetteScore.Size = new System.Drawing.Size(71, 15);
            this.labelEtiquetteScore.TabIndex = 1;
            this.labelEtiquetteScore.Text = "Score : ";
            // 
            // labelJoueur
            // 
            this.labelJoueur.AutoSize = true;
            this.labelJoueur.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJoueur.Location = new System.Drawing.Point(3, 4);
            this.labelJoueur.Name = "labelJoueur";
            this.labelJoueur.Size = new System.Drawing.Size(71, 17);
            this.labelJoueur.TabIndex = 0;
            this.labelJoueur.Text = "Joueur1";
            // 
            // panneauJeu
            // 
            this.panneauJeu.BackColor = System.Drawing.Color.Transparent;
            this.panneauJeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panneauJeu.Location = new System.Drawing.Point(0, 0);
            this.panneauJeu.Margin = new System.Windows.Forms.Padding(4);
            this.panneauJeu.Name = "panneauJeu";
            this.panneauJeu.Size = new System.Drawing.Size(512, 384);
            this.panneauJeu.TabIndex = 1;
            this.panneauJeu.Visible = false;
            // 
            // iconeBarreTaches
            // 
            this.iconeBarreTaches.Icon = ((System.Drawing.Icon)(resources.GetObject("iconeBarreTaches.Icon")));
            this.iconeBarreTaches.Text = "Snake - Atelier 3";
            this.iconeBarreTaches.Visible = true;
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 410);
            this.Controls.Add(this.panneauPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Atelier 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FenetrePrincipale_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FenetrePrincipale_KeyDown);
            this.panneauPrincipal.ResumeLayout(false);
            this.panneauGameOver.ResumeLayout(false);
            this.panneauGameOver.PerformLayout();
            this.panneauDifficulte.ResumeLayout(false);
            this.panneauDifficulte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curseurDifficulte)).EndInit();
            this.panneauPause.ResumeLayout(false);
            this.panneauTitre.ResumeLayout(false);
            this.panneauTitre.PerformLayout();
            this.panneauScore.ResumeLayout(false);
            this.panneauScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panneauPrincipal;
        private System.Windows.Forms.Panel panneauTitre;
        private System.Windows.Forms.Button boutonJouer;
        private System.Windows.Forms.TrackBar curseurDifficulte;
        private System.Windows.Forms.Label labelDifficulte;
        private System.Windows.Forms.TextBox zoneTexteNomJoueur;
        private System.Windows.Forms.Label labelNomJoueur;
        private System.Windows.Forms.Label labelExplication;
        private System.Windows.Forms.NotifyIcon iconeBarreTaches;
        private System.Windows.Forms.Panel panneauJeu;
        private System.Windows.Forms.Label labelTitreSnake;
        private System.Windows.Forms.Panel panneauPause;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Panel panneauDifficulte;
        private System.Windows.Forms.Button bouttonReprendre;
        private System.Windows.Forms.Panel panneauScore;
        private System.Windows.Forms.Label labelDifficulteAffiche;
        private System.Windows.Forms.Label labelEtiquetteDifficulte;
        private System.Windows.Forms.Label labelFruits;
        private System.Windows.Forms.Label labelEtiquetteFruits;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelEtiquetteScore;
        private System.Windows.Forms.Label labelJoueur;
        private System.Windows.Forms.Panel panneauGameOver;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelPerduScore;
        private System.Windows.Forms.Label labelEtiquettePerduScore;
    }
}

