namespace MazeGame
{
    partial class ChooseLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLevel));
            this.level1 = new System.Windows.Forms.PictureBox();
            this.level2 = new System.Windows.Forms.PictureBox();
            this.level3 = new System.Windows.Forms.PictureBox();
            this.level6 = new System.Windows.Forms.PictureBox();
            this.level5 = new System.Windows.Forms.PictureBox();
            this.level4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.level1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4)).BeginInit();
            this.SuspendLayout();
            // 
            // level1
            // 
            this.level1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("level1.BackgroundImage")));
            this.level1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.level1.Location = new System.Drawing.Point(27, 97);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(234, 121);
            this.level1.TabIndex = 0;
            this.level1.TabStop = false;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // level2
            // 
            this.level2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("level2.BackgroundImage")));
            this.level2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.level2.Location = new System.Drawing.Point(295, 97);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(234, 121);
            this.level2.TabIndex = 1;
            this.level2.TabStop = false;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // level3
            // 
            this.level3.Location = new System.Drawing.Point(562, 97);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(234, 121);
            this.level3.TabIndex = 2;
            this.level3.TabStop = false;
            // 
            // level6
            // 
            this.level6.Location = new System.Drawing.Point(562, 269);
            this.level6.Name = "level6";
            this.level6.Size = new System.Drawing.Size(234, 121);
            this.level6.TabIndex = 5;
            this.level6.TabStop = false;
            // 
            // level5
            // 
            this.level5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("level5.BackgroundImage")));
            this.level5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.level5.Location = new System.Drawing.Point(295, 269);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(234, 121);
            this.level5.TabIndex = 4;
            this.level5.TabStop = false;
            // 
            // level4
            // 
            this.level4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("level4.BackgroundImage")));
            this.level4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.level4.Location = new System.Drawing.Point(27, 269);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(234, 121);
            this.level4.TabIndex = 3;
            this.level4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(27, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "BACK TO START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChooseLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.level6);
            this.Controls.Add(this.level5);
            this.Controls.Add(this.level4);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level1);
            this.Name = "ChooseLevel";
            this.Text = "ChooseLevel";
            ((System.ComponentModel.ISupportInitialize)(this.level1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox level1;
        private System.Windows.Forms.PictureBox level2;
        private System.Windows.Forms.PictureBox level3;
        private System.Windows.Forms.PictureBox level6;
        private System.Windows.Forms.PictureBox level5;
        private System.Windows.Forms.PictureBox level4;
        private System.Windows.Forms.Button button1;
    }
}