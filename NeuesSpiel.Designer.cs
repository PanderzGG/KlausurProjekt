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
            tabControlNeuesSpiel.Location = new Point(12, 10);
            tabControlNeuesSpiel.Name = "tabControlNeuesSpiel";
            tabControlNeuesSpiel.SelectedIndex = 0;
            tabControlNeuesSpiel.Size = new Size(680, 550);
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
            tabPageNeuesSpiel.Size = new Size(672, 522);
            tabPageNeuesSpiel.TabIndex = 0;
            tabPageNeuesSpiel.Text = "Neues Spiel";
            tabPageNeuesSpiel.UseVisualStyleBackColor = true;
            // 
            // btnVorhandenerSpieler
            // 
            btnVorhandenerSpieler.Font = new Font("Segoe UI", 18F);
            btnVorhandenerSpieler.Location = new Point(386, 358);
            btnVorhandenerSpieler.Name = "btnVorhandenerSpieler";
            btnVorhandenerSpieler.Size = new Size(250, 75);
            btnVorhandenerSpieler.TabIndex = 3;
            btnVorhandenerSpieler.Text = "Vorhandener Spieler";
            btnVorhandenerSpieler.UseVisualStyleBackColor = true;
            btnVorhandenerSpieler.Click += btnVorhandenerSpieler_Click;
            // 
            // btnNeuerSpieler
            // 
            btnNeuerSpieler.Font = new Font("Segoe UI", 18F);
            btnNeuerSpieler.Location = new Point(76, 358);
            btnNeuerSpieler.Name = "btnNeuerSpieler";
            btnNeuerSpieler.Size = new Size(250, 75);
            btnNeuerSpieler.TabIndex = 2;
            btnNeuerSpieler.Text = "Neuer Spieler";
            btnNeuerSpieler.UseVisualStyleBackColor = true;
            btnNeuerSpieler.Click += btnNeuerSpieler_Click;
            // 
            // lbNeuerSpieler
            // 
            lbNeuerSpieler.AutoSize = true;
            lbNeuerSpieler.Font = new Font("Segoe UI", 18F);
            lbNeuerSpieler.Location = new Point(170, 230);
            lbNeuerSpieler.Name = "lbNeuerSpieler";
            lbNeuerSpieler.Size = new Size(332, 32);
            lbNeuerSpieler.TabIndex = 1;
            lbNeuerSpieler.Text = "Einen neuen Spieler anlegen?";
            // 
            // lbNeuesSpiel
            // 
            lbNeuesSpiel.AutoSize = true;
            lbNeuesSpiel.Font = new Font("Segoe UI", 46F);
            lbNeuesSpiel.Location = new Point(159, 90);
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
            tabPageNeuerSpieler.Size = new Size(672, 522);
            tabPageNeuerSpieler.TabIndex = 1;
            tabPageNeuerSpieler.Text = "Neuer Spieler";
            tabPageNeuerSpieler.UseVisualStyleBackColor = true;
            // 
            // btnSpielerNeuSpielen
            // 
            btnSpielerNeuSpielen.Font = new Font("Segoe UI", 18F);
            btnSpielerNeuSpielen.Location = new Point(376, 275);
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
            tbBenutzername.Location = new Point(146, 198);
            tbBenutzername.Name = "tbBenutzername";
            tbBenutzername.Size = new Size(380, 71);
            tbBenutzername.TabIndex = 1;
            // 
            // lbSpielerName
            // 
            lbSpielerName.AutoSize = true;
            lbSpielerName.Font = new Font("Segoe UI", 36F);
            lbSpielerName.Location = new Point(29, 104);
            lbSpielerName.Name = "lbSpielerName";
            lbSpielerName.Size = new Size(183, 65);
            lbSpielerName.TabIndex = 0;
            lbSpielerName.Text = "Spieler:";
            // 
            // tabPageVorhandenerSpieler
            // 
            tabPageVorhandenerSpieler.Controls.Add(btnSpielerVorhandenSpielen);
            tabPageVorhandenerSpieler.Controls.Add(cbBenutzernamen);
            tabPageVorhandenerSpieler.Controls.Add(lbSpieler);
            tabPageVorhandenerSpieler.Location = new Point(4, 24);
            tabPageVorhandenerSpieler.Name = "tabPageVorhandenerSpieler";
            tabPageVorhandenerSpieler.Padding = new Padding(3);
            tabPageVorhandenerSpieler.Size = new Size(672, 522);
            tabPageVorhandenerSpieler.TabIndex = 2;
            tabPageVorhandenerSpieler.Text = "Spieler Auswählen";
            tabPageVorhandenerSpieler.UseVisualStyleBackColor = true;
            // 
            // btnSpielerVorhandenSpielen
            // 
            btnSpielerVorhandenSpielen.Font = new Font("Segoe UI", 18F);
            btnSpielerVorhandenSpielen.Location = new Point(439, 290);
            btnSpielerVorhandenSpielen.Name = "btnSpielerVorhandenSpielen";
            btnSpielerVorhandenSpielen.Size = new Size(150, 50);
            btnSpielerVorhandenSpielen.TabIndex = 2;
            btnSpielerVorhandenSpielen.Text = "Spielen";
            btnSpielerVorhandenSpielen.UseVisualStyleBackColor = true;
            btnSpielerVorhandenSpielen.Click += btnSpielerNeuSpielen_Click;
            // 
            // cbBenutzernamen
            // 
            cbBenutzernamen.FlatStyle = FlatStyle.Flat;
            cbBenutzernamen.Font = new Font("Segoe UI", 36F);
            cbBenutzernamen.FormattingEnabled = true;
            cbBenutzernamen.Location = new Point(60, 211);
            cbBenutzernamen.Name = "cbBenutzernamen";
            cbBenutzernamen.Size = new Size(529, 73);
            cbBenutzernamen.TabIndex = 1;
            // 
            // lbSpieler
            // 
            lbSpieler.AutoSize = true;
            lbSpieler.Font = new Font("Segoe UI", 36F);
            lbSpieler.Location = new Point(16, 134);
            lbSpieler.Name = "lbSpieler";
            lbSpieler.Size = new Size(183, 65);
            lbSpieler.TabIndex = 0;
            lbSpieler.Text = "Spieler:";
            // 
            // NeuesSpiel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 571);
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