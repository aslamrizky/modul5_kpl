using System;

class HaloGeneric
{
    public void SapaUser(string user)
    {
        Console.WriteLine($"Halo use {user}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(nama);
    }
}