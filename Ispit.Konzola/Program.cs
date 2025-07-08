using Ispit.Model.Klase;

namespace Ispit.Konzola;

internal class Program
{
    static void Main(string[] args)
    {
        // 7a
        
        var grupirajPremaBanci = Podaci.ListaKlijenata
            .Where(x => x.Stanje > 1000000)
            .GroupBy(x => x.Banka)
            .Select(x =>
            new GrupiraniMilijunasi(x.Key, x.Select(x => x.ImePrezime)));


        // 7b

        foreach (var banka in grupirajPremaBanci)
        {
            Console.Write($"\n{banka.Banka}: ");
            foreach (var klijent in banka.Milijunasi)
            {
                Console.Write(klijent);
            }
        }


        // 7c

        var izvjestajMilijunasa = Podaci.ListaKlijenata
            .Where(x => x.Stanje > 1000000)
            .Join(Podaci.ListaBanki,
                klijent => klijent.Banka,
                banka => banka.Simbol,
                (klijent, banka) => new
                {
                    Ime = klijent.ImePrezime,
                    Banka = banka.Naziv
                });


        // 7d

        Console.WriteLine();
        Console.WriteLine();

        foreach (var milijunas in izvjestajMilijunasa)
        {
            Console.WriteLine($"{milijunas.Ime} je u {milijunas.Banka}");
        }






    }
}
