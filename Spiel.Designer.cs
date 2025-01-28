namespace SaschaKleinen
{
    partial class Spiel
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
            tabControlSpiel = new TabControl();
            tabPageKontinente = new TabPage();
            panelKontinentSelectAll = new Panel();
            checkBoxAlle = new CheckBox();
            panelKontinentSingleSelect = new Panel();
            checkBoxAfrica = new CheckBox();
            checkBoxAusOz = new CheckBox();
            checkBoxNordamerika = new CheckBox();
            checkBoxSuedamerika = new CheckBox();
            checkBoxAsien = new CheckBox();
            checkBoxEuropa = new CheckBox();
            btnKontinentWeiter = new Button();
            lbKontinente = new Label();
            tabPageFrageAntworttyp = new TabPage();
            panelAtnworttyp = new Panel();
            rbAntworttyp2 = new RadioButton();
            rbAntworttyp1 = new RadioButton();
            lbAntworttyp = new Label();
            panelFragentyp = new Panel();
            rbFragenHaupstadt = new RadioButton();
            rbFrageLand = new RadioButton();
            rbFrageFlaggen = new RadioButton();
            lbFragentyp = new Label();
            btnSpielbeginnen = new Button();
            btnFATZurueck = new Button();
            tabPageSpiel = new TabPage();
            panelSpielBildAntwort = new Panel();
            btnAntwortBildNext = new Button();
            groupBox1 = new GroupBox();
            pbAntwort4 = new PictureBox();
            pbAntwort3 = new PictureBox();
            pbAntwort2 = new PictureBox();
            pbAntwort1 = new PictureBox();
            rbBildAntwort4 = new RadioButton();
            rbBildAntwort3 = new RadioButton();
            rbBildAntwort2 = new RadioButton();
            rbBildAntwort1 = new RadioButton();
            lbAntwortBildFrageText = new Label();
            lbAntwortBildFrage = new Label();
            panelSpielBildFrage = new Panel();
            rbFlaggeAntwort = new GroupBox();
            btnFlaggeAntwortNext = new Button();
            rbAntwortFlagge4 = new RadioButton();
            rbAntwortFlagge3 = new RadioButton();
            rbAntwortFlagge2 = new RadioButton();
            rbAntwortFlagge1 = new RadioButton();
            pbFrageFlagge = new PictureBox();
            lbFrageBildText = new Label();
            lbFrageBild = new Label();
            panelSpielTextOnly = new Panel();
            groupBoxTextOnly = new GroupBox();
            rbAntwortText4 = new RadioButton();
            btnTextOnlyNext = new Button();
            rbAntwortText3 = new RadioButton();
            rbAntwortText2 = new RadioButton();
            rbAntwortText1 = new RadioButton();
            lbFrageText = new Label();
            lbFrage = new Label();
            tabControlSpiel.SuspendLayout();
            tabPageKontinente.SuspendLayout();
            panelKontinentSelectAll.SuspendLayout();
            panelKontinentSingleSelect.SuspendLayout();
            tabPageFrageAntworttyp.SuspendLayout();
            panelAtnworttyp.SuspendLayout();
            panelFragentyp.SuspendLayout();
            tabPageSpiel.SuspendLayout();
            panelSpielBildAntwort.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAntwort4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAntwort3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAntwort2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAntwort1).BeginInit();
            panelSpielBildFrage.SuspendLayout();
            rbFlaggeAntwort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFrageFlagge).BeginInit();
            panelSpielTextOnly.SuspendLayout();
            groupBoxTextOnly.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlSpiel
            // 
            tabControlSpiel.Controls.Add(tabPageKontinente);
            tabControlSpiel.Controls.Add(tabPageFrageAntworttyp);
            tabControlSpiel.Controls.Add(tabPageSpiel);
            tabControlSpiel.Location = new Point(12, 12);
            tabControlSpiel.Name = "tabControlSpiel";
            tabControlSpiel.SelectedIndex = 0;
            tabControlSpiel.Size = new Size(984, 657);
            tabControlSpiel.TabIndex = 0;
            // 
            // tabPageKontinente
            // 
            tabPageKontinente.Controls.Add(panelKontinentSelectAll);
            tabPageKontinente.Controls.Add(panelKontinentSingleSelect);
            tabPageKontinente.Controls.Add(btnKontinentWeiter);
            tabPageKontinente.Controls.Add(lbKontinente);
            tabPageKontinente.Location = new Point(4, 24);
            tabPageKontinente.Name = "tabPageKontinente";
            tabPageKontinente.Padding = new Padding(3);
            tabPageKontinente.Size = new Size(976, 629);
            tabPageKontinente.TabIndex = 0;
            tabPageKontinente.Text = "Kontinente";
            tabPageKontinente.UseVisualStyleBackColor = true;
            // 
            // panelKontinentSelectAll
            // 
            panelKontinentSelectAll.Controls.Add(checkBoxAlle);
            panelKontinentSelectAll.Location = new Point(142, 128);
            panelKontinentSelectAll.Name = "panelKontinentSelectAll";
            panelKontinentSelectAll.Size = new Size(253, 90);
            panelKontinentSelectAll.TabIndex = 11;
            // 
            // checkBoxAlle
            // 
            checkBoxAlle.AutoSize = true;
            checkBoxAlle.Font = new Font("Segoe UI", 18F);
            checkBoxAlle.Location = new Point(28, 27);
            checkBoxAlle.Name = "checkBoxAlle";
            checkBoxAlle.Size = new Size(197, 36);
            checkBoxAlle.TabIndex = 1;
            checkBoxAlle.Text = "Alle Kontinente";
            checkBoxAlle.UseVisualStyleBackColor = true;
            checkBoxAlle.CheckedChanged += checkBoxAlle_CheckedChanged;
            // 
            // panelKontinentSingleSelect
            // 
            panelKontinentSingleSelect.Controls.Add(checkBoxAfrica);
            panelKontinentSingleSelect.Controls.Add(checkBoxAusOz);
            panelKontinentSingleSelect.Controls.Add(checkBoxNordamerika);
            panelKontinentSingleSelect.Controls.Add(checkBoxSuedamerika);
            panelKontinentSingleSelect.Controls.Add(checkBoxAsien);
            panelKontinentSingleSelect.Controls.Add(checkBoxEuropa);
            panelKontinentSingleSelect.Location = new Point(142, 224);
            panelKontinentSingleSelect.Name = "panelKontinentSingleSelect";
            panelKontinentSingleSelect.Size = new Size(782, 171);
            panelKontinentSingleSelect.TabIndex = 10;
            // 
            // checkBoxAfrica
            // 
            checkBoxAfrica.AutoSize = true;
            checkBoxAfrica.Font = new Font("Segoe UI", 18F);
            checkBoxAfrica.Location = new Point(53, 37);
            checkBoxAfrica.Name = "checkBoxAfrica";
            checkBoxAfrica.Size = new Size(94, 36);
            checkBoxAfrica.TabIndex = 8;
            checkBoxAfrica.Text = "Afrika";
            checkBoxAfrica.UseVisualStyleBackColor = true;
            // 
            // checkBoxAusOz
            // 
            checkBoxAusOz.AutoSize = true;
            checkBoxAusOz.Font = new Font("Segoe UI", 18F);
            checkBoxAusOz.Location = new Point(481, 97);
            checkBoxAusOz.Name = "checkBoxAusOz";
            checkBoxAusOz.Size = new Size(249, 36);
            checkBoxAusOz.TabIndex = 7;
            checkBoxAusOz.Text = "Australien/Ozeanien";
            checkBoxAusOz.UseVisualStyleBackColor = true;
            // 
            // checkBoxNordamerika
            // 
            checkBoxNordamerika.AutoSize = true;
            checkBoxNordamerika.Font = new Font("Segoe UI", 18F);
            checkBoxNordamerika.Location = new Point(53, 97);
            checkBoxNordamerika.Name = "checkBoxNordamerika";
            checkBoxNordamerika.Size = new Size(171, 36);
            checkBoxNordamerika.TabIndex = 6;
            checkBoxNordamerika.Text = "Nordamerika";
            checkBoxNordamerika.UseVisualStyleBackColor = true;
            // 
            // checkBoxSuedamerika
            // 
            checkBoxSuedamerika.AutoSize = true;
            checkBoxSuedamerika.Font = new Font("Segoe UI", 18F);
            checkBoxSuedamerika.Location = new Point(266, 97);
            checkBoxSuedamerika.Name = "checkBoxSuedamerika";
            checkBoxSuedamerika.Size = new Size(158, 36);
            checkBoxSuedamerika.TabIndex = 4;
            checkBoxSuedamerika.Text = "Südamerika";
            checkBoxSuedamerika.UseVisualStyleBackColor = true;
            // 
            // checkBoxAsien
            // 
            checkBoxAsien.AutoSize = true;
            checkBoxAsien.Font = new Font("Segoe UI", 18F);
            checkBoxAsien.Location = new Point(266, 37);
            checkBoxAsien.Name = "checkBoxAsien";
            checkBoxAsien.Size = new Size(91, 36);
            checkBoxAsien.TabIndex = 3;
            checkBoxAsien.Text = "Asien";
            checkBoxAsien.UseVisualStyleBackColor = true;
            // 
            // checkBoxEuropa
            // 
            checkBoxEuropa.AutoSize = true;
            checkBoxEuropa.Font = new Font("Segoe UI", 18F);
            checkBoxEuropa.Location = new Point(481, 37);
            checkBoxEuropa.Name = "checkBoxEuropa";
            checkBoxEuropa.Size = new Size(107, 36);
            checkBoxEuropa.TabIndex = 2;
            checkBoxEuropa.Text = "Europa";
            checkBoxEuropa.UseVisualStyleBackColor = true;
            // 
            // btnKontinentWeiter
            // 
            btnKontinentWeiter.Font = new Font("Segoe UI", 18F);
            btnKontinentWeiter.Location = new Point(728, 452);
            btnKontinentWeiter.Name = "btnKontinentWeiter";
            btnKontinentWeiter.Size = new Size(150, 50);
            btnKontinentWeiter.TabIndex = 9;
            btnKontinentWeiter.Text = "Weiter";
            btnKontinentWeiter.UseVisualStyleBackColor = true;
            btnKontinentWeiter.Click += btnKontinentWeiter_Click;
            // 
            // lbKontinente
            // 
            lbKontinente.AutoSize = true;
            lbKontinente.Font = new Font("Segoe UI", 27F);
            lbKontinente.Location = new Point(24, 49);
            lbKontinente.Name = "lbKontinente";
            lbKontinente.Size = new Size(192, 48);
            lbKontinente.TabIndex = 0;
            lbKontinente.Text = "Kontinente";
            // 
            // tabPageFrageAntworttyp
            // 
            tabPageFrageAntworttyp.Controls.Add(panelAtnworttyp);
            tabPageFrageAntworttyp.Controls.Add(panelFragentyp);
            tabPageFrageAntworttyp.Controls.Add(btnSpielbeginnen);
            tabPageFrageAntworttyp.Controls.Add(btnFATZurueck);
            tabPageFrageAntworttyp.Location = new Point(4, 24);
            tabPageFrageAntworttyp.Name = "tabPageFrageAntworttyp";
            tabPageFrageAntworttyp.Padding = new Padding(3);
            tabPageFrageAntworttyp.Size = new Size(976, 629);
            tabPageFrageAntworttyp.TabIndex = 1;
            tabPageFrageAntworttyp.Text = "Frage/Antworttyp";
            tabPageFrageAntworttyp.UseVisualStyleBackColor = true;
            // 
            // panelAtnworttyp
            // 
            panelAtnworttyp.Controls.Add(rbAntworttyp2);
            panelAtnworttyp.Controls.Add(rbAntworttyp1);
            panelAtnworttyp.Controls.Add(lbAntworttyp);
            panelAtnworttyp.Location = new Point(13, 282);
            panelAtnworttyp.Name = "panelAtnworttyp";
            panelAtnworttyp.Size = new Size(917, 243);
            panelAtnworttyp.TabIndex = 6;
            // 
            // rbAntworttyp2
            // 
            rbAntworttyp2.AutoSize = true;
            rbAntworttyp2.Font = new Font("Segoe UI", 27F);
            rbAntworttyp2.Location = new Point(596, 25);
            rbAntworttyp2.Name = "rbAntworttyp2";
            rbAntworttyp2.Size = new Size(122, 52);
            rbAntworttyp2.TabIndex = 4;
            rbAntworttyp2.TabStop = true;
            rbAntworttyp2.Text = "####";
            rbAntworttyp2.UseVisualStyleBackColor = true;
            rbAntworttyp2.Visible = false;
            // 
            // rbAntworttyp1
            // 
            rbAntworttyp1.AutoSize = true;
            rbAntworttyp1.Font = new Font("Segoe UI", 27F);
            rbAntworttyp1.Location = new Point(325, 25);
            rbAntworttyp1.Name = "rbAntworttyp1";
            rbAntworttyp1.Size = new Size(122, 52);
            rbAntworttyp1.TabIndex = 3;
            rbAntworttyp1.TabStop = true;
            rbAntworttyp1.Text = "####";
            rbAntworttyp1.UseVisualStyleBackColor = true;
            rbAntworttyp1.Visible = false;
            // 
            // lbAntworttyp
            // 
            lbAntworttyp.AutoSize = true;
            lbAntworttyp.Font = new Font("Segoe UI", 27F);
            lbAntworttyp.Location = new Point(31, 27);
            lbAntworttyp.Name = "lbAntworttyp";
            lbAntworttyp.Size = new Size(205, 48);
            lbAntworttyp.TabIndex = 2;
            lbAntworttyp.Text = "Antworttyp:";
            // 
            // panelFragentyp
            // 
            panelFragentyp.Controls.Add(rbFragenHaupstadt);
            panelFragentyp.Controls.Add(rbFrageLand);
            panelFragentyp.Controls.Add(rbFrageFlaggen);
            panelFragentyp.Controls.Add(lbFragentyp);
            panelFragentyp.Location = new Point(13, 33);
            panelFragentyp.Name = "panelFragentyp";
            panelFragentyp.Size = new Size(917, 243);
            panelFragentyp.TabIndex = 3;
            // 
            // rbFragenHaupstadt
            // 
            rbFragenHaupstadt.AutoSize = true;
            rbFragenHaupstadt.Font = new Font("Segoe UI", 27F);
            rbFragenHaupstadt.Location = new Point(325, 97);
            rbFragenHaupstadt.Name = "rbFragenHaupstadt";
            rbFragenHaupstadt.Size = new Size(232, 52);
            rbFragenHaupstadt.TabIndex = 5;
            rbFragenHaupstadt.TabStop = true;
            rbFragenHaupstadt.Text = "Hauptstädte";
            rbFragenHaupstadt.UseVisualStyleBackColor = true;
            rbFragenHaupstadt.CheckedChanged += rbFrageFlaggen_CheckedChanged;
            // 
            // rbFrageLand
            // 
            rbFrageLand.AutoSize = true;
            rbFrageLand.Font = new Font("Segoe UI", 27F);
            rbFrageLand.Location = new Point(325, 171);
            rbFrageLand.Name = "rbFrageLand";
            rbFrageLand.Size = new Size(146, 52);
            rbFrageLand.TabIndex = 4;
            rbFrageLand.TabStop = true;
            rbFrageLand.Text = "Länder";
            rbFrageLand.UseVisualStyleBackColor = true;
            rbFrageLand.CheckedChanged += rbFrageFlaggen_CheckedChanged;
            // 
            // rbFrageFlaggen
            // 
            rbFrageFlaggen.AutoSize = true;
            rbFrageFlaggen.Font = new Font("Segoe UI", 27F);
            rbFrageFlaggen.Location = new Point(325, 23);
            rbFrageFlaggen.Name = "rbFrageFlaggen";
            rbFrageFlaggen.Size = new Size(164, 52);
            rbFrageFlaggen.TabIndex = 3;
            rbFrageFlaggen.TabStop = true;
            rbFrageFlaggen.Text = "Flaggen";
            rbFrageFlaggen.UseVisualStyleBackColor = true;
            rbFrageFlaggen.CheckedChanged += rbFrageFlaggen_CheckedChanged;
            // 
            // lbFragentyp
            // 
            lbFragentyp.AutoSize = true;
            lbFragentyp.Font = new Font("Segoe UI", 27F);
            lbFragentyp.Location = new Point(31, 27);
            lbFragentyp.Name = "lbFragentyp";
            lbFragentyp.Size = new Size(187, 48);
            lbFragentyp.TabIndex = 2;
            lbFragentyp.Text = "Fragentyp:";
            // 
            // btnSpielbeginnen
            // 
            btnSpielbeginnen.Location = new Point(820, 573);
            btnSpielbeginnen.Name = "btnSpielbeginnen";
            btnSpielbeginnen.Size = new Size(150, 50);
            btnSpielbeginnen.TabIndex = 1;
            btnSpielbeginnen.Text = "Spiel beginnen";
            btnSpielbeginnen.UseVisualStyleBackColor = true;
            btnSpielbeginnen.Click += btnSpielbeginnen_Click;
            // 
            // btnFATZurueck
            // 
            btnFATZurueck.Location = new Point(6, 573);
            btnFATZurueck.Name = "btnFATZurueck";
            btnFATZurueck.Size = new Size(150, 50);
            btnFATZurueck.TabIndex = 0;
            btnFATZurueck.Text = "Zurück";
            btnFATZurueck.UseVisualStyleBackColor = true;
            // 
            // tabPageSpiel
            // 
            tabPageSpiel.Controls.Add(panelSpielBildAntwort);
            tabPageSpiel.Controls.Add(panelSpielBildFrage);
            tabPageSpiel.Controls.Add(panelSpielTextOnly);
            tabPageSpiel.Location = new Point(4, 24);
            tabPageSpiel.Name = "tabPageSpiel";
            tabPageSpiel.Padding = new Padding(3);
            tabPageSpiel.Size = new Size(976, 629);
            tabPageSpiel.TabIndex = 2;
            tabPageSpiel.Text = "Spiel";
            tabPageSpiel.UseVisualStyleBackColor = true;
            // 
            // panelSpielBildAntwort
            // 
            panelSpielBildAntwort.Controls.Add(btnAntwortBildNext);
            panelSpielBildAntwort.Controls.Add(groupBox1);
            panelSpielBildAntwort.Controls.Add(lbAntwortBildFrageText);
            panelSpielBildAntwort.Controls.Add(lbAntwortBildFrage);
            panelSpielBildAntwort.Location = new Point(42, 623);
            panelSpielBildAntwort.Name = "panelSpielBildAntwort";
            panelSpielBildAntwort.Size = new Size(964, 617);
            panelSpielBildAntwort.TabIndex = 4;
            // 
            // btnAntwortBildNext
            // 
            btnAntwortBildNext.Font = new Font("Segoe UI", 18F);
            btnAntwortBildNext.Location = new Point(750, 547);
            btnAntwortBildNext.Name = "btnAntwortBildNext";
            btnAntwortBildNext.Size = new Size(150, 50);
            btnAntwortBildNext.TabIndex = 3;
            btnAntwortBildNext.Text = "Bestätigen";
            btnAntwortBildNext.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbAntwort4);
            groupBox1.Controls.Add(pbAntwort3);
            groupBox1.Controls.Add(pbAntwort2);
            groupBox1.Controls.Add(pbAntwort1);
            groupBox1.Controls.Add(rbBildAntwort4);
            groupBox1.Controls.Add(rbBildAntwort3);
            groupBox1.Controls.Add(rbBildAntwort2);
            groupBox1.Controls.Add(rbBildAntwort1);
            groupBox1.Location = new Point(65, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(835, 324);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pbAntwort4
            // 
            pbAntwort4.Location = new Point(540, 186);
            pbAntwort4.Name = "pbAntwort4";
            pbAntwort4.Size = new Size(171, 110);
            pbAntwort4.TabIndex = 7;
            pbAntwort4.TabStop = false;
            // 
            // pbAntwort3
            // 
            pbAntwort3.Location = new Point(143, 186);
            pbAntwort3.Name = "pbAntwort3";
            pbAntwort3.Size = new Size(171, 110);
            pbAntwort3.TabIndex = 6;
            pbAntwort3.TabStop = false;
            // 
            // pbAntwort2
            // 
            pbAntwort2.Location = new Point(540, 29);
            pbAntwort2.Name = "pbAntwort2";
            pbAntwort2.Size = new Size(171, 110);
            pbAntwort2.TabIndex = 5;
            pbAntwort2.TabStop = false;
            // 
            // pbAntwort1
            // 
            pbAntwort1.Location = new Point(143, 29);
            pbAntwort1.Name = "pbAntwort1";
            pbAntwort1.Size = new Size(171, 110);
            pbAntwort1.TabIndex = 4;
            pbAntwort1.TabStop = false;
            // 
            // rbBildAntwort4
            // 
            rbBildAntwort4.AutoSize = true;
            rbBildAntwort4.Font = new Font("Segoe UI", 18F);
            rbBildAntwort4.Location = new Point(520, 226);
            rbBildAntwort4.Name = "rbBildAntwort4";
            rbBildAntwort4.Size = new Size(191, 36);
            rbBildAntwort4.TabIndex = 3;
            rbBildAntwort4.TabStop = true;
            rbBildAntwort4.Text = "rbBildAntwort4";
            rbBildAntwort4.UseVisualStyleBackColor = true;
            // 
            // rbBildAntwort3
            // 
            rbBildAntwort3.AutoSize = true;
            rbBildAntwort3.Font = new Font("Segoe UI", 18F);
            rbBildAntwort3.Location = new Point(123, 226);
            rbBildAntwort3.Name = "rbBildAntwort3";
            rbBildAntwort3.Size = new Size(191, 36);
            rbBildAntwort3.TabIndex = 2;
            rbBildAntwort3.TabStop = true;
            rbBildAntwort3.Text = "rbBildAntwort3";
            rbBildAntwort3.UseVisualStyleBackColor = true;
            // 
            // rbBildAntwort2
            // 
            rbBildAntwort2.AutoSize = true;
            rbBildAntwort2.Font = new Font("Segoe UI", 18F);
            rbBildAntwort2.Location = new Point(520, 62);
            rbBildAntwort2.Name = "rbBildAntwort2";
            rbBildAntwort2.Size = new Size(191, 36);
            rbBildAntwort2.TabIndex = 1;
            rbBildAntwort2.TabStop = true;
            rbBildAntwort2.Text = "rbBildAntwort2";
            rbBildAntwort2.UseVisualStyleBackColor = true;
            // 
            // rbBildAntwort1
            // 
            rbBildAntwort1.AutoSize = true;
            rbBildAntwort1.Font = new Font("Segoe UI", 18F);
            rbBildAntwort1.Location = new Point(123, 62);
            rbBildAntwort1.Name = "rbBildAntwort1";
            rbBildAntwort1.Size = new Size(191, 36);
            rbBildAntwort1.TabIndex = 0;
            rbBildAntwort1.TabStop = true;
            rbBildAntwort1.Text = "rbBildAntwort1";
            rbBildAntwort1.UseVisualStyleBackColor = true;
            // 
            // lbAntwortBildFrageText
            // 
            lbAntwortBildFrageText.AutoSize = true;
            lbAntwortBildFrageText.Font = new Font("Segoe UI", 27F);
            lbAntwortBildFrageText.Location = new Point(72, 85);
            lbAntwortBildFrageText.Name = "lbAntwortBildFrageText";
            lbAntwortBildFrageText.Size = new Size(625, 48);
            lbAntwortBildFrageText.TabIndex = 1;
            lbAntwortBildFrageText.Text = "Welche Flagge gehört zu diesem Land";
            // 
            // lbAntwortBildFrage
            // 
            lbAntwortBildFrage.AutoSize = true;
            lbAntwortBildFrage.Font = new Font("Segoe UI", 27F);
            lbAntwortBildFrage.Location = new Point(32, 23);
            lbAntwortBildFrage.Name = "lbAntwortBildFrage";
            lbAntwortBildFrage.Size = new Size(117, 48);
            lbAntwortBildFrage.TabIndex = 0;
            lbAntwortBildFrage.Text = "Frage:";
            // 
            // panelSpielBildFrage
            // 
            panelSpielBildFrage.Controls.Add(rbFlaggeAntwort);
            panelSpielBildFrage.Controls.Add(pbFrageFlagge);
            panelSpielBildFrage.Controls.Add(lbFrageBildText);
            panelSpielBildFrage.Controls.Add(lbFrageBild);
            panelSpielBildFrage.Location = new Point(0, 0);
            panelSpielBildFrage.Name = "panelSpielBildFrage";
            panelSpielBildFrage.Size = new Size(976, 629);
            panelSpielBildFrage.TabIndex = 7;
            // 
            // rbFlaggeAntwort
            // 
            rbFlaggeAntwort.Controls.Add(btnFlaggeAntwortNext);
            rbFlaggeAntwort.Controls.Add(rbAntwortFlagge4);
            rbFlaggeAntwort.Controls.Add(rbAntwortFlagge3);
            rbFlaggeAntwort.Controls.Add(rbAntwortFlagge2);
            rbFlaggeAntwort.Controls.Add(rbAntwortFlagge1);
            rbFlaggeAntwort.Location = new Point(3, 404);
            rbFlaggeAntwort.Name = "rbFlaggeAntwort";
            rbFlaggeAntwort.Size = new Size(952, 204);
            rbFlaggeAntwort.TabIndex = 3;
            rbFlaggeAntwort.TabStop = false;
            rbFlaggeAntwort.Text = "Antworten";
            // 
            // btnFlaggeAntwortNext
            // 
            btnFlaggeAntwortNext.Location = new Point(796, 148);
            btnFlaggeAntwortNext.Name = "btnFlaggeAntwortNext";
            btnFlaggeAntwortNext.Size = new Size(150, 50);
            btnFlaggeAntwortNext.TabIndex = 4;
            btnFlaggeAntwortNext.Text = "Bestätigen";
            btnFlaggeAntwortNext.UseVisualStyleBackColor = true;
            btnFlaggeAntwortNext.Click += btnFlaggeAntwortNext_Click;
            // 
            // rbAntwortFlagge4
            // 
            rbAntwortFlagge4.AutoSize = true;
            rbAntwortFlagge4.Font = new Font("Segoe UI", 18F);
            rbAntwortFlagge4.Location = new Point(543, 115);
            rbAntwortFlagge4.Name = "rbAntwortFlagge4";
            rbAntwortFlagge4.Size = new Size(222, 36);
            rbAntwortFlagge4.TabIndex = 3;
            rbAntwortFlagge4.TabStop = true;
            rbAntwortFlagge4.Text = "rbAntwortFlagge4";
            rbAntwortFlagge4.UseVisualStyleBackColor = true;
            // 
            // rbAntwortFlagge3
            // 
            rbAntwortFlagge3.AutoSize = true;
            rbAntwortFlagge3.Font = new Font("Segoe UI", 18F);
            rbAntwortFlagge3.Location = new Point(188, 115);
            rbAntwortFlagge3.Name = "rbAntwortFlagge3";
            rbAntwortFlagge3.Size = new Size(222, 36);
            rbAntwortFlagge3.TabIndex = 2;
            rbAntwortFlagge3.TabStop = true;
            rbAntwortFlagge3.Text = "rbAntwortFlagge3";
            rbAntwortFlagge3.UseVisualStyleBackColor = true;
            // 
            // rbAntwortFlagge2
            // 
            rbAntwortFlagge2.AutoSize = true;
            rbAntwortFlagge2.Font = new Font("Segoe UI", 18F);
            rbAntwortFlagge2.Location = new Point(543, 53);
            rbAntwortFlagge2.Name = "rbAntwortFlagge2";
            rbAntwortFlagge2.Size = new Size(222, 36);
            rbAntwortFlagge2.TabIndex = 1;
            rbAntwortFlagge2.TabStop = true;
            rbAntwortFlagge2.Text = "rbAntwortFlagge2";
            rbAntwortFlagge2.UseVisualStyleBackColor = true;
            // 
            // rbAntwortFlagge1
            // 
            rbAntwortFlagge1.AutoSize = true;
            rbAntwortFlagge1.Font = new Font("Segoe UI", 18F);
            rbAntwortFlagge1.Location = new Point(188, 53);
            rbAntwortFlagge1.Name = "rbAntwortFlagge1";
            rbAntwortFlagge1.Size = new Size(222, 36);
            rbAntwortFlagge1.TabIndex = 0;
            rbAntwortFlagge1.TabStop = true;
            rbAntwortFlagge1.Text = "rbAntwortFlagge1";
            rbAntwortFlagge1.UseVisualStyleBackColor = true;
            // 
            // pbFrageFlagge
            // 
            pbFrageFlagge.Location = new Point(308, 136);
            pbFrageFlagge.Name = "pbFrageFlagge";
            pbFrageFlagge.Size = new Size(350, 250);
            pbFrageFlagge.SizeMode = PictureBoxSizeMode.Zoom;
            pbFrageFlagge.TabIndex = 2;
            pbFrageFlagge.TabStop = false;
            // 
            // lbFrageBildText
            // 
            lbFrageBildText.AutoSize = true;
            lbFrageBildText.Font = new Font("Segoe UI", 27F);
            lbFrageBildText.Location = new Point(171, 79);
            lbFrageBildText.Name = "lbFrageBildText";
            lbFrageBildText.Size = new Size(623, 48);
            lbFrageBildText.TabIndex = 1;
            lbFrageBildText.Text = "Zu welchem Land gehört diese Flagge";
            // 
            // lbFrageBild
            // 
            lbFrageBild.AutoSize = true;
            lbFrageBild.Font = new Font("Segoe UI", 27F);
            lbFrageBild.Location = new Point(171, 31);
            lbFrageBild.Name = "lbFrageBild";
            lbFrageBild.Size = new Size(117, 48);
            lbFrageBild.TabIndex = 0;
            lbFrageBild.Text = "Frage:";
            // 
            // panelSpielTextOnly
            // 
            panelSpielTextOnly.Controls.Add(groupBoxTextOnly);
            panelSpielTextOnly.Controls.Add(lbFrageText);
            panelSpielTextOnly.Controls.Add(lbFrage);
            panelSpielTextOnly.Location = new Point(0, 0);
            panelSpielTextOnly.Name = "panelSpielTextOnly";
            panelSpielTextOnly.Size = new Size(964, 617);
            panelSpielTextOnly.TabIndex = 0;
            // 
            // groupBoxTextOnly
            // 
            groupBoxTextOnly.Controls.Add(rbAntwortText4);
            groupBoxTextOnly.Controls.Add(btnTextOnlyNext);
            groupBoxTextOnly.Controls.Add(rbAntwortText3);
            groupBoxTextOnly.Controls.Add(rbAntwortText2);
            groupBoxTextOnly.Controls.Add(rbAntwortText1);
            groupBoxTextOnly.Location = new Point(3, 278);
            groupBoxTextOnly.Name = "groupBoxTextOnly";
            groupBoxTextOnly.Size = new Size(958, 322);
            groupBoxTextOnly.TabIndex = 7;
            groupBoxTextOnly.TabStop = false;
            groupBoxTextOnly.Text = "Antworten";
            // 
            // rbAntwortText4
            // 
            rbAntwortText4.AutoSize = true;
            rbAntwortText4.Font = new Font("Segoe UI", 27F);
            rbAntwortText4.Location = new Point(565, 128);
            rbAntwortText4.Name = "rbAntwortText4";
            rbAntwortText4.Size = new Size(184, 52);
            rbAntwortText4.TabIndex = 5;
            rbAntwortText4.TabStop = true;
            rbAntwortText4.Text = "Antwort4";
            rbAntwortText4.UseVisualStyleBackColor = true;
            // 
            // btnTextOnlyNext
            // 
            btnTextOnlyNext.Font = new Font("Segoe UI", 18F);
            btnTextOnlyNext.Location = new Point(802, 266);
            btnTextOnlyNext.Name = "btnTextOnlyNext";
            btnTextOnlyNext.Size = new Size(150, 50);
            btnTextOnlyNext.TabIndex = 6;
            btnTextOnlyNext.Text = "Bestätigen";
            btnTextOnlyNext.UseVisualStyleBackColor = true;
            btnTextOnlyNext.Click += btnTextOnlyNext_Click;
            // 
            // rbAntwortText3
            // 
            rbAntwortText3.AutoSize = true;
            rbAntwortText3.Font = new Font("Segoe UI", 27F);
            rbAntwortText3.Location = new Point(210, 128);
            rbAntwortText3.Name = "rbAntwortText3";
            rbAntwortText3.Size = new Size(184, 52);
            rbAntwortText3.TabIndex = 4;
            rbAntwortText3.TabStop = true;
            rbAntwortText3.Text = "Antwort3";
            rbAntwortText3.UseVisualStyleBackColor = true;
            // 
            // rbAntwortText2
            // 
            rbAntwortText2.AutoSize = true;
            rbAntwortText2.Font = new Font("Segoe UI", 27F);
            rbAntwortText2.Location = new Point(565, 30);
            rbAntwortText2.Name = "rbAntwortText2";
            rbAntwortText2.Size = new Size(184, 52);
            rbAntwortText2.TabIndex = 3;
            rbAntwortText2.TabStop = true;
            rbAntwortText2.Text = "Antwort2";
            rbAntwortText2.UseVisualStyleBackColor = true;
            // 
            // rbAntwortText1
            // 
            rbAntwortText1.AutoSize = true;
            rbAntwortText1.Font = new Font("Segoe UI", 27F);
            rbAntwortText1.Location = new Point(210, 30);
            rbAntwortText1.Name = "rbAntwortText1";
            rbAntwortText1.Size = new Size(184, 52);
            rbAntwortText1.TabIndex = 2;
            rbAntwortText1.TabStop = true;
            rbAntwortText1.Text = "Antwort1";
            rbAntwortText1.UseVisualStyleBackColor = true;
            // 
            // lbFrageText
            // 
            lbFrageText.AutoSize = true;
            lbFrageText.Font = new Font("Segoe UI", 27F);
            lbFrageText.Location = new Point(137, 119);
            lbFrageText.Name = "lbFrageText";
            lbFrageText.Size = new Size(690, 48);
            lbFrageText.TabIndex = 1;
            lbFrageText.Text = "Wie heißt die Hauptstadt von Deutschland";
            // 
            // lbFrage
            // 
            lbFrage.AutoSize = true;
            lbFrage.Font = new Font("Segoe UI", 27F);
            lbFrage.Location = new Point(137, 71);
            lbFrage.Name = "lbFrage";
            lbFrage.Size = new Size(117, 48);
            lbFrage.TabIndex = 0;
            lbFrage.Text = "Frage:";
            // 
            // Spiel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(tabControlSpiel);
            Name = "Spiel";
            Text = "Spiel";
            tabControlSpiel.ResumeLayout(false);
            tabPageKontinente.ResumeLayout(false);
            tabPageKontinente.PerformLayout();
            panelKontinentSelectAll.ResumeLayout(false);
            panelKontinentSelectAll.PerformLayout();
            panelKontinentSingleSelect.ResumeLayout(false);
            panelKontinentSingleSelect.PerformLayout();
            tabPageFrageAntworttyp.ResumeLayout(false);
            panelAtnworttyp.ResumeLayout(false);
            panelAtnworttyp.PerformLayout();
            panelFragentyp.ResumeLayout(false);
            panelFragentyp.PerformLayout();
            tabPageSpiel.ResumeLayout(false);
            panelSpielBildAntwort.ResumeLayout(false);
            panelSpielBildAntwort.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAntwort4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAntwort3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAntwort2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAntwort1).EndInit();
            panelSpielBildFrage.ResumeLayout(false);
            panelSpielBildFrage.PerformLayout();
            rbFlaggeAntwort.ResumeLayout(false);
            rbFlaggeAntwort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFrageFlagge).EndInit();
            panelSpielTextOnly.ResumeLayout(false);
            panelSpielTextOnly.PerformLayout();
            groupBoxTextOnly.ResumeLayout(false);
            groupBoxTextOnly.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlSpiel;
        private TabPage tabPageKontinente;
        private TabPage tabPageFrageAntworttyp;
        private CheckBox checkBoxAfrica;
        private CheckBox checkBoxAusOz;
        private CheckBox checkBoxNordamerika;
        private CheckBox checkBoxSuedamerika;
        private CheckBox checkBoxAsien;
        private CheckBox checkBoxEuropa;
        private CheckBox checkBoxAlle;
        private Label lbKontinente;
        private Button btnKontinentWeiter;
        private Panel panelKontinentSelectAll;
        private Panel panelKontinentSingleSelect;
        private Button btnSpielbeginnen;
        private Button btnFATZurueck;
        private Panel panelFragentyp;
        private RadioButton rbFragenHaupstadt;
        private RadioButton rbFrageLand;
        private RadioButton rbFrageFlaggen;
        private Label lbFragentyp;
        private Panel panelAtnworttyp;
        private RadioButton rbAntworttyp2;
        private RadioButton rbAntworttyp1;
        private Label lbAntworttyp;
        private TabPage tabPageSpiel;
        private Panel panelSpielTextOnly;
        private Label lbFrageText;
        private Label lbFrage;
        private RadioButton rbAntwortText4;
        private RadioButton rbAntwortText3;
        private RadioButton rbAntwortText2;
        private RadioButton rbAntwortText1;
        private Button btnTextOnlyNext;
        private Panel panelSpielBildFrage;
        private Label lbFrageBildText;
        private Label lbFrageBild;
        private GroupBox groupBoxTextOnly;
        private GroupBox rbFlaggeAntwort;
        private RadioButton rbAntwortFlagge4;
        private RadioButton rbAntwortFlagge3;
        private RadioButton rbAntwortFlagge2;
        private RadioButton rbAntwortFlagge1;
        private PictureBox pbFrageFlagge;
        private Button btnFlaggeAntwortNext;
        private Panel panelSpielBildAntwort;
        private Button btnAntwortBildNext;
        private GroupBox groupBox1;
        private PictureBox pbAntwort4;
        private PictureBox pbAntwort3;
        private PictureBox pbAntwort2;
        private PictureBox pbAntwort1;
        private RadioButton rbBildAntwort4;
        private RadioButton rbBildAntwort3;
        private RadioButton rbBildAntwort2;
        private RadioButton rbBildAntwort1;
        private Label lbAntwortBildFrageText;
        private Label lbAntwortBildFrage;
    }
}