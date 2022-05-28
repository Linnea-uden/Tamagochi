using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi_FromsV2
{
    public partial class CreateNew : Form
    {
        public static string Namn;
        public static string Färg;
        public CreateNew()
        {
            InitializeComponent();
            lbxVäljGubbe.Items.Add("Blue");
            lbxVäljGubbe.Items.Add("Red");
            lbxVäljGubbe.Items.Add("Green");

            lbxVäljGubbe.SelectedItem = lbxVäljGubbe.Items[0];
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbNamn.Text))
            {
                lblEmptyBox.Text = "TEXT BOX IS EMPTY";
            }
            else
            {
                Namn = txbNamn.Text;
                Färg = lbxVäljGubbe.SelectedItem.ToString();
                this.Hide();
                Main start = new Main();
                start.Show();
            }

        }
    }
}
