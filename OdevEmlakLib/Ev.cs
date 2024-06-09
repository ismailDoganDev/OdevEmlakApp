using System;

namespace OdevEmlakLib
{
    public abstract class Ev
    {
        public Ev()
        {
            
        }
        public Ev(string durum,int odaSayisi, int katNo, string bolge, double Alan)
        {
            this.Durum = durum;
            this.OdaSayisi = odaSayisi;
            this.KatNo = katNo;
            this.Bolge=bolge;
            this.Alan = alan;
            
        }


        private int odaSayisi;
        private int katNo;
        private double alan;
        private string bolge;
        private string durum;
        

        public int OdaSayisi { get => odaSayisi; set => odaSayisi = Math.Abs(value); }
        public int KatNo { get; set; }
        public double Alan { get; set; }
        public string Bolge { get; set; }
        public string Durum { get; set; }

        public virtual void giris() 
        {
            Console.WriteLine("Evin durumunu tekrar giriniz (satılık/kiralık): ");
            this.durum=Console.ReadLine();
            Console.WriteLine("Oda sayısını giriniz: ");
            OdaSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Evin kaçıncı katta olduğunu giriniz: ");
            KatNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Evin kaç metrekare olduğunu giriniz: ");
            Alan = double.Parse(Console.ReadLine());
            Console.WriteLine("Evin bulunduğu bölgeyi giriniz: ");
            Bolge = Console.ReadLine();
        }
        
        public abstract void dosyaKaydet();

        public abstract void dosyaYazdır();
        

        public override string ToString()
        {
            return $"Evin durumu: {this.durum}\nOda sayısı: {this.OdaSayisi}\nKat No: {this.KatNo}. " +
                $"Kat\nAlan: {this.Alan}\nEvin Bölgesi: {this.Bolge}";
        }
    }
}

