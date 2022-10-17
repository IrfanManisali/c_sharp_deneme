using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace odev2_1
{
    class ListIslemleri
    {
        private ArrayList input;

        private ArrayList asalList;

        private double asalListOrtalama;

        private ArrayList asalOlmayanList;

        private double asalOlmayanListOrtalama;

        private ArrayList Input
        {
            get
            {
                return input;
            }
            set
            {
                if (value != null)
                {
                    input = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş.");
                }
                
            }
        }

        public ListIslemleri(ArrayList input)
        {
            this.Input = input;
        }

        private void ListeyeAtma()
        {
            asalList = new ArrayList();
            asalOlmayanList = new ArrayList();

            foreach (int item in input)
            {
                if (AsalSayıKontrol(item) == true)
                {
                    asalList.Add(item);
                }
                else
                {
                    asalOlmayanList.Add(item);                    
                }
            }
        }

        private void ListeSıralama()
        {
            asalList.Sort();
            asalOlmayanList.Sort();
        }

        public void SonucYazdır()
        {
            ListeyeAtma();
            ListeSıralama();
            ListeOrtalaması();
            EkranaYazdır();
        }

        private bool AsalSayıKontrol(int sayi)
        {
            if (sayi == 1)
            {
                return false;
            }
            else if (sayi == 2 || sayi ==3)
	        {
                return true;		 
	        }
            else
            {
                return AsalSayıBulma(sayi);
            }
        }

        private bool AsalSayıBulma(int sayi)
        {
            for (int bölen = sayi - 1; bölen > 1; bölen--)
            {
                if (sayi % bölen == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void ListeOrtalaması()
        {
            asalListOrtalama = -1;

            int asalListToplam = 0;

            asalOlmayanListOrtalama = -1;

            int asalOlmayanListToplam = 0;

            foreach (var item in asalList)
            {
                asalListToplam += Convert.ToInt32(item); 
            }

            foreach (var item in asalOlmayanList)
            {
                asalOlmayanListToplam += Convert.ToInt32(item); 
            }

            asalOlmayanListOrtalama = asalOlmayanListToplam / asalOlmayanList.Count;
            asalListOrtalama = asalListToplam / asalList.Count;
            
        }

        private void EkranaYazdır()
        {
            Console.WriteLine("***Asal Sayılar***");

            foreach (var item in asalList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ortalama: " + asalListOrtalama);

            Console.WriteLine("***Asal Olmayan Sayılar***");

            foreach (var item in asalOlmayanList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ortalama: " + asalOlmayanListOrtalama);
        }

                
    }
}