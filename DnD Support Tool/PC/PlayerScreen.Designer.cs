namespace Formulars.PC
{
    partial class PlayerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerScreen));
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelCharacters = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCharacters = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNewCharacter = new System.Windows.Forms.Panel();
            this.buttonNewCharacterDiscard = new System.Windows.Forms.Button();
            this.buttonNewCharacterSave = new System.Windows.Forms.Button();
            this.textBoxNewCharacterWeight = new System.Windows.Forms.TextBox();
            this.textBoxNewCharacterHp = new System.Windows.Forms.TextBox();
            this.labelNewCharacterWeight = new System.Windows.Forms.Label();
            this.labelNewCharacterHp = new System.Windows.Forms.Label();
            this.textBoxNewCharacterName = new System.Windows.Forms.TextBox();
            this.labelNewCharacterName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMonstersHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddNewCharacter = new System.Windows.Forms.Button();
            this.labelCharacterList = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelCharacters.SuspendLayout();
            this.panelNewCharacter.SuspendLayout();
            this.panelMonstersHeader.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonMin.TabIndex = 7;
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
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
            this.buttonExit.TabIndex = 6;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panelBody.Location = new System.Drawing.Point(286, 31);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1152, 777);
            this.panelBody.TabIndex = 8;
            // 
            // panelCharacters
            // 
            this.panelCharacters.BackColor = System.Drawing.Color.Transparent;
            this.panelCharacters.Controls.Add(this.flowLayoutPanelCharacters);
            this.panelCharacters.Controls.Add(this.panelNewCharacter);
            this.panelCharacters.Controls.Add(this.panelMonstersHeader);
            this.panelCharacters.Location = new System.Drawing.Point(2, 31);
            this.panelCharacters.Name = "panelCharacters";
            this.panelCharacters.Size = new System.Drawing.Size(282, 777);
            this.panelCharacters.TabIndex = 9;
            // 
            // flowLayoutPanelCharacters
            // 
            this.flowLayoutPanelCharacters.AutoScroll = true;
            this.flowLayoutPanelCharacters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.flowLayoutPanelCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCharacters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCharacters.Location = new System.Drawing.Point(0, 165);
            this.flowLayoutPanelCharacters.Name = "flowLayoutPanelCharacters";
            this.flowLayoutPanelCharacters.Size = new System.Drawing.Size(282, 612);
            this.flowLayoutPanelCharacters.TabIndex = 8;
            this.flowLayoutPanelCharacters.WrapContents = false;
            // 
            // panelNewCharacter
            // 
            this.panelNewCharacter.BackColor = System.Drawing.Color.Transparent;
            this.panelNewCharacter.Controls.Add(this.buttonNewCharacterDiscard);
            this.panelNewCharacter.Controls.Add(this.buttonNewCharacterSave);
            this.panelNewCharacter.Controls.Add(this.textBoxNewCharacterWeight);
            this.panelNewCharacter.Controls.Add(this.textBoxNewCharacterHp);
            this.panelNewCharacter.Controls.Add(this.labelNewCharacterWeight);
            this.panelNewCharacter.Controls.Add(this.labelNewCharacterHp);
            this.panelNewCharacter.Controls.Add(this.textBoxNewCharacterName);
            this.panelNewCharacter.Controls.Add(this.labelNewCharacterName);
            this.panelNewCharacter.Controls.Add(this.panel4);
            this.panelNewCharacter.Controls.Add(this.panel3);
            this.panelNewCharacter.Controls.Add(this.panel2);
            this.panelNewCharacter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNewCharacter.Location = new System.Drawing.Point(0, 75);
            this.panelNewCharacter.Margin = new System.Windows.Forms.Padding(0);
            this.panelNewCharacter.Name = "panelNewCharacter";
            this.panelNewCharacter.Size = new System.Drawing.Size(282, 90);
            this.panelNewCharacter.TabIndex = 7;
            // 
            // buttonNewCharacterDiscard
            // 
            this.buttonNewCharacterDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonNewCharacterDiscard.FlatAppearance.BorderSize = 0;
            this.buttonNewCharacterDiscard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonNewCharacterDiscard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonNewCharacterDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewCharacterDiscard.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCharacterDiscard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonNewCharacterDiscard.Location = new System.Drawing.Point(192, 61);
            this.buttonNewCharacterDiscard.Name = "buttonNewCharacterDiscard";
            this.buttonNewCharacterDiscard.Size = new System.Drawing.Size(90, 28);
            this.buttonNewCharacterDiscard.TabIndex = 11;
            this.buttonNewCharacterDiscard.Text = "Discard";
            this.buttonNewCharacterDiscard.UseVisualStyleBackColor = false;
            this.buttonNewCharacterDiscard.Click += new System.EventHandler(this.ButtonNewCharacterDiscard_Click);
            // 
            // buttonNewCharacterSave
            // 
            this.buttonNewCharacterSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonNewCharacterSave.FlatAppearance.BorderSize = 0;
            this.buttonNewCharacterSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonNewCharacterSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonNewCharacterSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewCharacterSave.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCharacterSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonNewCharacterSave.Location = new System.Drawing.Point(192, 31);
            this.buttonNewCharacterSave.Name = "buttonNewCharacterSave";
            this.buttonNewCharacterSave.Size = new System.Drawing.Size(90, 28);
            this.buttonNewCharacterSave.TabIndex = 10;
            this.buttonNewCharacterSave.Text = "Save";
            this.buttonNewCharacterSave.UseVisualStyleBackColor = false;
            this.buttonNewCharacterSave.Click += new System.EventHandler(this.ButtonNewCharacterSave_Click);
            // 
            // textBoxNewCharacterWeight
            // 
            this.textBoxNewCharacterWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.textBoxNewCharacterWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewCharacterWeight.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewCharacterWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.textBoxNewCharacterWeight.Location = new System.Drawing.Point(146, 62);
            this.textBoxNewCharacterWeight.MaxLength = 3;
            this.textBoxNewCharacterWeight.Name = "textBoxNewCharacterWeight";
            this.textBoxNewCharacterWeight.Size = new System.Drawing.Size(43, 26);
            this.textBoxNewCharacterWeight.TabIndex = 8;
            this.textBoxNewCharacterWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNewCharacterWeight_KeyPress);
            // 
            // textBoxNewCharacterHp
            // 
            this.textBoxNewCharacterHp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.textBoxNewCharacterHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewCharacterHp.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewCharacterHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.textBoxNewCharacterHp.Location = new System.Drawing.Point(146, 32);
            this.textBoxNewCharacterHp.MaxLength = 3;
            this.textBoxNewCharacterHp.Name = "textBoxNewCharacterHp";
            this.textBoxNewCharacterHp.Size = new System.Drawing.Size(43, 26);
            this.textBoxNewCharacterHp.TabIndex = 7;
            this.textBoxNewCharacterHp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNewCharacterHp_KeyPress);
            // 
            // labelNewCharacterWeight
            // 
            this.labelNewCharacterWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelNewCharacterWeight.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewCharacterWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelNewCharacterWeight.Location = new System.Drawing.Point(0, 61);
            this.labelNewCharacterWeight.Margin = new System.Windows.Forms.Padding(3);
            this.labelNewCharacterWeight.Name = "labelNewCharacterWeight";
            this.labelNewCharacterWeight.Size = new System.Drawing.Size(144, 28);
            this.labelNewCharacterWeight.TabIndex = 6;
            this.labelNewCharacterWeight.Text = "Maximum Weight";
            this.labelNewCharacterWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNewCharacterHp
            // 
            this.labelNewCharacterHp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelNewCharacterHp.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewCharacterHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelNewCharacterHp.Location = new System.Drawing.Point(0, 31);
            this.labelNewCharacterHp.Margin = new System.Windows.Forms.Padding(3);
            this.labelNewCharacterHp.Name = "labelNewCharacterHp";
            this.labelNewCharacterHp.Size = new System.Drawing.Size(144, 28);
            this.labelNewCharacterHp.TabIndex = 5;
            this.labelNewCharacterHp.Text = "Maximum Hit Points";
            this.labelNewCharacterHp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNewCharacterName
            // 
            this.textBoxNewCharacterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(204)))));
            this.textBoxNewCharacterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewCharacterName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewCharacterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.textBoxNewCharacterName.Location = new System.Drawing.Point(52, 2);
            this.textBoxNewCharacterName.Name = "textBoxNewCharacterName";
            this.textBoxNewCharacterName.Size = new System.Drawing.Size(229, 26);
            this.textBoxNewCharacterName.TabIndex = 4;
            // 
            // labelNewCharacterName
            // 
            this.labelNewCharacterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelNewCharacterName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewCharacterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelNewCharacterName.Location = new System.Drawing.Point(0, 1);
            this.labelNewCharacterName.Margin = new System.Windows.Forms.Padding(3);
            this.labelNewCharacterName.Name = "labelNewCharacterName";
            this.labelNewCharacterName.Size = new System.Drawing.Size(50, 28);
            this.labelNewCharacterName.TabIndex = 2;
            this.labelNewCharacterName.Text = "Name";
            this.labelNewCharacterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panel4.Location = new System.Drawing.Point(144, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(46, 28);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panel3.Location = new System.Drawing.Point(144, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 28);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panel2.Location = new System.Drawing.Point(50, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 28);
            this.panel2.TabIndex = 12;
            // 
            // panelMonstersHeader
            // 
            this.panelMonstersHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelMonstersHeader.Controls.Add(this.panel1);
            this.panelMonstersHeader.Controls.Add(this.buttonAddNewCharacter);
            this.panelMonstersHeader.Controls.Add(this.labelCharacterList);
            this.panelMonstersHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMonstersHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMonstersHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelMonstersHeader.Name = "panelMonstersHeader";
            this.panelMonstersHeader.Size = new System.Drawing.Size(282, 75);
            this.panelMonstersHeader.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panel1.Location = new System.Drawing.Point(142, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 27);
            this.panel1.TabIndex = 4;
            // 
            // buttonAddNewCharacter
            // 
            this.buttonAddNewCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonAddNewCharacter.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddNewCharacter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonAddNewCharacter.FlatAppearance.BorderSize = 0;
            this.buttonAddNewCharacter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonAddNewCharacter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonAddNewCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewCharacter.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewCharacter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonAddNewCharacter.Location = new System.Drawing.Point(0, 46);
            this.buttonAddNewCharacter.Name = "buttonAddNewCharacter";
            this.buttonAddNewCharacter.Size = new System.Drawing.Size(140, 27);
            this.buttonAddNewCharacter.TabIndex = 3;
            this.buttonAddNewCharacter.Text = "Add New";
            this.buttonAddNewCharacter.UseVisualStyleBackColor = false;
            this.buttonAddNewCharacter.Click += new System.EventHandler(this.ButtonAddNewCharacter_Click);
            // 
            // labelCharacterList
            // 
            this.labelCharacterList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelCharacterList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCharacterList.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCharacterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCharacterList.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharacterList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelCharacterList.Location = new System.Drawing.Point(-1, 0);
            this.labelCharacterList.Margin = new System.Windows.Forms.Padding(0);
            this.labelCharacterList.Name = "labelCharacterList";
            this.labelCharacterList.Size = new System.Drawing.Size(284, 44);
            this.labelCharacterList.TabIndex = 2;
            this.labelCharacterList.Text = "Characters";
            this.labelCharacterList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // PlayerScreenCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.panelCharacters);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerScreenCorrect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerScreenCorrect";
            this.panelCharacters.ResumeLayout(false);
            this.panelNewCharacter.ResumeLayout(false);
            this.panelNewCharacter.PerformLayout();
            this.panelMonstersHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelCharacters;
        private System.Windows.Forms.Panel panelMonstersHeader;
        private System.Windows.Forms.Button buttonAddNewCharacter;
        private System.Windows.Forms.Label labelCharacterList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelNewCharacter;
        private System.Windows.Forms.Label labelNewCharacterName;
        private System.Windows.Forms.TextBox textBoxNewCharacterName;
        private System.Windows.Forms.Label labelNewCharacterHp;
        private System.Windows.Forms.Label labelNewCharacterWeight;
        private System.Windows.Forms.TextBox textBoxNewCharacterHp;
        private System.Windows.Forms.TextBox textBoxNewCharacterWeight;
        private System.Windows.Forms.Button buttonNewCharacterSave;
        private System.Windows.Forms.Button buttonNewCharacterDiscard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCharacters;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonBack;
    }
}