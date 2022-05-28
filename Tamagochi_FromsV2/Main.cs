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
    public partial class Main : Form
    {
        //Skapar Objekt
        Karaktär karaktär;
        Tamagochi tamagochi;
        SparadeKaraktär sparadeKaraktärer;


        int minskningHunger = 1;
        int minskningTrötthet = 1;
        int minskningÅngest = 1;
        int tid;
        int test = 10;
        int spelTid = 8;
        int levelTid = 100;

        //Värden som kan nås när tamagochin ska fighta 
        public static int level;
        public static string färg;
        public static string namn; 
        public Main()
        {

            InitializeComponent();
            //Skapar objekten
            karaktär = new Karaktär();
            tamagochi = new Tamagochi();
            sparadeKaraktärer = new SparadeKaraktär();

            //En if sats som ger tamagochin sina värden beroende på om den är ny eller en sparad karaktär
            if (SparadKaraktärForm.sparadKar == true)
            {
                lblLevel.Text = sparadeKaraktärer.hämtaVärden();
                lblNamn.Text = "Namn: " + SparadKaraktärForm.Namn;
                färg = sparadeKaraktärer.hämtaFärg();


                string hämtadeVärden = sparadeKaraktärer.hämtaVärden();
                string[] värden = new string[5];
                värden = hämtadeVärden.Split('.');

                //Sätt värden från sparad karaktär listan 
                tamagochi.Vikt = int.Parse(värden[0]);
                karaktär.Level = int.Parse(värden[1]);
                tamagochi.Hunger = int.Parse(värden[2]);
                tamagochi.Depression = int.Parse(värden[3]);
                tamagochi.Trötthet = int.Parse(värden[4]);
                level = karaktär.level;
                namn = SparadKaraktärForm.Namn;

            }
            else
            {
                färg = CreateNew.Färg;
                lblNamn.Text = "Namn: " + CreateNew.Namn;
                namn = CreateNew.Namn;
            }

            
            lblVikt.Text = "Vikt: " + tamagochi.Vikt + " g";
            lblLevel.Text = "Level: " + karaktär.Level.ToString();
            pbxTamagochi.Image = karaktär.VilkenKaraktär(färg);
            prbMata.Value = tamagochi.Hunger;
            prbLeka.Value = tamagochi.Depression;
            prbSova.Value = tamagochi.Trötthet;
            prbLevel.Value = 0;
            level = karaktär.level;

            timer.Start();

            //Sätter bakgrunden på form beronde på pokemonens färg
            if (färg == "Red")
            {
                this.BackColor = System.Drawing.Color.OrangeRed;
                menuStripe.BackColor = System.Drawing.Color.OrangeRed;
            }
            if (färg == "Blue")
            {
                this.BackColor = System.Drawing.Color.RoyalBlue;
                menuStripe.BackColor = System.Drawing.Color.RoyalBlue;
            }
            if (färg == "Green")
            {
                this.BackColor = System.Drawing.Color.LimeGreen;
                menuStripe.BackColor = System.Drawing.Color.LimeGreen;
            }

        }
        private void Updatera()
        {
            //Updaterar klockan i spelet 
            if (tid > test)
            {
                spelTid += 1;
                lblTid.Text = "Tid: " + spelTid + ".00";
                test += 10;
            }

            //Levlar upp karaktär efter 
            if (tid > levelTid)
            {
                karaktär.LevelUp();
                pbxTamagochi.Image = karaktär.VilkenKaraktär(färg);
                lblLevel.Text = "Level: " + karaktär.level.ToString();
                prbLeka.Value = 100;
                prbMata.Value = 100;
                prbSova.Value = 100;
                level = karaktär.level;
                levelTid += 100;

            }

            //Tamagochi vikten påverkar dens hunger och trötthet
            if (tamagochi.Vikt > 120)
            {
                lblWaring.Text = "Hög vikt";
                minskningHunger = 5;

            }
            else if (tamagochi.Vikt < 80)
            {
                lblWaring.Text = "Låg vikt";
                minskningTrötthet = 5;

            }
            else
            {
                lblWaring.Text = "Normal vikt";

            }

            lblVikt.Text = "Vikt: " + tamagochi.Vikt + " g";



        }
        //Timmer som starta när spelet startar
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000;

            //Det blir lättare att överleva om man levlar upp 
            if (karaktär.level == 1)
            {
                minskningÅngest = 3;
                minskningHunger = 3;
                minskningTrötthet = 3;
            }
            if (karaktär.level == 2)
            {
                minskningÅngest = 2;
                minskningHunger = 2;
                minskningTrötthet = 2;
            }
            if (karaktär.level == 3)
            {
                minskningÅngest = 1;
                minskningHunger = 1;
                minskningTrötthet = 1;
            }
            //Kolla om tamagochi är död 
            if (prbLeka.Value == 0 || prbMata.Value == 0 || prbSova.Value == 0)
            {
                timer.Stop();
                lblGameOver.Text = "Spel Över";
                minskningÅngest = 0;
                minskningHunger = 0;
                minskningTrötthet = 0;

            }
            //Gör så att värdet på hunger,trötthet eller ångest inte blir negativ 
            else if(prbLeka.Value - minskningÅngest < 0 || prbMata.Value - minskningHunger < 0 || prbSova.Value - minskningTrötthet < 0)
            {
                prbLeka.Value = 0;
            }
            else
            {
                prbLeka.Value -= minskningÅngest;
                prbMata.Value -= minskningHunger;
                prbSova.Value -= minskningTrötthet;

                //Progress bar level 
                if (prbLevel.Value < 100)
                {
                    prbLevel.Value += 2;

                }
                else if(prbLevel.Value == 100)
                {
                    prbLevel.Value = 0;
                }
                else
                {
                    prbLevel.Value += 0;
                }


                tid += 1;
            }

            Updatera();

        }

        //Mata tamagochi
        private void btnMata_Click(object sender, EventArgs e)
        {
            prbMata.Value = tamagochi.KnapptTryck(prbMata.Value);
            minskningÅngest = 3;
            minskningTrötthet = 3;
            tamagochi.Vikt += 1;

            Updatera();
        }

        //Leka med tamagochi

        private void btnLeka_Click(object sender, EventArgs e)
        {
            prbLeka.Value = tamagochi.KnapptTryck(prbLeka.Value);
            minskningHunger = 3;
            tamagochi.Vikt -= 1;

            Updatera();

        }

        //Vila tamagochi
        private void btnSova_Click(object sender, EventArgs e)
        {
            prbSova.Value = tamagochi.KnapptTryck(prbSova.Value);
            minskningHunger = 3;

            Updatera();

        }

        //Pausa spelet
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        //Starta spelet igen
        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();

        }
        //Spara din nuvarande karaktär i spelet
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tamagochi.Hunger = prbMata.Value;
            tamagochi.Depression = prbLeka.Value;
            tamagochi.Trötthet = prbSova.Value;

            sparadeKaraktärer.Spara(tamagochi.Vikt, karaktär.level, tamagochi.Hunger, tamagochi.Depression, tamagochi.Trötthet, färg);
        }

        //Stäng spelet 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            //När man har dulerat klart ska man kunna starta spelet igen
            if (Fight.fightOver == true)
            {
                //Om man vann sin match så levlar man upp
                if (Fight.fightWon == true)
                {
                    karaktär.LevelUp();
                    pbxTamagochi.Image = karaktär.VilkenKaraktär(färg);
                    lblLevel.Text = "Level: " + karaktär.level.ToString();
                    prbLeka.Value = 100;
                    prbMata.Value = 100;
                    prbSova.Value = 100;
                    prbLevel.Value = 0;
                    level = karaktär.level;
                }
                timer.Start();
                btnFight.Text = "Fight";
                Fight.fightOver = false;

            }
            else
            {
                //Starta en match 
                timer.Stop();
                Fight fightGame = new Fight();
                fightGame.Show();
                btnFight.Text = "Resum";
            }


        }
    }
}
