public class kodebuah
{
    public enum namabuah
    { apel, aprikot, alpukat, pisang, paprika, blackberry, ceri, kelapa, jagung}

    public static string getkodebuah(namabuah namabuah)
    {
        String[] kodebuah = { "AA0", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
            return kodebuah[(int)namabuah];
    }
    static void Main(string[] args)
    {
        kodebuah namabuah = new kodebuah();
        Console.WriteLine("Nama buah = " + namabuah);
        string namabuah = Console.ReadLine();
        String kodebuah = kodebuah.getkodebuah();
    }
}
