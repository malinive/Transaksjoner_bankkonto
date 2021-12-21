namespace MyCoreApp.Models
{
    public class Transactions
    {
        //Modell for transaksjoner

        public int transaksjonsID { get; set; }
        public int kategoriID { get; set; }
        public string dato { get; set; }
        public double beloep { get; set; }
        public string beskrivelse { get; set; }

    }
}
