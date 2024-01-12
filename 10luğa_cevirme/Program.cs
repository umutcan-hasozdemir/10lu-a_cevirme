using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ikilik sistemdeki sayıyı giriniz: ");
        string binaryInput = Console.ReadLine();

        if (long.TryParse(binaryInput, out long sayi))
        {
            ConvertBinaryToDecimal(sayi);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen ikilik sistemde bir sayı girin! ");
        }

        Console.ReadLine();
    }

    static void ConvertBinaryToDecimal(long sayi)
    {
        long ikiliDeger = sayi;
        long onluDeger = 0, tabanDeger = 1, basamakDeger;

        while (sayi > 0)
        {
            basamakDeger = sayi % 10;
            onluDeger = onluDeger + basamakDeger * tabanDeger;
            sayi = sayi / 10;
            tabanDeger = tabanDeger * 2;
        }

        Console.WriteLine($"Ikili (Binary) Sayı: {ikiliDeger}");
        Console.WriteLine($"Onlu (Decimal) Sayı: {onluDeger}");
    }
}
