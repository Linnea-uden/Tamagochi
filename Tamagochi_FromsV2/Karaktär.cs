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

    class Karaktär
    {
        //Bilder på olika pokemon karaktärer 
        Bitmap blue1 = Properties.Resources.pokemonBlueLevel1;
        Bitmap blue2 = Properties.Resources.pokemonBlueLevel2;
        Bitmap blue3 = Properties.Resources.pokemonBlueLevel3;

        Bitmap red1 = Properties.Resources.pokemonRedLevel1;
        Bitmap red2 = Properties.Resources.pokemonRedLevel2;
        Bitmap red3 = Properties.Resources.pokemonRedLevel3;

        Bitmap green1 = Properties.Resources.pokemonGreenLevel1;
        Bitmap green2 = Properties.Resources.pokemonGreenLevel2;
        Bitmap green3 = Properties.Resources.pokemonGreenLevel3;

        //medelemsvariabler
        public int level;
        public string namn;
        //Konstruktor 
        public Karaktär()
        {
            level = 1;
        }

        //Egenskaper
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }

        //Metoder 

        public Bitmap VilkenKaraktär(string färg)
        {
            Bitmap karaktär = null;

            if (färg == "Blue")
            {
                if (level == 1)
                {
                    karaktär = blue1;
                    namn = "Squirtle";
                }
                if (level == 2)
                {
                    karaktär = blue2;
                    namn = "Kameeru";

                }
                if (level == 3)
                {
                    karaktär = blue3;
                    namn = "Blastoise";

                }
            }
            else if (färg == "Red")
            {
                if (level == 1)
                {
                    karaktär = red1;
                    namn = "Charmander";

                }
                if (level == 2)
                {
                    karaktär = red2;
                    namn = "Rizaado";

                }
                if (level == 3)
                {
                    karaktär = red3;
                    namn = "Charizard";

                }
            }
            else if (färg == "Green")
            {
                if (level == 1)
                {
                    karaktär = green1;
                    namn = "Bulbasaur";

                }
                if (level == 2)
                {
                    karaktär = green2;
                    namn = "Ivysaur";

                }
                if (level == 3)
                {
                    karaktär = green3;
                    namn = "Venusaur";

                }
            }
            return karaktär;
        }

        public int LevelUp()
        {
            if (level < 3)
            {
                level += 1;

            }

            return level;
        }
    }
}
