using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace odev2_1
{
    class DegerOkuma
    {
        private int tekrarSayısı;

        ArrayList input;

        private ArrayList Input
        {
            set
            {
                this.input = value;
            }
        }

        private int TekrarSayısı
        {
            set 
            {
                
                if (value > 1)
	            {
                    tekrarSayısı = value + 1;                  	 
	            }
                else
                {
                    Console.WriteLine("Tekrar Sayısı yanlış formatta !");
                    tekrarSayısı = 3;
                }

                
            }
        }

        public DegerOkuma(int eleman, ArrayList input)
        {
            this.TekrarSayısı = eleman;
            this.Input = input;
        }

        public void DegerOku()
        {
            int iter = 1;

            while (true)
            {
            degerAl:

                if (iter == tekrarSayısı)
                {
                    break;
                }

                Console.Write(iter + " . sayı: ");

                try
                {
                    int deger = Convert.ToInt32(Console.ReadLine());
                    if (deger <= 0)
                    {
                        Console.WriteLine("Yanlış formatta giriş!");
                        goto degerAl;
                    }

                    iter++;
                    input.Add(deger);
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış formatta giriş!");
                    goto degerAl;
                }

            }
        }
    }
}