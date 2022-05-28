
namespace Tamagochi_FromsV2
{
    partial class Fight
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
            this.title = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.pbxFightKaraktär = new System.Windows.Forms.PictureBox();
            this.pbxMotståndare = new System.Windows.Forms.PictureBox();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lbMotståndareNamn = new System.Windows.Forms.Label();
            this.prbFightKaraktär = new System.Windows.Forms.ProgressBar();
            this.prbMotståndare = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fightTimer = new System.Windows.Forms.Timer(this.components);
            this.timerBtn = new System.Windows.Forms.Timer(this.components);
            this.btnShield = new System.Windows.Forms.Button();
            this.prbAttack = new System.Windows.Forms.ProgressBar();
            this.prbShield = new System.Windows.Forms.ProgressBar();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.bntExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFightKaraktär)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMotståndare)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.title.Location = new System.Drawing.Point(403, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(215, 91);
            this.title.TabIndex = 10;
            this.title.Text = "Fight";
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Turquoise;
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAttack.Location = new System.Drawing.Point(152, 521);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(235, 78);
            this.btnAttack.TabIndex = 11;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // pbxFightKaraktär
            // 
            this.pbxFightKaraktär.Location = new System.Drawing.Point(32, 101);
            this.pbxFightKaraktär.Name = "pbxFightKaraktär";
            this.pbxFightKaraktär.Size = new System.Drawing.Size(327, 290);
            this.pbxFightKaraktär.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFightKaraktär.TabIndex = 16;
            this.pbxFightKaraktär.TabStop = false;
            // 
            // pbxMotståndare
            // 
            this.pbxMotståndare.Location = new System.Drawing.Point(631, 101);
            this.pbxMotståndare.Name = "pbxMotståndare";
            this.pbxMotståndare.Size = new System.Drawing.Size(327, 290);
            this.pbxMotståndare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMotståndare.TabIndex = 17;
            this.pbxMotståndare.TabStop = false;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblNamn.ForeColor = System.Drawing.Color.White;
            this.lblNamn.Location = new System.Drawing.Point(33, 413);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(166, 55);
            this.lblNamn.TabIndex = 18;
            this.lblNamn.Text = "Namn:";
            // 
            // lbMotståndareNamn
            // 
            this.lbMotståndareNamn.AutoSize = true;
            this.lbMotståndareNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbMotståndareNamn.ForeColor = System.Drawing.Color.White;
            this.lbMotståndareNamn.Location = new System.Drawing.Point(652, 413);
            this.lbMotståndareNamn.Name = "lbMotståndareNamn";
            this.lbMotståndareNamn.Size = new System.Drawing.Size(166, 55);
            this.lbMotståndareNamn.TabIndex = 19;
            this.lbMotståndareNamn.Text = "Namn:";
            // 
            // prbFightKaraktär
            // 
            this.prbFightKaraktär.Location = new System.Drawing.Point(152, 52);
            this.prbFightKaraktär.Name = "prbFightKaraktär";
            this.prbFightKaraktär.Size = new System.Drawing.Size(181, 40);
            this.prbFightKaraktär.TabIndex = 20;
            // 
            // prbMotståndare
            // 
            this.prbMotståndare.Location = new System.Drawing.Point(751, 52);
            this.prbMotståndare.Name = "prbMotståndare";
            this.prbMotståndare.Size = new System.Drawing.Size(181, 40);
            this.prbMotståndare.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 40);
            this.label2.TabIndex = 22;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(624, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 40);
            this.label3.TabIndex = 23;
            this.label3.Text = "Health";
            // 
            // fightTimer
            // 
            this.fightTimer.Tick += new System.EventHandler(this.fightTimer_Tick);
            // 
            // timerBtn
            // 
            this.timerBtn.Tick += new System.EventHandler(this.timerBtn_Tick);
            // 
            // btnShield
            // 
            this.btnShield.BackColor = System.Drawing.Color.Turquoise;
            this.btnShield.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnShield.Location = new System.Drawing.Point(606, 521);
            this.btnShield.Name = "btnShield";
            this.btnShield.Size = new System.Drawing.Size(235, 78);
            this.btnShield.TabIndex = 24;
            this.btnShield.Text = "Shield";
            this.btnShield.UseVisualStyleBackColor = false;
            this.btnShield.Click += new System.EventHandler(this.btnShield_Click);
            // 
            // prbAttack
            // 
            this.prbAttack.Location = new System.Drawing.Point(152, 605);
            this.prbAttack.Name = "prbAttack";
            this.prbAttack.Size = new System.Drawing.Size(235, 40);
            this.prbAttack.TabIndex = 25;
            // 
            // prbShield
            // 
            this.prbShield.Location = new System.Drawing.Point(606, 605);
            this.prbShield.Name = "prbShield";
            this.prbShield.Size = new System.Drawing.Size(235, 40);
            this.prbShield.TabIndex = 26;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Red;
            this.lblGameOver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(294, 317);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 130);
            this.lblGameOver.TabIndex = 27;
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(922, 595);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(86, 59);
            this.bntExit.TabIndex = 28;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1020, 666);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.prbShield);
            this.Controls.Add(this.prbAttack);
            this.Controls.Add(this.btnShield);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prbMotståndare);
            this.Controls.Add(this.prbFightKaraktär);
            this.Controls.Add(this.lbMotståndareNamn);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.pbxMotståndare);
            this.Controls.Add(this.pbxFightKaraktär);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.title);
            this.Name = "Fight";
            this.Text = "Fight";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFightKaraktär)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMotståndare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox pbxFightKaraktär;
        private System.Windows.Forms.PictureBox pbxMotståndare;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lbMotståndareNamn;
        private System.Windows.Forms.ProgressBar prbFightKaraktär;
        private System.Windows.Forms.ProgressBar prbMotståndare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer fightTimer;
        private System.Windows.Forms.Timer timerBtn;
        private System.Windows.Forms.Button btnShield;
        private System.Windows.Forms.ProgressBar prbAttack;
        private System.Windows.Forms.ProgressBar prbShield;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button bntExit;
    }
}