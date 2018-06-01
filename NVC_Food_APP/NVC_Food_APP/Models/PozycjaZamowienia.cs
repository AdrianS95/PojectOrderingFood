namespace NVC_Food_APP.Models
{
    public class PozycjaZamowienia
    {
        public int PozycjaZamowieniaId { get; set; }
        public int ZamowienieID { get; set; }
        public int JedzenieId { get; set; }
        public int Ilosc { get; set; }
        public decimal CenaZakupu { get; set; }

        public virtual Jedzenie jedzenie { get; set; }
        public virtual Zamowienie zamowienie { get; set; }
    }
}