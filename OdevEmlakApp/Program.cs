using OdevEmlakLib;

namespace OdevEmlakApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var evListesi = new List<Ev>();

            SatilikEv sat = new SatilikEv();

            KiralikEv kira = new KiralikEv();

            string karar;
            string durum;
            do
            {
                Console.WriteLine("Evin durumunu giriniz(satılık/kiralık): ");
                durum=Console.ReadLine();
                if (durum.ToLower()=="satılık")
                { 
                    
                    sat.giris();                    
                    evListesi.Add(sat);
                    Console.WriteLine("**********************************");
                    
                }
                else if (durum.ToLower()=="kiralık")
                {                   
                    kira.giris();                                       
                    kira.dosyaKaydet();
                    Console.WriteLine("**********************************");
                }

                Console.WriteLine("devam etmek istiyor musunuz (evet/hayır)");
                karar = Console.ReadLine();
            } while (karar.ToLower()=="evet");

            foreach (Ev ev in evListesi)
            {
                if (ev is SatilikEv)
                {
                    (ev as SatilikEv).dosyaKaydet();
                }
                else if (ev is KiralikEv)
                {
                    (ev as KiralikEv).dosyaKaydet();
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("bilgiler ilgili dosyalara kaydedildi");
            Console.WriteLine("\n");

            Console.WriteLine("Kaydedilmiş dosya yazdırılsın mı? (evet/hayır)");
            string cevap = Console.ReadLine();
            if (cevap.ToLower() == "evet")
            {
                foreach (Ev ev in evListesi)
                {
                    if (ev is SatilikEv)
                    {
                        (ev as SatilikEv).dosyaYazdır();
                    }
                    else if (ev is KiralikEv)
                    {
                        (ev as KiralikEv).dosyaYazdır();
                    }
                }
            }




            
        }
        class Liste<T, U, V>
        {

        }
    }
}

