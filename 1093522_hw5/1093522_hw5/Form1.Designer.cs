namespace _1093522_hw5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel0 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // panel0
            // 
            this.panel0.AutoSize = true;
            this.panel0.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel0.Location = new System.Drawing.Point(0, 28);
            this.panel0.Margin = new System.Windows.Forms.Padding(0);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(100, 100);
            this.panel0.TabIndex = 2;
            this.panel0.Tag = "0";
            this.panel0.Click += new System.EventHandler(this.panel1_Click);
            this.panel0.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(100, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "1";
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(200, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Tag = "2";
            this.panel2.Click += new System.EventHandler(this.panel1_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(300, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 0;
            this.panel3.Tag = "3";
            this.panel3.Click += new System.EventHandler(this.panel1_Click);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(0, 128);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 100);
            this.panel4.TabIndex = 0;
            this.panel4.Tag = "4";
            this.panel4.Click += new System.EventHandler(this.panel1_Click);
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(100, 128);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 100);
            this.panel5.TabIndex = 0;
            this.panel5.Tag = "5";
            this.panel5.Click += new System.EventHandler(this.panel1_Click);
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(200, 128);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 100);
            this.panel6.TabIndex = 0;
            this.panel6.Tag = "6";
            this.panel6.Click += new System.EventHandler(this.panel1_Click);
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(300, 128);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 100);
            this.panel7.TabIndex = 0;
            this.panel7.Tag = "7";
            this.panel7.Click += new System.EventHandler(this.panel1_Click);
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(0, 228);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 100);
            this.panel8.TabIndex = 0;
            this.panel8.Tag = "8";
            this.panel8.Click += new System.EventHandler(this.panel1_Click);
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(100, 228);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 100);
            this.panel9.TabIndex = 0;
            this.panel9.Tag = "9";
            this.panel9.Click += new System.EventHandler(this.panel1_Click);
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(200, 228);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 100);
            this.panel10.TabIndex = 0;
            this.panel10.Tag = "10";
            this.panel10.Click += new System.EventHandler(this.panel1_Click);
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel11.Location = new System.Drawing.Point(300, 228);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(100, 100);
            this.panel11.TabIndex = 0;
            this.panel11.Tag = "11";
            this.panel11.Click += new System.EventHandler(this.panel1_Click);
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(0, 328);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(100, 100);
            this.panel12.TabIndex = 0;
            this.panel12.Tag = "12";
            this.panel12.Click += new System.EventHandler(this.panel1_Click);
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel13
            // 
            this.panel13.AutoSize = true;
            this.panel13.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel13.Location = new System.Drawing.Point(100, 328);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(100, 100);
            this.panel13.TabIndex = 0;
            this.panel13.Tag = "13";
            this.panel13.Click += new System.EventHandler(this.panel1_Click);
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel14
            // 
            this.panel14.AutoSize = true;
            this.panel14.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.Location = new System.Drawing.Point(200, 328);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(100, 100);
            this.panel14.TabIndex = 0;
            this.panel14.Tag = "14";
            this.panel14.Click += new System.EventHandler(this.panel1_Click);
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel15
            // 
            this.panel15.AutoSize = true;
            this.panel15.BackColor = System.Drawing.SystemColors.Control;
            this.panel15.BackgroundImage = global::_1093522_hw5.Properties.Resources.Cover;
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel15.Location = new System.Drawing.Point(300, 328);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(100, 100);
            this.panel15.TabIndex = 0;
            this.panel15.Tag = "15";
            this.panel15.Click += new System.EventHandler(this.panel1_Click);
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 556);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
    }
}

