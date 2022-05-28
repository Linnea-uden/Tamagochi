
namespace Tamagochi_FromsV2
{
    partial class Main
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
            this.prbMata = new System.Windows.Forms.ProgressBar();
            this.prbSova = new System.Windows.Forms.ProgressBar();
            this.prbLeka = new System.Windows.Forms.ProgressBar();
            this.btnMata = new System.Windows.Forms.Button();
            this.btnLeka = new System.Windows.Forms.Button();
            this.btnSova = new System.Windows.Forms.Button();
            this.pbxTamagochi = new System.Windows.Forms.PictureBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblVikt = new System.Windows.Forms.Label();
            this.menuStripe = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.prbLevel = new System.Windows.Forms.ProgressBar();
            this.btnFight = new System.Windows.Forms.Button();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblWaring = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTamagochi)).BeginInit();
            this.menuStripe.SuspendLayout();
            this.SuspendLayout();
            // 
            // prbMata
            // 
            this.prbMata.Location = new System.Drawing.Point(78, 398);
            this.prbMata.Name = "prbMata";
            this.prbMata.Size = new System.Drawing.Size(437, 54);
            this.prbMata.TabIndex = 0;
            // 
            // prbSova
            // 
            this.prbSova.Location = new System.Drawing.Point(78, 577);
            this.prbSova.Name = "prbSova";
            this.prbSova.Size = new System.Drawing.Size(437, 54);
            this.prbSova.TabIndex = 1;
            // 
            // prbLeka
            // 
            this.prbLeka.Location = new System.Drawing.Point(78, 488);
            this.prbLeka.Name = "prbLeka";
            this.prbLeka.Size = new System.Drawing.Size(437, 54);
            this.prbLeka.TabIndex = 2;
            // 
            // btnMata
            // 
            this.btnMata.BackColor = System.Drawing.Color.Turquoise;
            this.btnMata.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMata.Location = new System.Drawing.Point(563, 398);
            this.btnMata.Name = "btnMata";
            this.btnMata.Size = new System.Drawing.Size(224, 54);
            this.btnMata.TabIndex = 12;
            this.btnMata.Text = "Mata";
            this.btnMata.UseVisualStyleBackColor = false;
            this.btnMata.Click += new System.EventHandler(this.btnMata_Click);
            // 
            // btnLeka
            // 
            this.btnLeka.BackColor = System.Drawing.Color.Turquoise;
            this.btnLeka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnLeka.Location = new System.Drawing.Point(563, 488);
            this.btnLeka.Name = "btnLeka";
            this.btnLeka.Size = new System.Drawing.Size(224, 54);
            this.btnLeka.TabIndex = 13;
            this.btnLeka.Text = "Leka";
            this.btnLeka.UseVisualStyleBackColor = false;
            this.btnLeka.Click += new System.EventHandler(this.btnLeka_Click);
            // 
            // btnSova
            // 
            this.btnSova.BackColor = System.Drawing.Color.Turquoise;
            this.btnSova.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSova.Location = new System.Drawing.Point(563, 577);
            this.btnSova.Name = "btnSova";
            this.btnSova.Size = new System.Drawing.Size(224, 54);
            this.btnSova.TabIndex = 14;
            this.btnSova.Text = "Sova";
            this.btnSova.UseVisualStyleBackColor = false;
            this.btnSova.Click += new System.EventHandler(this.btnSova_Click);
            // 
            // pbxTamagochi
            // 
            this.pbxTamagochi.Location = new System.Drawing.Point(117, 24);
            this.pbxTamagochi.Name = "pbxTamagochi";
            this.pbxTamagochi.Size = new System.Drawing.Size(327, 290);
            this.pbxTamagochi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTamagochi.TabIndex = 15;
            this.pbxTamagochi.TabStop = false;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(493, 191);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(139, 55);
            this.lblLevel.TabIndex = 17;
            this.lblLevel.Text = "Level";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblVikt
            // 
            this.lblVikt.AutoSize = true;
            this.lblVikt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblVikt.ForeColor = System.Drawing.Color.White;
            this.lblVikt.Location = new System.Drawing.Point(493, 111);
            this.lblVikt.Name = "lblVikt";
            this.lblVikt.Size = new System.Drawing.Size(103, 55);
            this.lblVikt.TabIndex = 18;
            this.lblVikt.Text = "Vikt";
            // 
            // menuStripe
            // 
            this.menuStripe.BackColor = System.Drawing.Color.LightCoral;
            this.menuStripe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStripe.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripe.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStripe.Location = new System.Drawing.Point(0, 0);
            this.menuStripe.Name = "menuStripe";
            this.menuStripe.Size = new System.Drawing.Size(1532, 63);
            this.menuStripe.TabIndex = 19;
            this.menuStripe.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(94, 59);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(204, 40);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(204, 40);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(204, 40);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTid.ForeColor = System.Drawing.Color.White;
            this.lblTid.Location = new System.Drawing.Point(887, 12);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(126, 32);
            this.lblTid.TabIndex = 20;
            this.lblTid.Text = "Tid: 8:00";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Red;
            this.lblGameOver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(17, 276);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 162);
            this.lblGameOver.TabIndex = 21;
            // 
            // prbLevel
            // 
            this.prbLevel.Location = new System.Drawing.Point(676, 208);
            this.prbLevel.Name = "prbLevel";
            this.prbLevel.Size = new System.Drawing.Size(121, 28);
            this.prbLevel.TabIndex = 22;
            // 
            // btnFight
            // 
            this.btnFight.BackColor = System.Drawing.Color.Turquoise;
            this.btnFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnFight.Location = new System.Drawing.Point(563, 291);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(224, 61);
            this.btnFight.TabIndex = 23;
            this.btnFight.Text = "Fight";
            this.btnFight.UseVisualStyleBackColor = false;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblNamn.ForeColor = System.Drawing.Color.White;
            this.lblNamn.Location = new System.Drawing.Point(493, 24);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(166, 55);
            this.lblNamn.TabIndex = 16;
            this.lblNamn.Text = "Namn:";
            // 
            // lblWaring
            // 
            this.lblWaring.AutoSize = true;
            this.lblWaring.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblWaring.ForeColor = System.Drawing.Color.Black;
            this.lblWaring.Location = new System.Drawing.Point(760, 111);
            this.lblWaring.Name = "lblWaring";
            this.lblWaring.Size = new System.Drawing.Size(0, 83);
            this.lblWaring.TabIndex = 24;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1021, 666);
            this.Controls.Add(this.lblWaring);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.prbLevel);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblTid);
            this.Controls.Add(this.lblVikt);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.pbxTamagochi);
            this.Controls.Add(this.btnSova);
            this.Controls.Add(this.btnLeka);
            this.Controls.Add(this.btnMata);
            this.Controls.Add(this.prbLeka);
            this.Controls.Add(this.prbSova);
            this.Controls.Add(this.prbMata);
            this.Controls.Add(this.menuStripe);
            this.MainMenuStrip = this.menuStripe;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTamagochi)).EndInit();
            this.menuStripe.ResumeLayout(false);
            this.menuStripe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbMata;
        private System.Windows.Forms.ProgressBar prbSova;
        private System.Windows.Forms.ProgressBar prbLeka;
        private System.Windows.Forms.Button btnMata;
        private System.Windows.Forms.Button btnLeka;
        private System.Windows.Forms.Button btnSova;
        private System.Windows.Forms.PictureBox pbxTamagochi;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblVikt;
        private System.Windows.Forms.MenuStrip menuStripe;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ProgressBar prbLevel;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblWaring;
    }
}