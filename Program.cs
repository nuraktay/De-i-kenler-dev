using System;

namespace degisken
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine("");

            byte b = 5;        //1 byte yer kaplar 0-255 arası
            sbyte c = 5;       //1byte yer kaplar -128 ile 127 arası

            short s = 5;       //2byte -32768 ile +32768e kadar değer alabilir.
            ushort us = 5;     //2byte 0-65.365 arası değer alabilir

            Int16 i16 = 2;     //2 byte 
            int i = 2;         //4 byte
            Int32 i32 = 2;     //4byte
            Int64 i64 = 2;     //8 byte

            uint ui = 2;       //4byte (- değer alamayan + değerdeki karşılığı)
            long l = 4;        //8byte
            ulong ul = 4;      //8byte (- değer alamayan + değerdeki karşılığı)

            float f = 5;       //4byte (reel sayılar için)
            double d = 5;      //8byte
            decimal de = 5;    //16byte

            char ch = '2';   //2byte (tek karakter için yeterli)
            string str = "Nur"; //sınırsız (daha maliyetli)

            bool b1 = true;
            bool b2 =false;
            
            DateTime dt = DateTime.Now; //Hazırladığım saat

            object o1 = "x"; //Her tür veriyi alır.
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "RNA";
            string ad = "Rabia Nur";
            string soyad = "Aktay";
            string tamisim = ad + "" + soyad;

            // integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;
            
            //boolean 
            
            bool bo1 = 10 < 2;

            //Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger); //Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //Çıktısı 40

            int int22 = int20 + int.Parse(str20); //ÇIktısı 40 parse ile string olarak gelen tarih bilgisi DateTime'a dönüstürüldü

            // string datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime1); 

             string Hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(Hour);

        }
    }

}