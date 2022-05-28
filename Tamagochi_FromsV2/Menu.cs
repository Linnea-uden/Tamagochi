using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi_FromsV2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //string path = @"C:\\Users\\Linnea\\Desktop\\Coding\\Tamagochi.txt";
            if (new FileInfo("log.txt").Length == 0)
            {
                this.Hide();
                CreateNew newGame = new CreateNew();
                newGame.Show();
            }
            else
            {
                this.Hide();
                SparadKaraktärForm saveCharacter = new SparadKaraktärForm();
                saveCharacter.Show();
            }

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNew newGame = new CreateNew();
            newGame.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            TutorialForm tutorial = new TutorialForm();
            tutorial.Show();

        }
    }
}
