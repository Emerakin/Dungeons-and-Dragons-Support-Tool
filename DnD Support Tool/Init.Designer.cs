namespace Formulars
{
    partial class Init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            this.buttonDM = new System.Windows.Forms.Button();
            this.buttonPC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDM
            // 
            this.buttonDM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDM.BackColor = System.Drawing.Color.Transparent;
            this.buttonDM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonDM.FlatAppearance.BorderSize = 0;
            this.buttonDM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonDM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDM.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonDM.Location = new System.Drawing.Point(0, 0);
            this.buttonDM.Name = "buttonDM";
            this.buttonDM.Size = new System.Drawing.Size(200, 45);
            this.buttonDM.TabIndex = 0;
            this.buttonDM.Text = "Dungeon Master";
            this.buttonDM.UseVisualStyleBackColor = false;
            this.buttonDM.Click += new System.EventHandler(this.ButtonDM_Click);
            // 
            // buttonPC
            // 
            this.buttonPC.BackColor = System.Drawing.Color.Transparent;
            this.buttonPC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonPC.FlatAppearance.BorderSize = 0;
            this.buttonPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPC.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonPC.Location = new System.Drawing.Point(0, 55);
            this.buttonPC.Name = "buttonPC";
            this.buttonPC.Size = new System.Drawing.Size(200, 45);
            this.buttonPC.TabIndex = 1;
            this.buttonPC.Text = "Player";
            this.buttonPC.UseVisualStyleBackColor = false;
            this.buttonPC.Click += new System.EventHandler(this.ButtonPC_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::Formulars.Properties.Resources.init_schoose;
            this.panel1.Controls.Add(this.buttonDM);
            this.panel1.Controls.Add(this.buttonPC);
            this.panel1.Location = new System.Drawing.Point(60, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelName.Location = new System.Drawing.Point(30, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(260, 57);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Dungeons and Dragons\r\nSupport Tool";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::Formulars.Properties.Resources.exit_icon_new;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(290, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.Transparent;
            this.buttonMin.BackgroundImage = global::Formulars.Properties.Resources.init_min_icon;
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMin.Location = new System.Drawing.Point(260, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(30, 30);
            this.buttonMin.TabIndex = 4;
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.BackgroundImage = global::Formulars.Properties.Resources.init1;
            this.ClientSize = new System.Drawing.Size(320, 210);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Init";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D&D Support Tool";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Init_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDM;
        private System.Windows.Forms.Button buttonPC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMin;
    }
}

