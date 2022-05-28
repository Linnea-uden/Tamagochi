using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_FromsV2
{
    class Tamagochi
    {
         //Medlemsvariabler
        private int trötthet;
        private int depression;
        private int hunger;
        private int ålder;
        private int vikt;
        private string namn;

        //Konstruktor 
        public Tamagochi()
        {
            trötthet = 100;
            depression = 100;
            hunger = 100;
            vikt = 100;
            ålder = 0;
        }

        //Egenskaper
        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }
        public int Trötthet
        {
            get { return trötthet; }
            set { trötthet = value; }
        }
        public int Depression
        {
            get { return depression; }
            set { depression = value; }
        }
        public int Ålder
        {
            get { return ålder; }
            set { ålder = value; }
        }
        public int Vikt
        {
            get { return vikt; }
            set { vikt = value; }
        }
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        //Metoder
        public int KnapptTryck(int currValue)
        {

            if (currValue < 99 && currValue > 0)
            {
                currValue += 2;

            }
            else
            {
                currValue = 100;
            }
            return currValue;
        }


    }
}
