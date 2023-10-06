namespace Lab1_OptWeb
{
    public class Jucator:Interface
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public string Echipa { get; set; }
        public List<Performanta> Performante { get; set; }

        public Jucator(string nume, string prenume, int varsta, string echipa)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Echipa = echipa;
            Performante = new List<Performanta>();
        }

        public void AdaugaPerformanta(string titlu, string anDobandire)
        {
            Performante.Add(new Performanta(titlu, anDobandire));
        }

        public void AfiseazaDetalii()
        {
            Console.WriteLine($"Nume: {Nume}");
            Console.WriteLine($"Prenume: {Prenume}");
            Console.WriteLine($"Varsta: {Varsta}");
            Console.WriteLine($"Echipa: {Echipa}");
            Console.WriteLine("Performante:");
            foreach (var performanta in Performante)
            {
                Console.WriteLine($"- Titlu: {performanta.Titlu}, An dobândire: {performanta.AnDobandire}");
            }
            Console.WriteLine();
        }
    }
}
