namespace Gazi.HelloWorldAppSube
{
    internal class Program
    {
        static int sayi = 15;
        static void Main(string[] args)
        {
            #region Veri Tipleri ve Tanımlamaları
            Console.WriteLine("Gazi");
            Console.WriteLine("Üniversitesi");

            //byte a;
            //double d;
            //a=30;
            //d=40;

            byte a = 30;
            double d = 40;
            a = 50;
            Console.WriteLine();
            //const int a=50;
            //byte yas;
            //float sayi = 3.15f;
            //double _sayi = 3.15;
            //decimal __sayi = 3.15m; 
           
            var sayi = 10.5;  //(Veri tipi belirlemeden yapılan tanımlamalar)
            byte number = 5;  //Explicit(Veri tipinin açık olarak belirtildiği tanımlamalar)
            var sonuc = true;
            
            #endregion

            #region String Birleştirme İşlemleri
            string isim = "MEHMET";
            string soyad = "AHMET";

            Console.WriteLine("Hoşgeldin," + isim + " " + soyad);
            Console.WriteLine("Hoşgeldin, {0} {1}", isim, soyad);
            Console.WriteLine($"Hoşgeldin,  {isim}  {soyad}");
            #endregion

            
            #region Kullanıcı Etkileşimleri
            Console.Write($"İsminizi Giriniz");
            string name = Console.ReadLine(); 
            Console.Write($"Soyadınızı Giriniz") ;
            string surname= Console.ReadLine();
           
            Console.Write($"Yaşınızı Giriniz") ;
            string age= Console.ReadLine();
            
            
            Console.WriteLine($"Hoşgeldiniz\nİsminiz:{name}\nSoyadınız:{surname}\nYaşınız:{age}");
            #endregion


            Console.ReadKey();
            
        }
    }
}

//namespace:içinde classları bulunduran yapılardır.
//Scope (Blok Yapıları):{} parantezleri arasındaki yapılardır.
//Class:İçinde metodları bulunduran yapılardır.
//Metod:İş yapan kod bloklarına denir.
//Main metodu:Console uygulamalarının başlangıç noktasıdır.
//Ctrl+F5:Uygulamayı hata ayıklama modu olmadan başlatır. 
//Syntax:Kod yazım kuralları.
//1-Açılan her parantez mutlaka kapatılmalıdır.
//2-Scope tanımlamaları sonunda noktalı virgül kullanılmaz ancak komut satırları sonunda kullanılır.

//Syntax hatalarını anlamak için:
//1-Hata olna kodun altı kırmızı ile çizilir.
//2-Scrool bar'da hata olan yere kırmızı işaretleme yapılır.
//3-VS kod editörünün alt çubuğunda kırmızı renkli X ve yanında hata sayısı görülür.

//Syntax hatası olan program çalışır mı?Hayır çünkü program derlenmez.
//İntelliSense:Kod yazarken karşımıza çıkan pencere ile karşımıza çıkan öneriler
//İntellicode:Yapay zeka destekli kod yazım yardımcısı.Gelen önerileri TAB tuşu ile kabul edebiliriz.

//Solution->Project(s)
//View->Solution Explorer
//CTRL+K+D:Kod hiyerarşisini düzenlemek için kullanılır.
//CTRL+K+C:Seçili satırları açıklama satırları haline getirir.
//CTRL+K+U:Açıklama satırını tekrar normal satır haline getirir.
//CTRL+B:Kodu derler.

//C#->Derleme->MS-IL->.NET Runtime(Derleme) ->0-1(Binary)

//Microsoft Indermediate Language


//1byte=8 bit
//1 Kilo byte(KB)=1024 byte
//1 Megabyte(MB)=1024 KB
//1024 Megabyte(MB)=1 GB
//1024 Gigabyte(GB)=1 TB
//sbyte:Signed byte 
//ushort:Unsigned short

//Değer tipleri belleğin STACK bölgesini kullanır.
//Referans tipleri HEAP bölgesini kullanır.
//Heap bölgesi Stack bölgesine göre daha büyüktür.Dolayısıyla tek seferde birden fazla veri depolayabilir.Örn. AHMET stringinde 5 tane char vardır.
//Referans tipi değişkenlerde ,referanslar STACK bölgesinde ,değerler Heap bölgesinde tutulur.Değere ulaşmak için o değerin Heap bölgesindeki adresini bilen referansına ulaşmak gerekir.
//Metod Parametresi:Metodların işlerini yapabilmek için ihtiyaç duydukları verilerdir.Bir metod hiç parametre istemeyebilir yada birden fazla veri tipinde parametre de kabul edebilir.

//Void:Bu geri dönüş tipine sahip metodlar,işlerini yaptıktan sonra geriye bilgi döndürmezler. 