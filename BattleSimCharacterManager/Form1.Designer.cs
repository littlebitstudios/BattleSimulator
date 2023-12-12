namespace BattleSimCharacterManager
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadCharacterListFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            aboutThisAppToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            charSelectBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            nameBox = new TextBox();
            startHealthBox = new NumericUpDown();
            maxHealthBox = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            minDmgBox = new NumericUpDown();
            maxDmgBox = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            maxHealBox = new NumericUpDown();
            minHealBox = new NumericUpDown();
            label10 = new Label();
            healCheckBox = new CheckBox();
            newButton = new Button();
            saveButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)startHealthBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxHealthBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minDmgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxDmgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxHealBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minHealBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(461, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadCharacterListFileToolStripMenuItem, toolStripSeparator1, quitToolStripMenuItem, aboutThisAppToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadCharacterListFileToolStripMenuItem
            // 
            loadCharacterListFileToolStripMenuItem.Name = "loadCharacterListFileToolStripMenuItem";
            loadCharacterListFileToolStripMenuItem.Size = new Size(196, 22);
            loadCharacterListFileToolStripMenuItem.Text = "Load Character List File";
            loadCharacterListFileToolStripMenuItem.Click += loadCharacterListFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(193, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(196, 22);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // aboutThisAppToolStripMenuItem
            // 
            aboutThisAppToolStripMenuItem.Name = "aboutThisAppToolStripMenuItem";
            aboutThisAppToolStripMenuItem.Size = new Size(196, 22);
            aboutThisAppToolStripMenuItem.Text = "About This App";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Selected Character";
            // 
            // charSelectBox
            // 
            charSelectBox.FormattingEnabled = true;
            charSelectBox.Location = new Point(139, 40);
            charSelectBox.Name = "charSelectBox";
            charSelectBox.Size = new Size(217, 23);
            charSelectBox.TabIndex = 2;
            charSelectBox.SelectedIndexChanged += charSelectBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 121);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 4;
            label3.Text = "Starting Health";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(73, 79);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(363, 23);
            nameBox.TabIndex = 5;
            // 
            // startHealthBox
            // 
            startHealthBox.Location = new Point(141, 119);
            startHealthBox.Name = "startHealthBox";
            startHealthBox.Size = new Size(82, 23);
            startHealthBox.TabIndex = 6;
            // 
            // maxHealthBox
            // 
            maxHealthBox.Location = new Point(332, 119);
            maxHealthBox.Name = "maxHealthBox";
            maxHealthBox.Size = new Size(82, 23);
            maxHealthBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 121);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Max Health";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 184);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Damage";
            // 
            // minDmgBox
            // 
            minDmgBox.Location = new Point(162, 181);
            minDmgBox.Name = "minDmgBox";
            minDmgBox.Size = new Size(82, 23);
            minDmgBox.TabIndex = 10;
            // 
            // maxDmgBox
            // 
            maxDmgBox.Location = new Point(258, 182);
            maxDmgBox.Name = "maxDmgBox";
            maxDmgBox.Size = new Size(82, 23);
            maxDmgBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 163);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 12;
            label6.Text = "Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(281, 163);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 13;
            label7.Text = "Max";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(355, 220);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 18;
            label8.Text = "Max";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(261, 221);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 17;
            label9.Text = "Min";
            // 
            // maxHealBox
            // 
            maxHealBox.Location = new Point(332, 239);
            maxHealBox.Name = "maxHealBox";
            maxHealBox.Size = new Size(82, 23);
            maxHealBox.TabIndex = 16;
            // 
            // minHealBox
            // 
            minHealBox.Location = new Point(236, 239);
            minHealBox.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            minHealBox.Name = "minHealBox";
            minHealBox.Size = new Size(82, 23);
            minHealBox.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 240);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 14;
            label10.Text = "Healing";
            // 
            // healCheckBox
            // 
            healCheckBox.AutoSize = true;
            healCheckBox.Location = new Point(115, 239);
            healCheckBox.Name = "healCheckBox";
            healCheckBox.Size = new Size(105, 19);
            healCheckBox.TabIndex = 19;
            healCheckBox.Text = "Enable Healing";
            healCheckBox.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            newButton.Location = new Point(361, 40);
            newButton.Name = "newButton";
            newButton.Size = new Size(75, 23);
            newButton.TabIndex = 20;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(176, 281);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(113, 23);
            saveButton.TabIndex = 21;
            saveButton.Text = "Save Character";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 325);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(healCheckBox);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(maxHealBox);
            Controls.Add(minHealBox);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(maxDmgBox);
            Controls.Add(minDmgBox);
            Controls.Add(label5);
            Controls.Add(maxHealthBox);
            Controls.Add(label4);
            Controls.Add(startHealthBox);
            Controls.Add(nameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(charSelectBox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Battle Simulator: Character Manager";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)startHealthBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxHealthBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minDmgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxDmgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxHealBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)minHealBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadCharacterListFileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem aboutThisAppToolStripMenuItem;
        private Label label1;
        private ComboBox charSelectBox;
        private Label label2;
        private Label label3;
        private TextBox nameBox;
        private NumericUpDown startHealthBox;
        private NumericUpDown maxHealthBox;
        private Label label4;
        private Label label5;
        private NumericUpDown minDmgBox;
        private NumericUpDown maxDmgBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown maxHealBox;
        private NumericUpDown minHealBox;
        private Label label10;
        private CheckBox healCheckBox;
        private Button newButton;
        private Button saveButton;
    }
}
