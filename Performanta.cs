namespace Lab1_OptWeb
{
    public class Performanta:Interface
    {
        public string Titlu { get; set; }
        public string AnDobandire { get; set; }

        public Performanta(string titlu, string anDobandire)
        {
            Titlu = titlu;
            AnDobandire = anDobandire;
        }
    }
}
