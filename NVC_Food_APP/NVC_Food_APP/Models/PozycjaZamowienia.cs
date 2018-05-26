namespace NVC_Food_APP.Models
{
    internal class PozycjaZamowienia
    {
        public int PozycjaZamówienia { get; set; }
        public int ZamowienieID { get; set; }
        public int JedzenieID { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupu { get; set; }

        public virtual Jedzenie jedzenie { get; set; }
        public virtual Zamowienie zamowienie { get; set; }

    }
}