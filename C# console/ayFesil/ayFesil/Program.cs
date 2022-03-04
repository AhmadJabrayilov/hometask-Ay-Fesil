using System;

namespace ayFesil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region fesil
            string ay = " "; //Bura ayin adi yazilir.

            if (ay=="Dekabr")
            {
                Console.WriteLine("Qish");
            }
            if (ay=="Yanvar")
            {
                Console.WriteLine("Qish");
            }
            if (ay=="Fevral")
            {
                Console.WriteLine("Qish");
            }
            if (ay=="Mart")
            {
                Console.WriteLine("Aprel");
            }
            if (ay=="May")
            {
                Console.WriteLine("Yaz");
            }
            if (ay=="Iyun")
            {
                Console.WriteLine("Yay");
            }
            if (ay=="Iyul")
            {
                Console.WriteLine("Yay");
            }
            if (ay=="Avqust")
            {
                Console.WriteLine("Yay");
            }
            if (ay=="Sentyabr")
            {
                Console.WriteLine("Payiz");
            }
            if (ay=="Oktyabr")
            {
                Console.WriteLine("Payiz");
            }
            if (ay=="Noyabr")
            {
                Console.WriteLine("Payiz");
            }

            #endregion

            Console.WriteLine("Ayin adini daxil edin: " );
            string ayAdi = Console.ReadLine();
            switch (ayAdi)
            {
                case "Dekabr":Console.WriteLine("Qish");
                    break;
                case "Yanvar": Console.WriteLine("Qish");
                    break;
                case "Fevral":
                    Console.WriteLine("Qish");
                    break;
                case "Mart":
                    Console.WriteLine("Yaz");
                    break;
                case "Aprel":
                    Console.WriteLine("Yaz");
                    break;
                case "May":
                    Console.WriteLine("Yaz");
                    break;
                case "Iyun":
                    Console.WriteLine("Yay");
                    break;
                case "Iyul":
                    Console.WriteLine("Yay");
                    break;
                case "Avqust":
                    Console.WriteLine("Yay");
                    break;
                case "Sentyabr":
                    Console.WriteLine("Payiz");
                    break;
                case "Oktyabr":
                    Console.WriteLine("Payiz");
                    break;
                case "Noyabr":
                    Console.WriteLine("Payiz");
                    break;
                default:
                    Console.WriteLine("yanlish ay adi veya ilk herfin boyuk oldugunu yoxlayin "); 
                    break;
            }
        }
    }
}
