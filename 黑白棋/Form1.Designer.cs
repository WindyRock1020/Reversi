namespace 黑白棋
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新開始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遊戲ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 27);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 遊戲ToolStripMenuItem
            // 
            this.遊戲ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新遊戲ToolStripMenuItem,
            this.重新開始ToolStripMenuItem,
            this.離開遊戲ToolStripMenuItem});
            this.遊戲ToolStripMenuItem.Name = "遊戲ToolStripMenuItem";
            this.遊戲ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.遊戲ToolStripMenuItem.Text = "遊戲";
            // 
            // 新遊戲ToolStripMenuItem
            // 
            this.新遊戲ToolStripMenuItem.Name = "新遊戲ToolStripMenuItem";
            this.新遊戲ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.新遊戲ToolStripMenuItem.Text = "新的一局";
            this.新遊戲ToolStripMenuItem.Click += new System.EventHandler(this.新遊戲ToolStripMenuItem_Click);
            // 
            // 重新開始ToolStripMenuItem
            // 
            this.重新開始ToolStripMenuItem.Name = "重新開始ToolStripMenuItem";
            this.重新開始ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.重新開始ToolStripMenuItem.Text = "重新開始";
            this.重新開始ToolStripMenuItem.Click += new System.EventHandler(this.重新游戏ToolStripMenuItem_Click);
            // 
            // 離開遊戲ToolStripMenuItem
            // 
            this.離開遊戲ToolStripMenuItem.Name = "離開遊戲ToolStripMenuItem";
            this.離開遊戲ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.離開遊戲ToolStripMenuItem.Text = "離開遊戲";
            this.離開遊戲ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(496, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "黑棋個數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(497, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "白棋個數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(500, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 35);
            this.label3.TabIndex = 22;
            this.label3.Text = "目前回合";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(555, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 35);
            this.label4.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(555, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 35);
            this.label5.TabIndex = 24;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.start.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.start.Location = new System.Drawing.Point(486, 486);
            this.start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(155, 77);
            this.start.TabIndex = 25;
            this.start.Text = "點擊左上角開始遊戲";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::黑白棋.Properties.Resources.hqdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 572);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "黑白棋";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新開始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開遊戲ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label start;
    }
}

