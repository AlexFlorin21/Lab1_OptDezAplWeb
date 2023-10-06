using Lab1_OptWeb;

    var jucatori = new List<Jucator>();

    var jucator1 = new Jucator("Cristiano", "Ronaldo", 38, " Al-Nassr");
    jucator1.AdaugaPerformanta("Balonul de Aur", "2017");
jucator1.AdaugaPerformanta("Balonul de Aur", "2016");
jucatori.Add(jucator1);

var jucator2 = new Jucator("Lionel", "Messi", 36, "Inter Miami");
    jucator2.AdaugaPerformanta("Balonul de Aur", " 2014");
jucatori.Add(jucator2);

foreach (var jucator in jucatori)
{
    jucator.AfiseazaDetalii();
}

