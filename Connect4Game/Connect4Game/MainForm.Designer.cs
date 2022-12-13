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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTable
            // 
            this.pictureBoxTable.Image = global::Connect4Game.Properties.Resources.table;
            this.pictureBoxTable.InitialImage = null;
            this.pictureBoxTable.Location = new System.Drawing.Point(12, 41);
            this.pictureBoxTable.Name = "pictureBoxTable";
            this.pictureBoxTable.Size = new System.Drawing.Size(659, 569);
            this.pictureBoxTable.TabIndex = 0;
            this.pictureBoxTable.TabStop = false;
            this.pictureBoxTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTable_Paint);
            // 
            // buttonTableColumn0
            // 
            this.buttonTableColumn0.Location = new System.Drawing.Point(36, 12);
            this.buttonTableColumn0.Name = "buttonTableColumn0";
            this.buttonTableColumn0.Size = new System.Drawing.Size(75, 23);
            this.buttonTableColumn0.TabIndex = 1;
            this.buttonTableColumn0.Text = "add bwaba";
            this.buttonTableColumn0.UseVisualStyleBackColor = true;
            this.buttonTableColumn0.Click += new System.EventHandler(this.buttonTableColumn0_Click);
            // 
            // buttonTableColumn1
            // 
            this.buttonTableColumn1.Location = new System.Drawing.Point(125, 12);
            this.buttonTableColumn1.Name = "buttonTableColumn1";
            this.buttonTableColumn1.Size = new System.Drawing.Size(75, 23);
            this.buttonTableColumn1.TabIndex = 2;
            this.buttonTableColumn1.Text = "add bwaba";
            this.buttonTableColumn1.UseVisualStyleBackColor = true;
            this.buttonTableColumn1.Click += new System.EventHandler(this.buttonTableColumn1_Click);
            // 
            // buttonTableColumn2
            // 
            this.buttonTableColumn2.Location = new System.Drawing.Point(214, 12);
            this.buttonTableColumn2.Name = "buttonTableColumn2";
            this.buttonTableColumn2.Size = new System.Drawing.Size(75, 23);
            this.buttonTableColumn2.TabIndex = 3;
            this.buttonTableColumn2.Text = "add bwaba";
            this.buttonTableColumn2.UseVisualStyleBackColor = true;
            this.buttonTableColumn2.Click += new System.EventHandler(this.buttonTableColumn2_Click);
            // 
            // buttonTableColumn3
            // 
            this.buttonTableColumn3.Location = new System.Drawing.Point(303, 12);
            this.buttonTableColumn3.Name = "buttonTableColumn3";
            this.buttonTableColumn3.Size = new System.Drawing.Size(75, 23);
            this.buttonTableColumn3.TabIndex = 4;
            this.buttonTableColumn3.Text = "add bwaba";
            this.buttonTableColumn3.UseVisualStyleBackColor = true;
            this.buttonTableColumn3.Click += new System.EventHandler(this.buttonTableColumn3_Click);
            // 
            // buttonTableColumn4
            // 
            this.buttonTableColumn4.Location = new System.Drawing.Point(392, 12);
            this.buttonTableColumn4.Name = "buttonTableColumn4";
            this.buttonTableColumn4.Size = new System.Drawing.Size(75, 23);
            this.buttonTableColumn4.TabIndex = 5;
            this.buttonTableColumn4.Text = "add bwaba";
            this.buttonTableColumn4.UseVisualStyleBackColor = true;
            this.buttonTableColumn4.Click += new System.EventHandler(this.buttonTableColumn4_Click);
            // 
            // buttonTableColumn5
            // 
            this.buttonTableColumn5.Location = new System.Drawing.Point(481, 12);
            this.buttonTableColumn5.Name = "buttonTableColumn5";
            this.buttonTableColumn5.Size = new System.Drawing.Size(75, 23);
            this.buttonTableColumn5.TabIndex = 6;
            this.buttonTableColumn5.Text = "add bwaba";
            this.buttonTableColumn5.UseVisualStyleBackColor = true;
            this.buttonTableColumn5.Click += new System.EventHandler(this.buttonTableColumn5_Click);
            // 
            // buttonTableColumn6
            // 
            this.buttonTableColumn6.Location = new System.Drawing.Point(570, 12);
            this.buttonTableColumn6.Name = "buttonTableColumn6";
            this.buttonTableColumn6.Size = new System.Drawing.Size(75, 23);
            this.buttonTableColumn6.TabIndex = 7;
            this.buttonTableColumn6.Text = "add bwaba";
            this.buttonTableColumn6.UseVisualStyleBackColor = true;
            this.buttonTableColumn6.Click += new System.EventHandler(this.buttonTableColumn6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 679);
            this.Controls.Add(this.buttonTableColumn6);
            this.Controls.Add(this.buttonTableColumn5);
            this.Controls.Add(this.buttonTableColumn4);
            this.Controls.Add(this.buttonTableColumn3);
            this.Controls.Add(this.buttonTableColumn2);
            this.Controls.Add(this.buttonTableColumn1);
            this.Controls.Add(this.buttonTableColumn0);
            this.Controls.Add(this.pictureBoxTable);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTable)).EndInit();
            this.ResumeLayout(false);

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
    }
}

