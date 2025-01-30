namespace SaschaKleinen
{
    partial class Highscores
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
            tabControlHighscores = new TabControl();
            tabPageScoreMenu = new TabPage();
            lbScoreAnzeige = new Label();
            btnAlleScores = new Button();
            btnMeineScores = new Button();
            tabPageEinzelPunkte = new TabPage();
            lbSpielerScores = new Label();
            cbSpieler = new ComboBox();
            dataGridViewEinzelScores = new DataGridView();
            scoreSpieler = new DataGridViewTextBoxColumn();
            punktzahl = new DataGridViewTextBoxColumn();
            datum = new DataGridViewTextBoxColumn();
            tabPageAllePunkte = new TabPage();
            label1 = new Label();
            dataGridViewAllScores = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            tabControlHighscores.SuspendLayout();
            tabPageScoreMenu.SuspendLayout();
            tabPageEinzelPunkte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEinzelScores).BeginInit();
            tabPageAllePunkte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllScores).BeginInit();
            SuspendLayout();
            // 
            // tabControlHighscores
            // 
            tabControlHighscores.Controls.Add(tabPageScoreMenu);
            tabControlHighscores.Controls.Add(tabPageEinzelPunkte);
            tabControlHighscores.Controls.Add(tabPageAllePunkte);
            tabControlHighscores.Location = new Point(12, 12);
            tabControlHighscores.Name = "tabControlHighscores";
            tabControlHighscores.SelectedIndex = 0;
            tabControlHighscores.Size = new Size(776, 502);
            tabControlHighscores.TabIndex = 0;
            // 
            // tabPageScoreMenu
            // 
            tabPageScoreMenu.Controls.Add(lbScoreAnzeige);
            tabPageScoreMenu.Controls.Add(btnAlleScores);
            tabPageScoreMenu.Controls.Add(btnMeineScores);
            tabPageScoreMenu.Location = new Point(4, 24);
            tabPageScoreMenu.Name = "tabPageScoreMenu";
            tabPageScoreMenu.Padding = new Padding(3);
            tabPageScoreMenu.Size = new Size(768, 474);
            tabPageScoreMenu.TabIndex = 0;
            tabPageScoreMenu.Text = "Menu";
            tabPageScoreMenu.UseVisualStyleBackColor = true;
            // 
            // lbScoreAnzeige
            // 
            lbScoreAnzeige.AutoSize = true;
            lbScoreAnzeige.Font = new Font("Segoe UI", 36F);
            lbScoreAnzeige.Location = new Point(42, 55);
            lbScoreAnzeige.Name = "lbScoreAnzeige";
            lbScoreAnzeige.Size = new Size(685, 65);
            lbScoreAnzeige.TabIndex = 2;
            lbScoreAnzeige.Text = "Wähle die gewünschte Anzeige";
            // 
            // btnAlleScores
            // 
            btnAlleScores.Location = new Point(422, 212);
            btnAlleScores.Name = "btnAlleScores";
            btnAlleScores.Size = new Size(150, 50);
            btnAlleScores.TabIndex = 1;
            btnAlleScores.Text = "Alle Punkte";
            btnAlleScores.UseVisualStyleBackColor = true;
            btnAlleScores.Click += btnAlleScores_Click;
            // 
            // btnMeineScores
            // 
            btnMeineScores.Location = new Point(196, 212);
            btnMeineScores.Name = "btnMeineScores";
            btnMeineScores.Size = new Size(150, 50);
            btnMeineScores.TabIndex = 0;
            btnMeineScores.Text = "Meine Punkte";
            btnMeineScores.UseVisualStyleBackColor = true;
            btnMeineScores.Click += btnMeineScores_Click;
            // 
            // tabPageEinzelPunkte
            // 
            tabPageEinzelPunkte.Controls.Add(lbSpielerScores);
            tabPageEinzelPunkte.Controls.Add(cbSpieler);
            tabPageEinzelPunkte.Controls.Add(dataGridViewEinzelScores);
            tabPageEinzelPunkte.Location = new Point(4, 24);
            tabPageEinzelPunkte.Name = "tabPageEinzelPunkte";
            tabPageEinzelPunkte.Padding = new Padding(3);
            tabPageEinzelPunkte.Size = new Size(768, 474);
            tabPageEinzelPunkte.TabIndex = 1;
            tabPageEinzelPunkte.Text = "Pers. Score";
            tabPageEinzelPunkte.UseVisualStyleBackColor = true;
            // 
            // lbSpielerScores
            // 
            lbSpielerScores.AutoSize = true;
            lbSpielerScores.Location = new Point(170, 48);
            lbSpielerScores.Name = "lbSpielerScores";
            lbSpielerScores.Size = new Size(42, 15);
            lbSpielerScores.TabIndex = 2;
            lbSpielerScores.Text = "Spieler";
            // 
            // cbSpieler
            // 
            cbSpieler.FormattingEnabled = true;
            cbSpieler.Location = new Point(170, 66);
            cbSpieler.Name = "cbSpieler";
            cbSpieler.Size = new Size(207, 23);
            cbSpieler.TabIndex = 1;
            cbSpieler.SelectedIndexChanged += cbSpieler_SelectedIndexChanged;
            // 
            // dataGridViewEinzelScores
            // 
            dataGridViewEinzelScores.AllowUserToAddRows = false;
            dataGridViewEinzelScores.AllowUserToDeleteRows = false;
            dataGridViewEinzelScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEinzelScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEinzelScores.Columns.AddRange(new DataGridViewColumn[] { scoreSpieler, punktzahl, datum });
            dataGridViewEinzelScores.Location = new Point(170, 95);
            dataGridViewEinzelScores.MultiSelect = false;
            dataGridViewEinzelScores.Name = "dataGridViewEinzelScores";
            dataGridViewEinzelScores.ReadOnly = true;
            dataGridViewEinzelScores.RowHeadersVisible = false;
            dataGridViewEinzelScores.Size = new Size(428, 285);
            dataGridViewEinzelScores.TabIndex = 0;
            // 
            // scoreSpieler
            // 
            scoreSpieler.HeaderText = "Spieler";
            scoreSpieler.Name = "scoreSpieler";
            scoreSpieler.ReadOnly = true;
            // 
            // punktzahl
            // 
            punktzahl.HeaderText = "Score";
            punktzahl.Name = "punktzahl";
            punktzahl.ReadOnly = true;
            // 
            // datum
            // 
            datum.HeaderText = "Datum";
            datum.Name = "datum";
            datum.ReadOnly = true;
            // 
            // tabPageAllePunkte
            // 
            tabPageAllePunkte.Controls.Add(label1);
            tabPageAllePunkte.Controls.Add(dataGridViewAllScores);
            tabPageAllePunkte.Location = new Point(4, 24);
            tabPageAllePunkte.Name = "tabPageAllePunkte";
            tabPageAllePunkte.Padding = new Padding(3);
            tabPageAllePunkte.Size = new Size(768, 474);
            tabPageAllePunkte.TabIndex = 2;
            tabPageAllePunkte.Text = "Alles Punkte";
            tabPageAllePunkte.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F);
            label1.Location = new Point(221, 33);
            label1.Name = "label1";
            label1.Size = new Size(327, 81);
            label1.TabIndex = 2;
            label1.Text = "Highscores";
            // 
            // dataGridViewAllScores
            // 
            dataGridViewAllScores.AllowUserToAddRows = false;
            dataGridViewAllScores.AllowUserToDeleteRows = false;
            dataGridViewAllScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAllScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllScores.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewAllScores.Location = new Point(170, 118);
            dataGridViewAllScores.MultiSelect = false;
            dataGridViewAllScores.Name = "dataGridViewAllScores";
            dataGridViewAllScores.ReadOnly = true;
            dataGridViewAllScores.RowHeadersVisible = false;
            dataGridViewAllScores.Size = new Size(428, 331);
            dataGridViewAllScores.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Spieler";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Score";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Datum";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Highscores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(tabControlHighscores);
            Name = "Highscores";
            Text = "Highscores";
            tabControlHighscores.ResumeLayout(false);
            tabPageScoreMenu.ResumeLayout(false);
            tabPageScoreMenu.PerformLayout();
            tabPageEinzelPunkte.ResumeLayout(false);
            tabPageEinzelPunkte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEinzelScores).EndInit();
            tabPageAllePunkte.ResumeLayout(false);
            tabPageAllePunkte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllScores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlHighscores;
        private TabPage tabPageScoreMenu;
        private Label lbScoreAnzeige;
        private Button btnAlleScores;
        private Button btnMeineScores;
        private TabPage tabPageEinzelPunkte;
        private TabPage tabPageAllePunkte;
        private Label lbSpielerScores;
        private ComboBox cbSpieler;
        private DataGridView dataGridViewEinzelScores;
        private DataGridViewTextBoxColumn scoreSpieler;
        private DataGridViewTextBoxColumn punktzahl;
        private DataGridViewTextBoxColumn datum;
        private DataGridView dataGridViewAllScores;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label1;
    }
}