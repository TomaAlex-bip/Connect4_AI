namespace Connect4Game
{
    partial class MainForm
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
			this.pictureBoxTable = new System.Windows.Forms.PictureBox();
			this.buttonTableColumn0 = new System.Windows.Forms.Button();
			this.buttonTableColumn1 = new System.Windows.Forms.Button();
			this.buttonTableColumn2 = new System.Windows.Forms.Button();
			this.buttonTableColumn3 = new System.Windows.Forms.Button();
			this.buttonTableColumn4 = new System.Windows.Forms.Button();
			this.buttonTableColumn5 = new System.Windows.Forms.Button();
			this.buttonTableColumn6 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.simulateGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minMaxSearchDepthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxSearchDepth = new System.Windows.Forms.ToolStripComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxTable
			// 
			this.pictureBoxTable.Image = global::Connect4Game.Properties.Resources.table;
			this.pictureBoxTable.InitialImage = null;
			this.pictureBoxTable.Location = new System.Drawing.Point(18, 148);
			this.pictureBoxTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBoxTable.Name = "pictureBoxTable";
			this.pictureBoxTable.Size = new System.Drawing.Size(988, 875);
			this.pictureBoxTable.TabIndex = 0;
			this.pictureBoxTable.TabStop = false;
			this.pictureBoxTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTable_Paint);
			// 
			// buttonTableColumn0
			// 
			this.buttonTableColumn0.Location = new System.Drawing.Point(54, 103);
			this.buttonTableColumn0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTableColumn0.Name = "buttonTableColumn0";
			this.buttonTableColumn0.Size = new System.Drawing.Size(112, 35);
			this.buttonTableColumn0.TabIndex = 1;
			this.buttonTableColumn0.Text = "add bwaba";
			this.buttonTableColumn0.UseVisualStyleBackColor = true;
			this.buttonTableColumn0.Click += new System.EventHandler(this.buttonTableColumn0_Click);
			// 
			// buttonTableColumn1
			// 
			this.buttonTableColumn1.Location = new System.Drawing.Point(188, 103);
			this.buttonTableColumn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTableColumn1.Name = "buttonTableColumn1";
			this.buttonTableColumn1.Size = new System.Drawing.Size(112, 35);
			this.buttonTableColumn1.TabIndex = 2;
			this.buttonTableColumn1.Text = "add bwaba";
			this.buttonTableColumn1.UseVisualStyleBackColor = true;
			this.buttonTableColumn1.Click += new System.EventHandler(this.buttonTableColumn1_Click);
			// 
			// buttonTableColumn2
			// 
			this.buttonTableColumn2.Location = new System.Drawing.Point(321, 103);
			this.buttonTableColumn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTableColumn2.Name = "buttonTableColumn2";
			this.buttonTableColumn2.Size = new System.Drawing.Size(112, 35);
			this.buttonTableColumn2.TabIndex = 3;
			this.buttonTableColumn2.Text = "add bwaba";
			this.buttonTableColumn2.UseVisualStyleBackColor = true;
			this.buttonTableColumn2.Click += new System.EventHandler(this.buttonTableColumn2_Click);
			// 
			// buttonTableColumn3
			// 
			this.buttonTableColumn3.Location = new System.Drawing.Point(454, 103);
			this.buttonTableColumn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTableColumn3.Name = "buttonTableColumn3";
			this.buttonTableColumn3.Size = new System.Drawing.Size(112, 35);
			this.buttonTableColumn3.TabIndex = 4;
			this.buttonTableColumn3.Text = "add bwaba";
			this.buttonTableColumn3.UseVisualStyleBackColor = true;
			this.buttonTableColumn3.Click += new System.EventHandler(this.buttonTableColumn3_Click);
			// 
			// buttonTableColumn4
			// 
			this.buttonTableColumn4.Location = new System.Drawing.Point(588, 103);
			this.buttonTableColumn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTableColumn4.Name = "buttonTableColumn4";
			this.buttonTableColumn4.Size = new System.Drawing.Size(112, 35);
			this.buttonTableColumn4.TabIndex = 5;
			this.buttonTableColumn4.Text = "add bwaba";
			this.buttonTableColumn4.UseVisualStyleBackColor = true;
			this.buttonTableColumn4.Click += new System.EventHandler(this.buttonTableColumn4_Click);
			// 
			// buttonTableColumn5
			// 
			this.buttonTableColumn5.Location = new System.Drawing.Point(722, 103);
			this.buttonTableColumn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTableColumn5.Name = "buttonTableColumn5";
			this.buttonTableColumn5.Size = new System.Drawing.Size(112, 35);
			this.buttonTableColumn5.TabIndex = 6;
			this.buttonTableColumn5.Text = "add bwaba";
			this.buttonTableColumn5.UseVisualStyleBackColor = true;
			this.buttonTableColumn5.Click += new System.EventHandler(this.buttonTableColumn5_Click);
			// 
			// buttonTableColumn6
			// 
			this.buttonTableColumn6.Location = new System.Drawing.Point(855, 103);
			this.buttonTableColumn6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTableColumn6.Name = "buttonTableColumn6";
			this.buttonTableColumn6.Size = new System.Drawing.Size(112, 35);
			this.buttonTableColumn6.TabIndex = 7;
			this.buttonTableColumn6.Text = "add bwaba";
			this.buttonTableColumn6.UseVisualStyleBackColor = true;
			this.buttonTableColumn6.Click += new System.EventHandler(this.buttonTableColumn6_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1034, 35);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// gameToolStripMenuItem
			// 
			this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameToolStripMenuItem,
            this.simulateGameToolStripMenuItem,
            this.quitToolStripMenuItem});
			this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
			this.gameToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
			this.gameToolStripMenuItem.Text = "Game";
			// 
			// startNewGameToolStripMenuItem
			// 
			this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
			this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
			this.startNewGameToolStripMenuItem.Text = "Start New Game";
			this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
			// 
			// simulateGameToolStripMenuItem
			// 
			this.simulateGameToolStripMenuItem.Name = "simulateGameToolStripMenuItem";
			this.simulateGameToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
			this.simulateGameToolStripMenuItem.Text = "Simulate Game";
			this.simulateGameToolStripMenuItem.Click += new System.EventHandler(this.simulateGameToolStripMenuItem_Click);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minMaxSearchDepthToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// minMaxSearchDepthToolStripMenuItem
			// 
			this.minMaxSearchDepthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxSearchDepth});
			this.minMaxSearchDepthToolStripMenuItem.Name = "minMaxSearchDepthToolStripMenuItem";
			this.minMaxSearchDepthToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
			this.minMaxSearchDepthToolStripMenuItem.Text = "MinMax Search Depth";
			// 
			// toolStripComboBoxSearchDepth
			// 
			this.toolStripComboBoxSearchDepth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
			this.toolStripComboBoxSearchDepth.Name = "toolStripComboBoxSearchDepth";
			this.toolStripComboBoxSearchDepth.Size = new System.Drawing.Size(121, 33);
			this.toolStripComboBoxSearchDepth.Text = "4";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 1058);
			this.Controls.Add(this.buttonTableColumn6);
			this.Controls.Add(this.buttonTableColumn5);
			this.Controls.Add(this.buttonTableColumn4);
			this.Controls.Add(this.buttonTableColumn3);
			this.Controls.Add(this.buttonTableColumn2);
			this.Controls.Add(this.buttonTableColumn1);
			this.Controls.Add(this.buttonTableColumn0);
			this.Controls.Add(this.pictureBoxTable);
			this.Controls.Add(this.menuStrip1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTable;
        private System.Windows.Forms.Button buttonTableColumn0;
        private System.Windows.Forms.Button buttonTableColumn1;
        private System.Windows.Forms.Button buttonTableColumn2;
        private System.Windows.Forms.Button buttonTableColumn3;
        private System.Windows.Forms.Button buttonTableColumn4;
        private System.Windows.Forms.Button buttonTableColumn5;
        private System.Windows.Forms.Button buttonTableColumn6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minMaxSearchDepthToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSearchDepth;
        private System.Windows.Forms.ToolStripMenuItem simulateGameToolStripMenuItem;
    }
}

