using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model.Klase;

public class Podaci
{
    public static List<Banka>? ListaBanki = new List<Banka>()
    {
        new Banka("RBA", "Raiffeisen Banka"),
        new Banka("ZABA", "Zagrebacka Banka"),
        new Banka("HNB", "Hrvatska Narodna Banka")
    };
    public static List<Klijent>? ListaKlijenata = new List<Klijent>()
    {
        new Klijent("Ivo Petric", 2564887.45, "RBA"),
        new Klijent("Marko Uvodic", 123.43, "RBA"),
        new Klijent("Petar Preradovic", 4632.23, "RBA"),
        new Klijent("Tomislav Mrduljas", 7344.51, "ZABA"),
        new Klijent("Nino Stapic", 5222598.01, "ZABA"),
        new Klijent("Kreso Potocnjak", 2998.71, "ZABA"),
        new Klijent("Igor Mihovilovic", 12.34, "ZABA"),
        new Klijent("Ivan Martinovic", 45.51, "HNB"),
        new Klijent("Ivona Pelajic", 4678881.32, "HNB"),
        new Klijent("Dora Kukuruz", 23.43, "HNB"),
    };

}
