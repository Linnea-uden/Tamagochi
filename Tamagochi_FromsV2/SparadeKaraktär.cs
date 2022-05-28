using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_FromsV2
{
    class SparadeKaraktär
    {
        int[] lista;
        string namn;
        //Konstruktor 

        public SparadeKaraktär()
        {
            lista = new int[5];
        }

        //Egenskaper
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        //Metoder 
        public void Spara(int vikt, int level, int hunger, int ångest, int trötthet, string färg)
        {
            lista[0] = vikt;
            lista[1] = level;
            lista[2] = hunger;
            lista[3] = ångest;
            lista[4] = trötthet;


            using (StreamWriter sw = File.AppendText("log.txt"))
            {
                sw.Write("Namn."+ CreateNew.Namn + ".:");
                foreach (var item in lista)
                {
                    
                    sw.Write(item + ".");
                }
                sw.Write(":" + färg);
                sw.WriteLine();
            }
        }
        public string[] hämtaNamn()
        {
            int antalNamn = 0;
            foreach (var line in File.ReadAllLines("log.txt"))
            {
                antalNamn++;
            }

            string[] namnLista = new string[antalNamn];
            string texthållare;
            string[] lineLista;
            string namn;
            int i = 0;
            using (StreamReader sr = new StreamReader("log.txt"))
            {
                foreach (var line in File.ReadAllLines("log.txt"))
                {
                    if (line.Contains("Namn"))
                    {
                        texthållare = line;
                        lineLista = texthållare.Split('.');
                        namn = lineLista[1];
                        
                       namnLista[i] = namn;
                    }
                    i++;


                }
            }
            return namnLista;


        }

        public string hämtaVärden()
        {
            //string path = @"C:\\Users\\Linnea\\Desktop\\Coding\\Tamagochi.txt";
            int antalNamn = 0;
            foreach (var line in File.ReadAllLines("log.txt"))
            {
                antalNamn++;
            }

            string värde = null;
            string texthållare;
            string[] listhållare = new string[2];
            int i = 0;
            
            using (StreamReader sr = new StreamReader("log.txt"))
            {
                foreach (var line in File.ReadAllLines("log.txt"))
                {
                    if (line.Contains("Namn"))
                    {
                        texthållare = line;
                        listhållare = texthållare.Split(':');
                        värde = listhållare[1];
                    }
                    i++;
                }
            }
            return värde;

        }
        public string hämtaFärg()
        {
            string texthållare;
            string[] list;
            string färg = null;
            using (StreamReader sr = new StreamReader("log.txt"))
            {
                foreach (var line in File.ReadAllLines("log.txt"))
                {
                    if (line.Contains("Namn"))
                    {
                        texthållare = line;
                        list = texthållare.Split(':');
                        färg = list[2];
                    }
                }
            }
                return färg;
        }

       
    }
}
