using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OdevEmlakLib
{
    public class KiralikEv:Ev
    {
        public KiralikEv()
        {
            
        }
        public KiralikEv(string durum,int odasayisi, int katno, string bolge, double alan, double Depozito, double Kira) : base(durum, odasayisi, katno, bolge, alan)
        {           
            this.Depozito1 = Depozito;
            this.Kira1 = Kira;
        }

        private double Kira;
        private double Depozito;

        public double Kira1 { get; set; }
        public double Depozito1 { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\nKira fiyatı: {this.Kira} Tl\nDepozito fiyatı: {this.Depozito} TL \n\n";
        }

        public override void giris()
        {
                base.giris();
                Console.WriteLine("Kira fiyatını giriniz: ");
                this.Kira = double.Parse(Console.ReadLine());
                Console.WriteLine("Depozito fiyatını giriniz: ");
                this.Depozito = double.Parse(Console.ReadLine());
                Console.WriteLine("************************************");           
        }

        public override void dosyaKaydet()
        {
            using (StreamWriter sw = new StreamWriter("kiralikEv.txt", true))
            {
                sw.WriteLine(this.ToString());
            }
        }

        public override void dosyaYazdır()
        {
            using (StreamReader sr = new StreamReader("KiralikEv.txt"))
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

