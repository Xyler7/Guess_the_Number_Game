using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Guess The Number ===");

        Random random = new Random();
        int cevap = random.Next(1, 101);

        int tahmin;
        int denemeSayisi = 0;
        bool tahminDogru = false;

        Console.WriteLine("1-100 arasinda bir sayi secildi. Tahmin et!\nA number between 1-100 was chosen. Guess!");

        do
        {
            Console.Write("Tahmininiz: \nGuess: ");
            string girilenTahmin = Console.ReadLine();

            if (int.TryParse(girilenTahmin, out tahmin))
            {
                denemeSayisi++;

                if (tahmin == cevap)
                {
                    tahminDogru = true;
                }
                else if (tahmin < cevap)
                {
                    Console.WriteLine("Daha büyük bir sayı girin.\nEnter a larger number.");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı girin.\nEnter a smaller number.");
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz.\Please enter a valid number.");
            }

        } while (!tahminDogru);

        Console.WriteLine($"Bravo!\n{denemeSayisi} denemede cevabı buldunuz!\You found the answer in {denemeSayisi} tries!");
        Console.WriteLine($"Cevap {cevap}");
    }
}
