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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulateGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minMaxSearchDepthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxSearchDepth = new System.Windows.Forms.ToolStripComboBox();
            this.evaluationFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxEvalFunction = new System.Windows.Forms.ToolStripComboBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTableColumn6 = new System.Windows.Forms.Button();
            this.buttonTableColumn5 = new System.Windows.Forms.Button();
            this.buttonTableColumn4 = new System.Windows.Forms.Button();
            this.buttonTableColumn3 = new System.Windows.Forms.Button();
            this.buttonTableColumn2 = new System.Windows.Forms.Button();
            this.buttonTableColumn1 = new System.Windows.Forms.Button();
            this.buttonTableColumn0 = new System.Windows.Forms.Button();
            this.pictureBoxTable = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
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
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // startNewGameToolStripMenuItem
            // 
            this.startNewGameToolStripMenuItem.Name = "startNewGameToolStripMenuItem";
            this.startNewGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.startNewGameToolStripMenuItem.Text = "Start New Game";
            this.startNewGameToolStripMenuItem.Click += new System.EventHandler(this.startNewGameToolStripMenuItem_Click);
            // 
            // simulateGameToolStripMenuItem
            // 
            this.simulateGameToolStripMenuItem.Name = "simulateGameToolStripMenuItem";
            this.simulateGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.simulateGameToolStripMenuItem.Text = "Simulate Game";
            this.simulateGameToolStripMenuItem.Click += new System.EventHandler(this.simulateGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minMaxSearchDepthToolStripMenuItem,
            this.evaluationFunctionToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // minMaxSearchDepthToolStripMenuItem
            // 
            this.minMaxSearchDepthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxSearchDepth});
            this.minMaxSearchDepthToolStripMenuItem.Name = "minMaxSearchDepthToolStripMenuItem";
            this.minMaxSearchDepthToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
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
            this.toolStripComboBoxSearchDepth.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxSearchDepth.Text = "4";
            // 
            // evaluationFunctionToolStripMenuItem
            // 
            this.evaluationFunctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxEvalFunction});
            this.evaluationFunctionToolStripMenuItem.Name = "evaluationFunctionToolStripMenuItem";
            this.evaluationFunctionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.evaluationFunctionToolStripMenuItem.Text = "Evaluation Function";
            // 
            // toolStripComboBoxEvalFunction
            // 
            this.toolStripComboBoxEvalFunction.Items.AddRange(new object[] {
            "1",
            "2"});
            this.toolStripComboBoxEvalFunction.Name = "toolStripComboBoxEvalFunction";
            this.toolStripComboBoxEvalFunction.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBoxEvalFunction.Text = "2";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonTableColumn6
            // 
            this.buttonTableColumn6.Image = global::Connect4Game.Properties.Resources.spinningchipsmall;
            this.buttonTableColumn6.Location = new System.Drawing.Point(575, 41);
            this.buttonTableColumn6.Name = "buttonTableColumn6";
            this.buttonTableColumn6.Size = new System.Drawing.Size(75, 75);
            this.buttonTableColumn6.TabIndex = 7;
            this.buttonTableColumn6.Text = "$";
            this.buttonTableColumn6.UseVisualStyleBackColor = true;
            this.buttonTableColumn6.Click += new System.EventHandler(this.buttonTableColumn6_Click);
            // 
            // buttonTableColumn5
            // 
            this.buttonTableColumn5.Image = global::Connect4Game.Properties.Resources.spinningchipsmall;
            this.buttonTableColumn5.Location = new System.Drawing.Point(485, 41);
            this.buttonTableColumn5.Name = "buttonTableColumn5";
            this.buttonTableColumn5.Size = new System.Drawing.Size(75, 75);
            this.buttonTableColumn5.TabIndex = 6;
            this.buttonTableColumn5.Text = "$";
            this.buttonTableColumn5.UseVisualStyleBackColor = true;
            this.buttonTableColumn5.Click += new System.EventHandler(this.buttonTableColumn5_Click);
            // 
            // buttonTableColumn4
            // 
            this.buttonTableColumn4.Image = global::Connect4Game.Properties.Resources.spinningchipsmall;
            this.buttonTableColumn4.Location = new System.Drawing.Point(392, 41);
            this.buttonTableColumn4.Name = "buttonTableColumn4";
            this.buttonTableColumn4.Size = new System.Drawing.Size(75, 75);
            this.buttonTableColumn4.TabIndex = 5;
            this.buttonTableColumn4.Text = "$";
            this.buttonTableColumn4.UseVisualStyleBackColor = true;
            this.buttonTableColumn4.Click += new System.EventHandler(this.buttonTableColumn4_Click);
            // 
            // buttonTableColumn3
            // 
            this.buttonTableColumn3.Image = global::Connect4Game.Properties.Resources.spinningchipsmall;
            this.buttonTableColumn3.Location = new System.Drawing.Point(303, 41);
            this.buttonTableColumn3.Name = "buttonTableColumn3";
            this.buttonTableColumn3.Size = new System.Drawing.Size(75, 75);
            this.buttonTableColumn3.TabIndex = 4;
            this.buttonTableColumn3.Text = "$";
            this.buttonTableColumn3.UseVisualStyleBackColor = true;
            this.buttonTableColumn3.Click += new System.EventHandler(this.buttonTableColumn3_Click);
            // 
            // buttonTableColumn2
            // 
            this.buttonTableColumn2.Image = global::Connect4Game.Properties.Resources.spinningchipsmall;
            this.buttonTableColumn2.Location = new System.Drawing.Point(214, 41);
            this.buttonTableColumn2.Name = "buttonTableColumn2";
            this.buttonTableColumn2.Size = new System.Drawing.Size(75, 75);
            this.buttonTableColumn2.TabIndex = 3;
            this.buttonTableColumn2.Text = "$";
            this.buttonTableColumn2.UseVisualStyleBackColor = true;
            this.buttonTableColumn2.Click += new System.EventHandler(this.buttonTableColumn2_Click);
            // 
            // buttonTableColumn1
            // 
            this.buttonTableColumn1.Image = global::Connect4Game.Properties.Resources.spinningchipsmall;
            this.buttonTableColumn1.Location = new System.Drawing.Point(125, 41);
            this.buttonTableColumn1.Name = "buttonTableColumn1";
            this.buttonTableColumn1.Size = new System.Drawing.Size(75, 75);
            this.buttonTableColumn1.TabIndex = 2;
            this.buttonTableColumn1.Text = "$";
            this.buttonTableColumn1.UseVisualStyleBackColor = true;
            this.buttonTableColumn1.Click += new System.EventHandler(this.buttonTableColumn1_Click);
            // 
            // buttonTableColumn0
            // 
            this.buttonTableColumn0.Image = global::Connect4Game.Properties.Resources.spinningchipsmall;
            this.buttonTableColumn0.Location = new System.Drawing.Point(34, 41);
            this.buttonTableColumn0.Name = "buttonTableColumn0";
            this.buttonTableColumn0.Size = new System.Drawing.Size(75, 75);
            this.buttonTableColumn0.TabIndex = 1;
            this.buttonTableColumn0.Text = "$";
            this.buttonTableColumn0.UseVisualStyleBackColor = true;
            this.buttonTableColumn0.Click += new System.EventHandler(this.buttonTableColumn0_Click);
            // 
            // pictureBoxTable
            // 
            this.pictureBoxTable.Image = global::Connect4Game.Properties.Resources.table;
            this.pictureBoxTable.InitialImage = null;
            this.pictureBoxTable.Location = new System.Drawing.Point(12, 124);
            this.pictureBoxTable.Name = "pictureBoxTable";
            this.pictureBoxTable.Size = new System.Drawing.Size(659, 569);
            this.pictureBoxTable.TabIndex = 0;
            this.pictureBoxTable.TabStop = false;
            this.pictureBoxTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTable_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 712);
            this.Controls.Add(this.buttonTableColumn6);
            this.Controls.Add(this.buttonTableColumn5);
            this.Controls.Add(this.buttonTableColumn4);
            this.Controls.Add(this.buttonTableColumn3);
            this.Controls.Add(this.buttonTableColumn2);
            this.Controls.Add(this.buttonTableColumn1);
            this.Controls.Add(this.buttonTableColumn0);
            this.Controls.Add(this.pictureBoxTable);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Connect4 - Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluationFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxEvalFunction;
    }
}

