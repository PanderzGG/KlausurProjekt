namespace SaschaKleinen
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbGeoQuiz = new Label();
            btnNeuesSpiel = new Button();
            btnHighscores = new Button();
            btnBeenden = new Button();
            SuspendLayout();
            // 
            // lbGeoQuiz
            // 
            lbGeoQuiz.AutoSize = true;
            lbGeoQuiz.Font = new Font("Segoe UI", 46F);
            lbGeoQuiz.Location = new Point(369, 20);
            lbGeoQuiz.Name = "lbGeoQuiz";
            lbGeoQuiz.Size = new Size(271, 84);
            lbGeoQuiz.TabIndex = 0;
            lbGeoQuiz.Text = "GeoQuiz";
            // 
            // btnNeuesSpiel
            // 
            btnNeuesSpiel.Font = new Font("Segoe UI", 27F);
            btnNeuesSpiel.Location = new Point(354, 171);
            btnNeuesSpiel.Name = "btnNeuesSpiel";
            btnNeuesSpiel.Size = new Size(300, 100);
            btnNeuesSpiel.TabIndex = 1;
            btnNeuesSpiel.Text = "Neues Spiel";
            btnNeuesSpiel.UseVisualStyleBackColor = true;
            btnNeuesSpiel.Click += btnNeuesSpiel_Click;
            // 
            // btnHighscores
            // 
            btnHighscores.Font = new Font("Segoe UI", 27F);
            btnHighscores.Location = new Point(354, 350);
            btnHighscores.Name = "btnHighscores";
            btnHighscores.Size = new Size(300, 100);
            btnHighscores.TabIndex = 2;
            btnHighscores.Text = "Highscores";
            btnHighscores.UseVisualStyleBackColor = true;
            // 
            // btnBeenden
            // 
            btnBeenden.Font = new Font("Segoe UI", 27F);
            btnBeenden.Location = new Point(354, 529);
            btnBeenden.Name = "btnBeenden";
            btnBeenden.Size = new Size(300, 100);
            btnBeenden.TabIndex = 3;
            btnBeenden.Text = "Beenden";
            btnBeenden.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(btnBeenden);
            Controls.Add(btnHighscores);
            Controls.Add(btnNeuesSpiel);
            Controls.Add(lbGeoQuiz);
            Name = "MainMenu";
            Text = "GeoQuiz Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbGeoQuiz;
        private Button btnNeuesSpiel;
        private Button btnHighscores;
        private Button btnBeenden;
    }
}
