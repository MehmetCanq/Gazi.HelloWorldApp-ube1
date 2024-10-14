using System;

namespace Gazi.HelloWorldAppŞube1
{
    internal class Program
    {
        static int sayi = 5;
        static void Main(string[] args)
        {


            // Değişgenler-Veri Yapıları (RAM de depolanır)

          // console.writeline("herkese salam");
           // console.writeline("gazideyim");
           // console.writeline("adam gafamamınan dalga geçiyor");
            


            //byte a;//Veri tipi: byte,ismi a
            //byte b;
            //a = 10;//a değişgenine değer ataması.
            //b = 20;

            //byte c = 30;// hepsini beraber yapabilirsin tek satırda.


            //byte a = 30, b;//Şeklindede yazabiliriz
            //b = 20;

            byte a, b;
            a = 100; b = 20;

            // const byte number;
            // number = 30;     BU YANLIŞ BİR GÖSTERİM

            //const byte number = 30; DOĞRUSU BU 


            //byte yas;
            //Consol.Writeline(yas);//Değeri olmayan değişkenler çalışmaz

            var sayi = 5.45D;//Implicit (Veri tipinin belirtilmeden yapıldığı durum)

            double number = 5.45; //Explicit ( Veri tipinin belirtildiği durum)

            char c = 'A';

            string isim = "Ahmet";
            string soyad = "Mehmet";


            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}

//Namespace: içinde classları bulunduran yapılardır.
//{} Scope(blok) yapılardır.
//Class:İçinde metotları bulunduran yapılardır.(şimdilik)
//Metod:İş yapan kod bloklarına metod denir.
//Main metodu: Console uygulamalarının giriş noktasıdır.Her consol uygulaması,main metodu ile başlar.
//Ctrl+F5: Hata ayıklama modu olmadan programı çalıştırır.
//İnsert: araya yazma 
//Syntax:programlama dilleri yazım kuralları
//C# Syntax:
//1- Açılan parantezler mutlaka kapatılmalıdır.
//2- Scope tanımlamalarının sonunda (;) bulunmaz.
//3- Satır sonlarında noktalı virgül (;) bulunur.
//4- Syntax hatası olursa program derlenmez dolayısıyla çalışmaz VS hata olan yerin altını kırmızı çizgi ile işaretler. bunula birlikte scroolbarda kırmızı ile gösterir
//5- VS penceresinin alt kısmındada kırmızı bir çarpı ile gösterir ve kaç hata varsa yazar.
//6- IntelliSense: Kod yazarken yardımcı olan, açılan pencere.
//7- IntelliCode: Yapay zeka destekli kod yazım yardımcısı
//8- Metodların sonunda mutlaka () bulunur 

//9- Solution Explorer: Solution'ınımız içindeki projelere ulaşabileceğimiz penceredir.
//10- View menusü  aracılıyla açılabilir
//11- Solution: Bir yada birden fazla proje içerebilirler.  

//12- ctrl+K+c açıklama satırı olarak çevirir
//13- ctrl+k+u geri çevirir
//14- ctrl+B derleme yapar
//15- ctrl+k+D hiyerarşiyi sağlar
// Tanımlamalara gitmek için seçip F12 bas


//16- C#->Derleme->MS-IL->Derleme(.NET Runtime)->0-1(binary)

//17- MS-IL: microsoft Intermediate Language(ara dil)



//değişken tanımlama önrmliler stack ve hea
// const byte da sonradan değiştirilemez ve const sadece tek satırda kullanılmalı      
// temel sayı türleri :
// byte: 8b bittir 0-255 arasıdır ve işaretsizdir
// int: 32 bittir -2147483648 ile bu sayının pozitifi arasındadır


// 1 bit = 0 veya 1 
// 8 bit = 1 byte
// 1 kilo byte (kb) = 1024 byte
// 1 mega byte (mb) = 1024 kb
// 1 Giga byte (gb) = 1024 mb
// 1 tera byte (tb) = 1024 gb 



// diğer tam sayı türleri tam sayı
//sbyte: 8 bit  -128 ile 127 arası değer alır işaretli
//short: 16 bit -32768 ile pozitifi arası değer alır işaretli
//ushort: 16 bit 0 ile 32768 değer alır isaretsiz
//long: 64 bit tir işaretli

// Reel sayı birimleri kalanlı
//float: 32 bit sonuna f gelir
//Double: 64 bit sonuna D gelir
//Decimal: 128 bit sonuna m gelir
// !! (var) değişken açık belirtilmeden istediğine çevirme 



// TEMEL VERİ TÜRLERİ
//bool : değeri true yada false belirtilir    "bool sonuc = false;" gibi,
//char : tek bir karakter atamak için kullanılır ve (') tek tırnak içine yazılır
//Unicod : kodun karşılığı olan harfleri barıdıran bir tablo \u olarak yazılır
//String :