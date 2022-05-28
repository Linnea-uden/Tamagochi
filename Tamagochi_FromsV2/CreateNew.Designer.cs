
namespace Tamagochi_FromsV2
{
    partial class CreateNew
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
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.lbxVäljGubbe = new System.Windows.Forms.ListBox();
            this.txbNamn = new System.Windows.Forms.TextBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblEmptyBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.title.ForeColor = System.Drawing.Color.Turquoise;
            this.title.Location = new System.Drawing.Point(269, 53);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(459, 91);
            this.title.TabIndex = 10;
            this.title.Text = "Create New";
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.BackColor = System.Drawing.Color.Turquoise;
            this.btnCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCreateNew.Location = new System.Drawing.Point(371, 491);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(288, 94);
            this.btnCreateNew.TabIndex = 11;
            this.btnCreateNew.Text = "Start";
            this.btnCreateNew.UseVisualStyleBackColor = false;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // lbxVäljGubbe
            // 
            this.lbxVäljGubbe.FormattingEnabled = true;
            this.lbxVäljGubbe.ItemHeight = 20;
            this.lbxVäljGubbe.Location = new System.Drawing.Point(520, 336);
            this.lbxVäljGubbe.Name = "lbxVäljGubbe";
            this.lbxVäljGubbe.Size = new System.Drawing.Size(139, 84);
            this.lbxVäljGubbe.TabIndex = 15;
            // 
            // txbNamn
            // 
            this.txbNamn.Location = new System.Drawing.Point(520, 265);
            this.txbNamn.Name = "txbNamn";
            this.txbNamn.Size = new System.Drawing.Size(139, 26);
            this.txbNamn.TabIndex = 14;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblSort.ForeColor = System.Drawing.Color.White;
            this.lblSort.Location = new System.Drawing.Point(341, 351);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(91, 40);
            this.lblSort.TabIndex = 13;
            this.lblSort.Text = "Färg";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblNamn.ForeColor = System.Drawing.Color.White;
            this.lblNamn.Location = new System.Drawing.Point(341, 251);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(113, 40);
            this.lblNamn.TabIndex = 12;
            this.lblNamn.Text = "Namn";
            // 
            // lblEmptyBox
            // 
            this.lblEmptyBox.AutoSize = true;
            this.lblEmptyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblEmptyBox.ForeColor = System.Drawing.Color.White;
            this.lblEmptyBox.Location = new System.Drawing.Point(237, 157);
            this.lblEmptyBox.Name = "lblEmptyBox";
            this.lblEmptyBox.Size = new System.Drawing.Size(0, 66);
            this.lblEmptyBox.TabIndex = 16;
            // 
            // CreateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1022, 665);
            this.Controls.Add(this.lblEmptyBox);
            this.Controls.Add(this.lbxVäljGubbe);
            this.Controls.Add(this.txbNamn);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.title);
            this.Name = "CreateNew";
            this.Text = "CreateNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ListBox lbxVäljGubbe;
        private System.Windows.Forms.TextBox txbNamn;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblEmptyBox;
    }
}