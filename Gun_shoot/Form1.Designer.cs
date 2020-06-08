namespace Gun_shoot
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gun = new System.Windows.Forms.PictureBox();
            this.man = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gun_load_img = new System.Windows.Forms.PictureBox();
            this.blast = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCreatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.spin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gun_load_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blast)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spin)).BeginInit();
            this.SuspendLayout();
            // 
            // gun
            // 
            this.gun.BackColor = System.Drawing.Color.Transparent;
            this.gun.Image = global::Gun_shoot.Properties.Resources._5_removebg_preview;
            this.gun.Location = new System.Drawing.Point(12, 135);
            this.gun.Name = "gun";
            this.gun.Size = new System.Drawing.Size(71, 40);
            this.gun.TabIndex = 0;
            this.gun.TabStop = false;
            this.gun.Click += new System.EventHandler(this.gun_Click);
            // 
            // man
            // 
            this.man.BackColor = System.Drawing.Color.Transparent;
            this.man.Image = global::Gun_shoot.Properties.Resources.r_removebg_preview;
            this.man.Location = new System.Drawing.Point(544, 126);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(74, 105);
            this.man.TabIndex = 1;
            this.man.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(13, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Spin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(261, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Play Again";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(394, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "Target Fire";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = global::Gun_shoot.Properties.Resources.download_removebg_preview;
            this.bullet.Location = new System.Drawing.Point(79, 116);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(59, 40);
            this.bullet.TabIndex = 6;
            this.bullet.TabStop = false;
            this.bullet.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            // 
            // gun_load_img
            // 
            this.gun_load_img.BackColor = System.Drawing.Color.Transparent;
            this.gun_load_img.Image = global::Gun_shoot.Properties.Resources.deep;
            this.gun_load_img.Location = new System.Drawing.Point(-6, 126);
            this.gun_load_img.Name = "gun_load_img";
            this.gun_load_img.Size = new System.Drawing.Size(183, 118);
            this.gun_load_img.TabIndex = 7;
            this.gun_load_img.TabStop = false;
            // 
            // blast
            // 
            this.blast.Image = global::Gun_shoot.Properties.Resources.ww;
            this.blast.Location = new System.Drawing.Point(535, 126);
            this.blast.Name = "blast";
            this.blast.Size = new System.Drawing.Size(74, 105);
            this.blast.TabIndex = 8;
            this.blast.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutCreatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutCreatorToolStripMenuItem
            // 
            this.aboutCreatorToolStripMenuItem.Name = "aboutCreatorToolStripMenuItem";
            this.aboutCreatorToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutCreatorToolStripMenuItem.Text = "About Creator";
            this.aboutCreatorToolStripMenuItem.Click += new System.EventHandler(this.aboutCreatorToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(516, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "Missed fire";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // spin
            // 
            this.spin.Image = global::Gun_shoot.Properties.Resources.spin;
            this.spin.Location = new System.Drawing.Point(0, 126);
            this.spin.Name = "spin";
            this.spin.Size = new System.Drawing.Size(168, 118);
            this.spin.TabIndex = 11;
            this.spin.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(621, 387);
            this.Controls.Add(this.spin);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.blast);
            this.Controls.Add(this.gun_load_img);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.man);
            this.Controls.Add(this.gun);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gun_Shot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gun_load_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blast)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gun;
        private System.Windows.Forms.PictureBox man;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox gun_load_img;
        private System.Windows.Forms.PictureBox blast;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCreatorToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox spin;
    }
}

