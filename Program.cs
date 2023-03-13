using modul4_1302213020;

class Program
{
    public static void Main()
    {
        KodeBuah buah = new KodeBuah();
        Console.WriteLine(buah.getKodeBuah("Apel"));
        Console.WriteLine(buah.getKodeBuah("Alpukat"));
        Console.WriteLine(buah.getKodeBuah("Durian"));
        Console.WriteLine(buah.getKodeBuah("Semangka"));
        Console.WriteLine(buah.getKodeBuah("Kelapa"));

        PosisiKarakterGame posisi = new PosisiKarakterGame();
            
        posisi.TombolW();
        posisi.TombolX();
    }
}