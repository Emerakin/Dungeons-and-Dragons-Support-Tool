namespace Formulars.DM
{
    partial class DungeonMasterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DungeonMasterScreen));
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelMonsters = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMonsters = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSaveDiscardNewMonster = new System.Windows.Forms.Panel();
            this.buttonNewMonsterDicard = new System.Windows.Forms.Button();
            this.buttonNewMonsterSave = new System.Windows.Forms.Button();
            this.panelFilterMonster = new System.Windows.Forms.Panel();
            this.comboBoxFilterMonsterAligment = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterMonsterType = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterMonsterSize = new System.Windows.Forms.ComboBox();
            this.textBoxFilterMonsterName = new System.Windows.Forms.TextBox();
            this.labelFilterMonsterAligment = new System.Windows.Forms.Label();
            this.labelFilterMonsterType = new System.Windows.Forms.Label();
            this.labelFilterMonsterSize = new System.Windows.Forms.Label();
            this.labelFilterMonsterName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMonstersHeader = new System.Windows.Forms.Panel();
            this.buttonFilterMonsters = new System.Windows.Forms.Button();
            this.buttonAddNewMonster = new System.Windows.Forms.Button();
            this.labelMonsterList = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelMonsters.SuspendLayout();
            this.panelSaveDiscardNewMonster.SuspendLayout();
            this.panelFilterMonster.SuspendLayout();
            this.panelMonstersHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelHeader.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelHeader.Location = new System.Drawing.Point(61, 2);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(3);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Padding = new System.Windows.Forms.Padding(3);
            this.labelHeader.Size = new System.Drawing.Size(1318, 27);
            this.labelHeader.TabIndex = 4;
            this.labelHeader.Text = "Dungeons and Dragons Support Tool";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelHeader_MouseDown);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panelBody.Location = new System.Drawing.Point(286, 31);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1152, 777);
            this.panelBody.TabIndex = 2;
            // 
            // panelMonsters
            // 
            this.panelMonsters.BackColor = System.Drawing.Color.Transparent;
            this.panelMonsters.Controls.Add(this.flowLayoutPanelMonsters);
            this.panelMonsters.Controls.Add(this.panelSaveDiscardNewMonster);
            this.panelMonsters.Controls.Add(this.panelFilterMonster);
            this.panelMonsters.Controls.Add(this.panelMonstersHeader);
            this.panelMonsters.Location = new System.Drawing.Point(2, 31);
            this.panelMonsters.Name = "panelMonsters";
            this.panelMonsters.Size = new System.Drawing.Size(282, 777);
            this.panelMonsters.TabIndex = 3;
            // 
            // flowLayoutPanelMonsters
            // 
            this.flowLayoutPanelMonsters.AutoScroll = true;
            this.flowLayoutPanelMonsters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.flowLayoutPanelMonsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMonsters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMonsters.Location = new System.Drawing.Point(0, 225);
            this.flowLayoutPanelMonsters.Name = "flowLayoutPanelMonsters";
            this.flowLayoutPanelMonsters.Size = new System.Drawing.Size(282, 552);
            this.flowLayoutPanelMonsters.TabIndex = 10;
            this.flowLayoutPanelMonsters.WrapContents = false;
            // 
            // panelSaveDiscardNewMonster
            // 
            this.panelSaveDiscardNewMonster.BackColor = System.Drawing.Color.Transparent;
            this.panelSaveDiscardNewMonster.Controls.Add(this.buttonNewMonsterDicard);
            this.panelSaveDiscardNewMonster.Controls.Add(this.buttonNewMonsterSave);
            this.panelSaveDiscardNewMonster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaveDiscardNewMonster.Location = new System.Drawing.Point(0, 195);
            this.panelSaveDiscardNewMonster.Name = "panelSaveDiscardNewMonster";
            this.panelSaveDiscardNewMonster.Size = new System.Drawing.Size(282, 30);
            this.panelSaveDiscardNewMonster.TabIndex = 8;
            // 
            // buttonNewMonsterDicard
            // 
            this.buttonNewMonsterDicard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonNewMonsterDicard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonNewMonsterDicard.FlatAppearance.BorderSize = 0;
            this.buttonNewMonsterDicard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonNewMonsterDicard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonNewMonsterDicard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewMonsterDicard.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewMonsterDicard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonNewMonsterDicard.Location = new System.Drawing.Point(142, 1);
            this.buttonNewMonsterDicard.Name = "buttonNewMonsterDicard";
            this.buttonNewMonsterDicard.Size = new System.Drawing.Size(140, 27);
            this.buttonNewMonsterDicard.TabIndex = 1;
            this.buttonNewMonsterDicard.Text = "Discard";
            this.buttonNewMonsterDicard.UseVisualStyleBackColor = false;
            this.buttonNewMonsterDicard.Click += new System.EventHandler(this.ButtonNewMonsterDicard_Click);
            // 
            // buttonNewMonsterSave
            // 
            this.buttonNewMonsterSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonNewMonsterSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonNewMonsterSave.FlatAppearance.BorderSize = 0;
            this.buttonNewMonsterSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonNewMonsterSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonNewMonsterSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewMonsterSave.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewMonsterSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonNewMonsterSave.Location = new System.Drawing.Point(0, 1);
            this.buttonNewMonsterSave.Name = "buttonNewMonsterSave";
            this.buttonNewMonsterSave.Size = new System.Drawing.Size(140, 27);
            this.buttonNewMonsterSave.TabIndex = 0;
            this.buttonNewMonsterSave.Text = "Save";
            this.buttonNewMonsterSave.UseVisualStyleBackColor = false;
            this.buttonNewMonsterSave.Click += new System.EventHandler(this.ButtonNewMonsterSave_Click);
            // 
            // panelFilterMonster
            // 
            this.panelFilterMonster.BackColor = System.Drawing.Color.Transparent;
            this.panelFilterMonster.Controls.Add(this.comboBoxFilterMonsterAligment);
            this.panelFilterMonster.Controls.Add(this.comboBoxFilterMonsterType);
            this.panelFilterMonster.Controls.Add(this.comboBoxFilterMonsterSize);
            this.panelFilterMonster.Controls.Add(this.textBoxFilterMonsterName);
            this.panelFilterMonster.Controls.Add(this.labelFilterMonsterAligment);
            this.panelFilterMonster.Controls.Add(this.labelFilterMonsterType);
            this.panelFilterMonster.Controls.Add(this.labelFilterMonsterSize);
            this.panelFilterMonster.Controls.Add(this.labelFilterMonsterName);
            this.panelFilterMonster.Controls.Add(this.panel1);
            this.panelFilterMonster.Controls.Add(this.panel2);
            this.panelFilterMonster.Controls.Add(this.panel3);
            this.panelFilterMonster.Controls.Add(this.panel4);
            this.panelFilterMonster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterMonster.Location = new System.Drawing.Point(0, 75);
            this.panelFilterMonster.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilterMonster.Name = "panelFilterMonster";
            this.panelFilterMonster.Size = new System.Drawing.Size(282, 120);
            this.panelFilterMonster.TabIndex = 7;
            // 
            // comboBoxFilterMonsterAligment
            // 
            this.comboBoxFilterMonsterAligment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.comboBoxFilterMonsterAligment.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterMonsterAligment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.comboBoxFilterMonsterAligment.FormattingEnabled = true;
            this.comboBoxFilterMonsterAligment.Items.AddRange(new object[] {
            "All",
            "Any",
            "Unaligned",
            "Lawful Good",
            "Neutral Good",
            "Chaotic Good",
            "Lawful Neutral",
            "True Neutral",
            "Chaotic Neutral",
            "Lawful Evil",
            "Neutral Evil",
            "Chaotic Evil"});
            this.comboBoxFilterMonsterAligment.Location = new System.Drawing.Point(72, 92);
            this.comboBoxFilterMonsterAligment.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxFilterMonsterAligment.Name = "comboBoxFilterMonsterAligment";
            this.comboBoxFilterMonsterAligment.Size = new System.Drawing.Size(209, 26);
            this.comboBoxFilterMonsterAligment.TabIndex = 8;
            this.comboBoxFilterMonsterAligment.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxFilterMonsterAligment_SelectionChangeCommitted);
            // 
            // comboBoxFilterMonsterType
            // 
            this.comboBoxFilterMonsterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.comboBoxFilterMonsterType.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterMonsterType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.comboBoxFilterMonsterType.FormattingEnabled = true;
            this.comboBoxFilterMonsterType.Items.AddRange(new object[] {
            "All",
            "Abberation",
            "Beast",
            "Celestial",
            "Construct",
            "Dragon",
            "Elemental",
            "Fey",
            "Fiend",
            "Giant",
            "Humanoid",
            "Monstrosity",
            "Ooze",
            "Plant",
            "Undead"});
            this.comboBoxFilterMonsterType.Location = new System.Drawing.Point(72, 62);
            this.comboBoxFilterMonsterType.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxFilterMonsterType.Name = "comboBoxFilterMonsterType";
            this.comboBoxFilterMonsterType.Size = new System.Drawing.Size(209, 26);
            this.comboBoxFilterMonsterType.TabIndex = 7;
            this.comboBoxFilterMonsterType.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxFilterMonsterType_SelectionChangeCommitted);
            // 
            // comboBoxFilterMonsterSize
            // 
            this.comboBoxFilterMonsterSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.comboBoxFilterMonsterSize.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterMonsterSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.comboBoxFilterMonsterSize.FormattingEnabled = true;
            this.comboBoxFilterMonsterSize.Items.AddRange(new object[] {
            "All",
            "Tiny",
            "Small",
            "Medium",
            "Large",
            "Huge",
            "Gargantuan"});
            this.comboBoxFilterMonsterSize.Location = new System.Drawing.Point(72, 32);
            this.comboBoxFilterMonsterSize.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxFilterMonsterSize.Name = "comboBoxFilterMonsterSize";
            this.comboBoxFilterMonsterSize.Size = new System.Drawing.Size(209, 26);
            this.comboBoxFilterMonsterSize.TabIndex = 6;
            this.comboBoxFilterMonsterSize.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxFilterMonsterSize_SelectionChangeCommitted);
            // 
            // textBoxFilterMonsterName
            // 
            this.textBoxFilterMonsterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.textBoxFilterMonsterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilterMonsterName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterMonsterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.textBoxFilterMonsterName.Location = new System.Drawing.Point(72, 2);
            this.textBoxFilterMonsterName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFilterMonsterName.Name = "textBoxFilterMonsterName";
            this.textBoxFilterMonsterName.Size = new System.Drawing.Size(209, 26);
            this.textBoxFilterMonsterName.TabIndex = 5;
            this.textBoxFilterMonsterName.TextChanged += new System.EventHandler(this.TextBoxFilterMonsterName_TextChanged);
            // 
            // labelFilterMonsterAligment
            // 
            this.labelFilterMonsterAligment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelFilterMonsterAligment.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterMonsterAligment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelFilterMonsterAligment.Location = new System.Drawing.Point(0, 91);
            this.labelFilterMonsterAligment.Margin = new System.Windows.Forms.Padding(3);
            this.labelFilterMonsterAligment.Name = "labelFilterMonsterAligment";
            this.labelFilterMonsterAligment.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelFilterMonsterAligment.Size = new System.Drawing.Size(70, 27);
            this.labelFilterMonsterAligment.TabIndex = 4;
            this.labelFilterMonsterAligment.Text = "Aligment";
            this.labelFilterMonsterAligment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFilterMonsterType
            // 
            this.labelFilterMonsterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelFilterMonsterType.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterMonsterType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelFilterMonsterType.Location = new System.Drawing.Point(0, 61);
            this.labelFilterMonsterType.Margin = new System.Windows.Forms.Padding(3);
            this.labelFilterMonsterType.Name = "labelFilterMonsterType";
            this.labelFilterMonsterType.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelFilterMonsterType.Size = new System.Drawing.Size(70, 28);
            this.labelFilterMonsterType.TabIndex = 3;
            this.labelFilterMonsterType.Text = "Type";
            this.labelFilterMonsterType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFilterMonsterSize
            // 
            this.labelFilterMonsterSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelFilterMonsterSize.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterMonsterSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelFilterMonsterSize.Location = new System.Drawing.Point(0, 31);
            this.labelFilterMonsterSize.Margin = new System.Windows.Forms.Padding(3);
            this.labelFilterMonsterSize.Name = "labelFilterMonsterSize";
            this.labelFilterMonsterSize.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelFilterMonsterSize.Size = new System.Drawing.Size(70, 28);
            this.labelFilterMonsterSize.TabIndex = 2;
            this.labelFilterMonsterSize.Text = "Size";
            this.labelFilterMonsterSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFilterMonsterName
            // 
            this.labelFilterMonsterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelFilterMonsterName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterMonsterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelFilterMonsterName.Location = new System.Drawing.Point(0, 1);
            this.labelFilterMonsterName.Margin = new System.Windows.Forms.Padding(3);
            this.labelFilterMonsterName.Name = "labelFilterMonsterName";
            this.labelFilterMonsterName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelFilterMonsterName.Size = new System.Drawing.Size(70, 28);
            this.labelFilterMonsterName.TabIndex = 1;
            this.labelFilterMonsterName.Text = "Name";
            this.labelFilterMonsterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panel1.Location = new System.Drawing.Point(70, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 28);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panel2.Location = new System.Drawing.Point(70, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 28);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panel3.Location = new System.Drawing.Point(70, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 28);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panel4.Location = new System.Drawing.Point(70, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 28);
            this.panel4.TabIndex = 10;
            // 
            // panelMonstersHeader
            // 
            this.panelMonstersHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelMonstersHeader.Controls.Add(this.buttonFilterMonsters);
            this.panelMonstersHeader.Controls.Add(this.buttonAddNewMonster);
            this.panelMonstersHeader.Controls.Add(this.labelMonsterList);
            this.panelMonstersHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMonstersHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMonstersHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelMonstersHeader.Name = "panelMonstersHeader";
            this.panelMonstersHeader.Size = new System.Drawing.Size(282, 75);
            this.panelMonstersHeader.TabIndex = 5;
            // 
            // buttonFilterMonsters
            // 
            this.buttonFilterMonsters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonFilterMonsters.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonFilterMonsters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonFilterMonsters.FlatAppearance.BorderSize = 0;
            this.buttonFilterMonsters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonFilterMonsters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonFilterMonsters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilterMonsters.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilterMonsters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonFilterMonsters.Location = new System.Drawing.Point(142, 46);
            this.buttonFilterMonsters.Name = "buttonFilterMonsters";
            this.buttonFilterMonsters.Size = new System.Drawing.Size(140, 27);
            this.buttonFilterMonsters.TabIndex = 4;
            this.buttonFilterMonsters.Text = "Filter";
            this.buttonFilterMonsters.UseVisualStyleBackColor = false;
            this.buttonFilterMonsters.Click += new System.EventHandler(this.ButtonFilterMonsters_Click);
            // 
            // buttonAddNewMonster
            // 
            this.buttonAddNewMonster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonAddNewMonster.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddNewMonster.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonAddNewMonster.FlatAppearance.BorderSize = 0;
            this.buttonAddNewMonster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonAddNewMonster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonAddNewMonster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewMonster.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewMonster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonAddNewMonster.Location = new System.Drawing.Point(0, 46);
            this.buttonAddNewMonster.Name = "buttonAddNewMonster";
            this.buttonAddNewMonster.Size = new System.Drawing.Size(140, 27);
            this.buttonAddNewMonster.TabIndex = 3;
            this.buttonAddNewMonster.Text = "Add New";
            this.buttonAddNewMonster.UseVisualStyleBackColor = false;
            this.buttonAddNewMonster.Click += new System.EventHandler(this.ButtonAddNewMonster_Click);
            // 
            // labelMonsterList
            // 
            this.labelMonsterList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelMonsterList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMonsterList.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMonsterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMonsterList.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonsterList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelMonsterList.Location = new System.Drawing.Point(-1, 0);
            this.labelMonsterList.Margin = new System.Windows.Forms.Padding(0);
            this.labelMonsterList.Name = "labelMonsterList";
            this.labelMonsterList.Size = new System.Drawing.Size(284, 44);
            this.labelMonsterList.TabIndex = 2;
            this.labelMonsterList.Text = "Monsters";
            this.labelMonsterList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonExit.BackgroundImage = global::Formulars.Properties.Resources.exit_icon_new;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonExit.Location = new System.Drawing.Point(1411, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 27);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonMin.BackgroundImage = global::Formulars.Properties.Resources.minimize_icon;
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMin.Location = new System.Drawing.Point(1381, 2);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(28, 27);
            this.buttonMin.TabIndex = 5;
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonBack.Location = new System.Drawing.Point(2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(57, 27);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // DungeonMasterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelMonsters);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DungeonMasterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DungeonMasterScreenCorrect";
            this.panelMonsters.ResumeLayout(false);
            this.panelSaveDiscardNewMonster.ResumeLayout(false);
            this.panelFilterMonster.ResumeLayout(false);
            this.panelFilterMonster.PerformLayout();
            this.panelMonstersHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelMonsters;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Panel panelMonstersHeader;
        private System.Windows.Forms.Button buttonFilterMonsters;
        private System.Windows.Forms.Button buttonAddNewMonster;
        private System.Windows.Forms.Label labelMonsterList;
        private System.Windows.Forms.Panel panelSaveDiscardNewMonster;
        private System.Windows.Forms.Button buttonNewMonsterDicard;
        private System.Windows.Forms.Button buttonNewMonsterSave;
        private System.Windows.Forms.Panel panelFilterMonster;
        private System.Windows.Forms.ComboBox comboBoxFilterMonsterAligment;
        private System.Windows.Forms.ComboBox comboBoxFilterMonsterType;
        private System.Windows.Forms.ComboBox comboBoxFilterMonsterSize;
        private System.Windows.Forms.TextBox textBoxFilterMonsterName;
        private System.Windows.Forms.Label labelFilterMonsterAligment;
        private System.Windows.Forms.Label labelFilterMonsterType;
        private System.Windows.Forms.Label labelFilterMonsterSize;
        private System.Windows.Forms.Label labelFilterMonsterName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMonsters;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBack;
    }
}