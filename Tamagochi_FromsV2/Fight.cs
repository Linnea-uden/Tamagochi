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
    public partial class Fight : Form
    {
        Karaktär fightKaraktär;
        Karaktär motståndare;
        int tid;
        bool attack;
        bool shield;
        int minskning;
        string färg;
        public static bool fightOver;
        public static bool fightWon;
        public Fight()
        {
            InitializeComponent();
            //Skapa två objekt 
            fightKaraktär = new Karaktär();
            motståndare = new Karaktär();


            pbxFightKaraktär.Image = fightKaraktär.VilkenKaraktär(Main.färg);
            fightKaraktär.level = Main.level;

            pbxMotståndare.Image = motståndare.VilkenKaraktär("Red");

            lblNamn.Text =   Main.namn;
            lbMotståndareNamn.Text = motståndare.namn;

            //Sätter max värdet för progressbar
            prbFightKaraktär.Maximum = 60;
            prbMotståndare.Maximum = 60;
            prbAttack.Maximum = 3;
            prbShield.Maximum = 3;

            //Sätter start värdet på progressbar  
            prbFightKaraktär.Value = 60;
            prbMotståndare.Value = 60;
            prbAttack.Value = 0;
            prbShield.Value = 0;

            minskning = 1;
            färg = Main.färg;

            timerBtn.Start();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (prbMotståndare.Value - 3 > 0)
            {
                prbMotståndare.Value -= 3;

            }
            else
            {
                lblGameOver.Text = "You Won!!";
                lblGameOver.BackColor = Color.Green;
                fightOver = true;
                fightWon = true;
                timerBtn.Stop();

            }
            btnAttack.Enabled = false;

            attack = false;

        }
        private void btnShield_Click(object sender, EventArgs e)
        {
            minskning = 0;
            shield = false;
            btnShield.Enabled = false;
        }

        private void fightTimer_Tick(object sender, EventArgs e)
        {

        }

        private void timerBtn_Tick(object sender, EventArgs e)
        {
            timerBtn.Interval = 1000;
            tid += 1;

            //Gör så att man endast kan attackera en gång var tredje sekund 
            if (attack == false & prbAttack.Value < 4)
            {

                if (prbAttack.Value == 3)
                {
                    prbAttack.Value = 0;
                    btnAttack.Enabled = true;
                    attack = true;
                }
                else
                {
                    prbAttack.Value += 1;

                }
            }

                //Gör så att man endast kan få en sköld en gång var tredje sekund 
                if (shield == false & prbShield.Value < 4)
                {

                    if (prbShield.Value == 3)
                    {
                        prbShield.Value = 0;
                        btnShield.Enabled = true;
                        shield = true;
                        minskning = 1;    

                    }
                    else
                    {
                        prbShield.Value += 1;

                    }

                }

            if (prbFightKaraktär.Value - minskning > 0)
            {
                prbFightKaraktär.Value -= minskning;
            }
            else
            {
                lblGameOver.Text = "You Lost";
                fightOver = true;
                fightWon = false;
                timerBtn.Stop();

            }
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
            fightOver = true;

        }
    }
}
