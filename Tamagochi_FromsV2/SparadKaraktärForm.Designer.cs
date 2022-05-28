
namespace Tamagochi_FromsV2
{
    partial class SparadKaraktärForm
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
            this.title = new System.Windows.Forms.Label();
            this.lbxChooseCharacter = new System.Windows.Forms.ListBox();
            this.btnChooseCharacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.title.ForeColor = System.Drawing.Color.Turquoise;
            this.title.Location = new System.Drawing.Point(189, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(666, 91);
            this.title.TabIndex = 11;
            this.title.Text = "Choose character";
            // 
            // lbxChooseCharacter
            // 
            this.lbxChooseCharacter.FormattingEnabled = true;
            this.lbxChooseCharacter.ItemHeight = 20;
            this.lbxChooseCharacter.Location = new System.Drawing.Point(417, 180);
            this.lbxChooseCharacter.Name = "lbxChooseCharacter";
            this.lbxChooseCharacter.Size = new System.Drawing.Size(212, 184);
            this.lbxChooseCharacter.TabIndex = 12;
            this.lbxChooseCharacter.SelectedIndexChanged += new System.EventHandler(this.lbxChooseCharacter_SelectedIndexChanged);
            // 
            // btnChooseCharacter
            // 
            this.btnChooseCharacter.BackColor = System.Drawing.Color.Turquoise;
            this.btnChooseCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnChooseCharacter.Location = new System.Drawing.Point(385, 462);
            this.btnChooseCharacter.Name = "btnChooseCharacter";
            this.btnChooseCharacter.Size = new System.Drawing.Size(288, 94);
            this.btnChooseCharacter.TabIndex = 13;
            this.btnChooseCharacter.Text = "Start";
            this.btnChooseCharacter.UseVisualStyleBackColor = false;
            this.btnChooseCharacter.Click += new System.EventHandler(this.btnChooseCharacter_Click);
            // 
            // SparadKaraktärForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1023, 664);
            this.Controls.Add(this.btnChooseCharacter);
            this.Controls.Add(this.lbxChooseCharacter);
            this.Controls.Add(this.title);
            this.Name = "SparadKaraktärForm";
            this.Text = "SparadKaraktär";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListBox lbxChooseCharacter;
        private System.Windows.Forms.Button btnChooseCharacter;
    }
}