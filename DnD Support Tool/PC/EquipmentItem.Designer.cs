namespace Formulars.PC
{
    partial class EquipmentItem
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonEquip = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelName.Location = new System.Drawing.Point(73, 2);
            this.labelName.Margin = new System.Windows.Forms.Padding(3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(210, 27);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // buttonEquip
            // 
            this.buttonEquip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.buttonEquip.FlatAppearance.BorderSize = 0;
            this.buttonEquip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(169)))), ((int)(((byte)(118)))));
            this.buttonEquip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(194)))), ((int)(((byte)(148)))));
            this.buttonEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquip.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.buttonEquip.Location = new System.Drawing.Point(285, 2);
            this.buttonEquip.Name = "buttonEquip";
            this.buttonEquip.Size = new System.Drawing.Size(71, 27);
            this.buttonEquip.TabIndex = 12;
            this.buttonEquip.Text = "Unequip";
            this.buttonEquip.UseVisualStyleBackColor = false;
            this.buttonEquip.Click += new System.EventHandler(this.ButtonEquip_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelCategory.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelCategory.Location = new System.Drawing.Point(2, 31);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(3);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(354, 28);
            this.labelCategory.TabIndex = 10;
            this.labelCategory.Text = "Category: ";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWeight
            // 
            this.labelWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelWeight.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelWeight.Location = new System.Drawing.Point(180, 61);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(3);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(176, 28);
            this.labelWeight.TabIndex = 11;
            this.labelWeight.Text = "Weight: ";
            this.labelWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCost
            // 
            this.labelCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.labelCost.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.labelCost.Location = new System.Drawing.Point(2, 61);
            this.labelCost.Margin = new System.Windows.Forms.Padding(3);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(176, 28);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "Cost: ";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 27);
            this.panel1.TabIndex = 14;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(179)))));
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.richTextBoxDescription.Location = new System.Drawing.Point(2, 91);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxDescription.Size = new System.Drawing.Size(354, 357);
            this.richTextBoxDescription.TabIndex = 15;
            this.richTextBoxDescription.Text = "Description";
            // 
            // EquipmentItemCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(84)))), ((int)(((byte)(11)))));
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonEquip);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelCost);
            this.Name = "EquipmentItemCorrect";
            this.Size = new System.Drawing.Size(358, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonEquip;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
    }
}