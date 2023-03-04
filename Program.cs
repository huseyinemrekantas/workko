using System;

namespace workko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions questions = new Questions();
            questions.quest1();
            questions.quest2();
            questions.quest3();
            questions.quest4();

            
        }
    }
    class Questions
    {
        public void quest1()
        {
            //1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.WriteLine("Soru 1:");
            int n = 0;
            try
            {
                Console.WriteLine("Pozitif bir sayi giriniz bu sayi dizinin boyutunu belirleyecektir.");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz. " );
                Console.WriteLine(ex);
                return;
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil. " );
                Console.WriteLine(ex);
                return;
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz. " );
                Console.WriteLine(ex);
                return;
            }
            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dizinin {0}. elemanini giriniz: ", (i + 1));
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Çift olan sayilar");
            for (int i = 0; i < n; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.WriteLine(dizi[i]);
                }
            }
        }
        public void quest2()
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("2. soruya geçmek için bir tuşa basınz.");
            Console.ReadKey();
            Console.WriteLine("2 adet sayı girmeniz gerekiyor ilk girdiğin sayı 2. sayı ile kıyas yapacağımız dizinin boyutunu belirleyecektir. \nBu dizideki elemanlar 2. sayı ile kıyaslanacak eşit veya tam bölüyor ise ekranınızda gösterilecektir");
            int n =Convert.ToInt32(Console.ReadLine());
            int m =Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: " , i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("M'e eşit veya tam bölünen sayılar:");
            for (int i = 0; i < n; i++)
            {
                if (dizi[i]%m == 0)
                {
                    Console.WriteLine(dizi[i]);
                }
            }
        }
        public void quest3()
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("3. soruya geçmek için bir tuşa basınz.");
            Console.ReadKey();
            Console.WriteLine("Kelime dizisi için bir sayı giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] dizi = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. kelimeyi giriniz: " , i+1);
                dizi[i] = Console.ReadLine();
            }
            Console.WriteLine("Girdiğiniz kelimerin sondan başa doğru yazımı:");
            for (int i = n - 1; i > -1; i--)
            {
                Console.WriteLine(dizi[i]);
            }
        }
        public void quest4()
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.WriteLine("4. soruya geçmek için bir tuşa basınz.");
            Console.ReadKey();
            Console.WriteLine("Toplam kelime ve harf sayısını görmek istediğiniz Cümleyi yazın.");
            string cumle = Console.ReadLine();
            string[] dizi = cumle.Split(" ");
            string birlesikCumle = string.Join("",dizi);
            char[] harfDizisi = birlesikCumle.ToCharArray();
            Console.WriteLine("Toplam kelime sayısı: {0} \nToplam harf sayısı: {1}",dizi.Length,harfDizisi.Length);
        }
    }
}