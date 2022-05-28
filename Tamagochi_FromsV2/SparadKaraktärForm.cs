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
    public partial class SparadKaraktärForm : Form
    {

        SparadeKaraktär sparadeKaraktärer;
        public static bool sparadKar = false;
        public static string Namn;

        public SparadKaraktärForm()
        {
            InitializeComponent();
            sparadeKaraktärer = new SparadeKaraktär();

            //Hämta namnen på karaktärena i text filen och skriv ut dem i lbxbox 
            string[] namnLista = new string[100];
            namnLista = sparadeKaraktärer.hämtaNamn();
            
            foreach (var name in namnLista)
            {
                lbxChooseCharacter.Items.Add(name);
                
            }
            lbxChooseCharacter.SelectedItem = lbxChooseCharacter.Items[0];


        }
        private void btnChooseCharacter_Click(object sender, EventArgs e)
        {
            sparadKar = true;
            Namn = lbxChooseCharacter.SelectedItem.ToString();
            //Öppna nytt form
            this.Hide();
            Main nyttSpel = new Main();
            nyttSpel.Show();
        }
        private void lbxChooseCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
