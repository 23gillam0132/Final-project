namespace TheAntsWhoClimbedMountFloral
{
    partial class Form1
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
            this.labelAntCount = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.panelMountain = new System.Windows.Forms.Panel();
            this.textBoxExStatus = new System.Windows.Forms.TextBox();
            this.labelItems = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAchievement = new System.Windows.Forms.TabPage();
            this.tabPageRecipes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRecipeUnlock = new System.Windows.Forms.Label();
            this.pictureBoxAch = new System.Windows.Forms.PictureBox();
            this.labelAchDescription = new System.Windows.Forms.Label();
            this.labelAchName = new System.Windows.Forms.Label();
            this.labelAchievementUnlocked = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAch)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAntCount
            // 
            this.labelAntCount.AutoSize = true;
            this.labelAntCount.Location = new System.Drawing.Point(476, 342);
            this.labelAntCount.Name = "labelAntCount";
            this.labelAntCount.Size = new System.Drawing.Size(92, 15);
            this.labelAntCount.TabIndex = 0;
            this.labelAntCount.Text = "You have 0 ants.";
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(493, 363);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 75);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send ant";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // panelMountain
            // 
            this.panelMountain.BackColor = System.Drawing.Color.PowderBlue;
            this.panelMountain.Location = new System.Drawing.Point(574, 33);
            this.panelMountain.Name = "panelMountain";
            this.panelMountain.Size = new System.Drawing.Size(200, 324);
            this.panelMountain.TabIndex = 2;
            // 
            // textBoxExStatus
            // 
            this.textBoxExStatus.Enabled = false;
            this.textBoxExStatus.Location = new System.Drawing.Point(574, 363);
            this.textBoxExStatus.Multiline = true;
            this.textBoxExStatus.Name = "textBoxExStatus";
            this.textBoxExStatus.ReadOnly = true;
            this.textBoxExStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExStatus.Size = new System.Drawing.Size(200, 75);
            this.textBoxExStatus.TabIndex = 3;
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(8, 33);
            this.labelItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(69, 15);
            this.labelItems.TabIndex = 4;
            this.labelItems.Text = "INVENTORY";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAchievement);
            this.tabControl1.Controls.Add(this.tabPageRecipes);
            this.tabControl1.Location = new System.Drawing.Point(255, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(313, 282);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageAchievement
            // 
            this.tabPageAchievement.Location = new System.Drawing.Point(4, 24);
            this.tabPageAchievement.Name = "tabPageAchievement";
            this.tabPageAchievement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAchievement.Size = new System.Drawing.Size(305, 254);
            this.tabPageAchievement.TabIndex = 0;
            this.tabPageAchievement.Text = "Achievements";
            this.tabPageAchievement.UseVisualStyleBackColor = true;
            // 
            // tabPageRecipes
            // 
            this.tabPageRecipes.Location = new System.Drawing.Point(4, 24);
            this.tabPageRecipes.Name = "tabPageRecipes";
            this.tabPageRecipes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecipes.Size = new System.Drawing.Size(305, 254);
            this.tabPageRecipes.TabIndex = 1;
            this.tabPageRecipes.Text = "Recipes";
            this.tabPageRecipes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.labelRecipeUnlock);
            this.panel1.Controls.Add(this.pictureBoxAch);
            this.panel1.Controls.Add(this.labelAchDescription);
            this.panel1.Controls.Add(this.labelAchName);
            this.panel1.Location = new System.Drawing.Point(259, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 121);
            this.panel1.TabIndex = 7;
            // 
            // labelRecipeUnlock
            // 
            this.labelRecipeUnlock.AutoSize = true;
            this.labelRecipeUnlock.Location = new System.Drawing.Point(3, 95);
            this.labelRecipeUnlock.Name = "labelRecipeUnlock";
            this.labelRecipeUnlock.Size = new System.Drawing.Size(38, 15);
            this.labelRecipeUnlock.TabIndex = 3;
            this.labelRecipeUnlock.Text = "label1";
            // 
            // pictureBoxAch
            // 
            this.pictureBoxAch.Location = new System.Drawing.Point(150, 0);
            this.pictureBoxAch.Name = "pictureBoxAch";
            this.pictureBoxAch.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAch.TabIndex = 2;
            this.pictureBoxAch.TabStop = false;
            // 
            // labelAchDescription
            // 
            this.labelAchDescription.AutoSize = true;
            this.labelAchDescription.Location = new System.Drawing.Point(3, 49);
            this.labelAchDescription.MaximumSize = new System.Drawing.Size(190, 0);
            this.labelAchDescription.Name = "labelAchDescription";
            this.labelAchDescription.Size = new System.Drawing.Size(38, 15);
            this.labelAchDescription.TabIndex = 1;
            this.labelAchDescription.Text = "label1";
            // 
            // labelAchName
            // 
            this.labelAchName.AutoSize = true;
            this.labelAchName.Location = new System.Drawing.Point(3, 10);
            this.labelAchName.MaximumSize = new System.Drawing.Size(160, 0);
            this.labelAchName.Name = "labelAchName";
            this.labelAchName.Size = new System.Drawing.Size(38, 15);
            this.labelAchName.TabIndex = 0;
            this.labelAchName.Text = "label1";
            // 
            // labelAchievementUnlocked
            // 
            this.labelAchievementUnlocked.AutoSize = true;
            this.labelAchievementUnlocked.BackColor = System.Drawing.Color.Lime;
            this.labelAchievementUnlocked.Location = new System.Drawing.Point(255, 9);
            this.labelAchievementUnlocked.Name = "labelAchievementUnlocked";
            this.labelAchievementUnlocked.Size = new System.Drawing.Size(133, 15);
            this.labelAchievementUnlocked.TabIndex = 8;
            this.labelAchievementUnlocked.Text = "Achievement Unlocked:";
            this.labelAchievementUnlocked.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAchievementUnlocked);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.textBoxExStatus);
            this.Controls.Add(this.panelMountain);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelAntCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAntCount;
        private Button buttonSend;
        private Panel panelMountain;
        private TextBox textBoxExStatus;
        private Label labelItems;
        private TabControl tabControl1;
        private TabPage tabPageAchievement;
        private TabPage tabPageRecipes;
        private Panel panel1;
        private PictureBox pictureBoxAch;
        private Label labelAchDescription;
        private Label labelAchName;
        private Label labelRecipeUnlock;
        private Label labelAchievementUnlocked;
    }
}