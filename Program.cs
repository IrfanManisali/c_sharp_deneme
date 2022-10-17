using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace odev2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int klavyedenGirilenSayi = 5;

            ArrayList input = new ArrayList();
            DegerOkuma d1 = new DegerOkuma(klavyedenGirilenSayi,input);
            d1.DegerOku();
            ListIslemleri l1 = new ListIslemleri(input);
            l1.SonucYazdır();
            Console.ReadLine();
        }
    }
}
