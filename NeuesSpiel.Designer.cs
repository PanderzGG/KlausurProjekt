namespace SaschaKleinen
{
    partial class NeuesSpiel
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
            tabControlNeuesSpiel = new TabControl();
            tabPageNeuesSpiel = new TabPage();
            btnVorhandenerSpieler = new Button();
            btnNeuerSpieler = new Button();
            lbNeuerSpieler = new Label();
            lbNeuesSpiel = new Label();
            tabPageNeuerSpieler = new TabPage();
            btnSpielerNeuSpielen = new Button();
            tbBenutzername = new TextBox();
            lbSpielerName = new Label();
            tabPageVorhandenerSpieler = new TabPage();
            btnSpielerVorhandenSpielen = new Button();
            cbBenutzernamen = new ComboBox();
            lbSpieler = new Label();
            tabControlNeuesSpiel.SuspendLayout();
            tabPageNeuesSpiel.SuspendLayout();
            tabPageNeuerSpieler.SuspendLayout();
            tabPageVorhandenerSpieler.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlNeuesSpiel
            // 
            tabControlNeuesSpiel.Controls.Add(tabPageNeuesSpiel);
            tabControlNeuesSpiel.Controls.Add(tabPageNeuerSpieler);
            tabControlNeuesSpiel.Controls.Add(tabPageVorhandenerSpieler);
            tabControlNeuesSpiel.Location = new Point(12, 12);
            tabControlNeuesSpiel.Name = "tabControlNeuesSpiel";
            tabControlNeuesSpiel.SelectedIndex = 0;
            tabControlNeuesSpiel.Size = new Size(984, 657);
            tabControlNeuesSpiel.TabIndex = 0;
            tabControlNeuesSpiel.SelectedIndexChanged += tabControlNeuesSpiel_SelectedIndexChanged;
            // 
            // tabPageNeuesSpiel
            // 
            tabPageNeuesSpiel.Controls.Add(btnVorhandenerSpieler);
            tabPageNeuesSpiel.Controls.Add(btnNeuerSpieler);
            tabPageNeuesSpiel.Controls.Add(lbNeuerSpieler);
            tabPageNeuesSpiel.Controls.Add(lbNeuesSpiel);
            tabPageNeuesSpiel.Location = new Point(4, 24);
            tabPageNeuesSpiel.Name = "tabPageNeuesSpiel";
            tabPageNeuesSpiel.Padding = new Padding(3);
            tabPageNeuesSpiel.Size = new Size(976, 629);
            tabPageNeuesSpiel.TabIndex = 0;
            tabPageNeuesSpiel.Text = "Neues Spiel";
            tabPageNeuesSpiel.UseVisualStyleBackColor = true;
            // 
            // btnVorhandenerSpieler
            // 
            btnVorhandenerSpieler.Location = new Point(524, 346);
            btnVorhandenerSpieler.Name = "btnVorhandenerSpieler";
            btnVorhandenerSpieler.Size = new Size(150, 50);
            btnVorhandenerSpieler.TabIndex = 3;
            btnVorhandenerSpieler.Text = "Vorhandener Spieler";
            btnVorhandenerSpieler.UseVisualStyleBackColor = true;
            btnVorhandenerSpieler.Click += btnVorhandenerSpieler_Click;
            // 
            // btnNeuerSpieler
            // 
            btnNeuerSpieler.Location = new Point(302, 346);
            btnNeuerSpieler.Name = "btnNeuerSpieler";
            btnNeuerSpieler.Size = new Size(150, 50);
            btnNeuerSpieler.TabIndex = 2;
            btnNeuerSpieler.Text = "Neuer Spieler";
            btnNeuerSpieler.UseVisualStyleBackColor = true;
            btnNeuerSpieler.Click += btnNeuerSpieler_Click;
            // 
            // lbNeuerSpieler
            // 
            lbNeuerSpieler.AutoSize = true;
            lbNeuerSpieler.Font = new Font("Segoe UI", 18F);
            lbNeuerSpieler.Location = new Point(322, 218);
            lbNeuerSpieler.Name = "lbNeuerSpieler";
            lbNeuerSpieler.Size = new Size(332, 32);
            lbNeuerSpieler.TabIndex = 1;
            lbNeuerSpieler.Text = "Einen neuen Spieler anlegen?";
            // 
            // lbNeuesSpiel
            // 
            lbNeuesSpiel.AutoSize = true;
            lbNeuesSpiel.Font = new Font("Segoe UI", 46F);
            lbNeuesSpiel.Location = new Point(311, 78);
            lbNeuesSpiel.Name = "lbNeuesSpiel";
            lbNeuesSpiel.Size = new Size(354, 84);
            lbNeuesSpiel.TabIndex = 0;
            lbNeuesSpiel.Text = "Neues Spiel";
            // 
            // tabPageNeuerSpieler
            // 
            tabPageNeuerSpieler.Controls.Add(btnSpielerNeuSpielen);
            tabPageNeuerSpieler.Controls.Add(tbBenutzername);
            tabPageNeuerSpieler.Controls.Add(lbSpielerName);
            tabPageNeuerSpieler.Location = new Point(4, 24);
            tabPageNeuerSpieler.Name = "tabPageNeuerSpieler";
            tabPageNeuerSpieler.Padding = new Padding(3);
            tabPageNeuerSpieler.Size = new Size(976, 629);
            tabPageNeuerSpieler.TabIndex = 1;
            tabPageNeuerSpieler.Text = "Neuer Spieler";
            tabPageNeuerSpieler.UseVisualStyleBackColor = true;
            // 
            // btnSpielerNeuSpielen
            // 
            btnSpielerNeuSpielen.Font = new Font("Segoe UI", 18F);
            btnSpielerNeuSpielen.Location = new Point(643, 231);
            btnSpielerNeuSpielen.Name = "btnSpielerNeuSpielen";
            btnSpielerNeuSpielen.Size = new Size(150, 50);
            btnSpielerNeuSpielen.TabIndex = 2;
            btnSpielerNeuSpielen.Text = "Spielen";
            btnSpielerNeuSpielen.UseVisualStyleBackColor = true;
            btnSpielerNeuSpielen.Click += btnSpielerNeuSpielen_Click;
            // 
            // tbBenutzername
            // 
            tbBenutzername.Font = new Font("Segoe UI", 36F);
            tbBenutzername.Location = new Point(501, 106);
            tbBenutzername.Name = "tbBenutzername";
            tbBenutzername.Size = new Size(292, 71);
            tbBenutzername.TabIndex = 1;
            // 
            // lbSpielerName
            // 
            lbSpielerName.AutoSize = true;
            lbSpielerName.Font = new Font("Segoe UI", 46F);
            lbSpielerName.Location = new Point(54, 93);
            lbSpielerName.Name = "lbSpielerName";
            lbSpielerName.Size = new Size(441, 84);
            lbSpielerName.TabIndex = 0;
            lbSpielerName.Text = "Benutzername:";
            // 
            // tabPageVorhandenerSpieler
            // 
            tabPageVorhandenerSpieler.Controls.Add(btnSpielerVorhandenSpielen);
            tabPageVorhandenerSpieler.Controls.Add(cbBenutzernamen);
            tabPageVorhandenerSpieler.Controls.Add(lbSpieler);
            tabPageVorhandenerSpieler.Location = new Point(4, 24);
            tabPageVorhandenerSpieler.Name = "tabPageVorhandenerSpieler";
            tabPageVorhandenerSpieler.Padding = new Padding(3);
            tabPageVorhandenerSpieler.Size = new Size(976, 629);
            tabPageVorhandenerSpieler.TabIndex = 2;
            tabPageVorhandenerSpieler.Text = "Spieler Auswählen";
            tabPageVorhandenerSpieler.UseVisualStyleBackColor = true;
            // 
            // btnSpielerVorhandenSpielen
            // 
            btnSpielerVorhandenSpielen.Font = new Font("Segoe UI", 18F);
            btnSpielerVorhandenSpielen.Location = new Point(449, 198);
            btnSpielerVorhandenSpielen.Name = "btnSpielerVorhandenSpielen";
            btnSpielerVorhandenSpielen.Size = new Size(150, 50);
            btnSpielerVorhandenSpielen.TabIndex = 2;
            btnSpielerVorhandenSpielen.Text = "Spielen";
            btnSpielerVorhandenSpielen.UseVisualStyleBackColor = true;
            btnSpielerVorhandenSpielen.Click += btnSpielerNeuSpielen_Click;
            // 
            // cbBenutzernamen
            // 
            cbBenutzernamen.Font = new Font("Segoe UI", 36F);
            cbBenutzernamen.FormattingEnabled = true;
            cbBenutzernamen.Location = new Point(346, 94);
            cbBenutzernamen.Name = "cbBenutzernamen";
            cbBenutzernamen.Size = new Size(529, 73);
            cbBenutzernamen.TabIndex = 1;
            // 
            // lbSpieler
            // 
            lbSpieler.AutoSize = true;
            lbSpieler.Font = new Font("Segoe UI", 46F);
            lbSpieler.Location = new Point(107, 83);
            lbSpieler.Name = "lbSpieler";
            lbSpieler.Size = new Size(233, 84);
            lbSpieler.TabIndex = 0;
            lbSpieler.Text = "Spieler:";
            // 
            // NeuesSpiel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(tabControlNeuesSpiel);
            Name = "NeuesSpiel";
            Text = "NeuesSpiel";
            tabControlNeuesSpiel.ResumeLayout(false);
            tabPageNeuesSpiel.ResumeLayout(false);
            tabPageNeuesSpiel.PerformLayout();
            tabPageNeuerSpieler.ResumeLayout(false);
            tabPageNeuerSpieler.PerformLayout();
            tabPageVorhandenerSpieler.ResumeLayout(false);
            tabPageVorhandenerSpieler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlNeuesSpiel;
        private TabPage tabPageNeuesSpiel;
        private Label lbNeuerSpieler;
        private Label lbNeuesSpiel;
        private TabPage tabPageNeuerSpieler;
        private Button btnVorhandenerSpieler;
        private Button btnNeuerSpieler;
        private TabPage tabPageVorhandenerSpieler;
        private Label lbSpielerName;
        private Button btnSpielerNeuSpielen;
        private TextBox tbBenutzername;
        private Label lbSpieler;
        private Button btnSpielerVorhandenSpielen;
        private ComboBox cbBenutzernamen;
    }
}