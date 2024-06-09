using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OdevEmlakLib
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {
            
        }
        public SatilikEv(string durum, int odasayisi, int katno, string bolge, double alan, double fiyat) : base(durum,odasayisi, katno, bolge, alan)
        {
            this.Fiyat = fiyat;
        }
        private double fiyat;

        public double Fiyat { get; set ; }


        public override string ToString()
        {
            return $"{base.ToString()}\nSatış fiyatı: {this.Fiyat} TL \n\n";
        }
            
            
        public override void giris()
        {           
            base.giris();
            Console.WriteLine("Evin satış fiyatını giriniz: ");
            this.Fiyat = double.Parse(Console.ReadLine());
            Console.WriteLine("************************************");
        }
            
        public override void dosyaKaydet()
        {
            using (StreamWriter sw = new StreamWriter("satilikEv.txt", true))
            {
                sw.WriteLine(this.ToString());
            }
        }

        public override void dosyaYazdır()
        {
            using (StreamReader sr = new StreamReader("satilikEv.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        
    }

    
}

