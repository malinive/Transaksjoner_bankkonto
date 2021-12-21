using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCoreApp.Models;


namespace MyCoreApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Transactions> tran { get; set; }
        public List<Account> accounts { get; set; }


        public void OnGet() {

            //Legger alle transaksjoner i liste
            tran = new List<Transactions> {

            new Transactions() { transaksjonsID = 0, kategoriID = 3, dato = "2017-03-01T00:00:00", beloep = 20382.0, beskrivelse = "Lønn fra ACME AS" },
            new Transactions() { transaksjonsID = 1, kategoriID = 2, dato = "2017-03-02T00:00:00", beloep = -300, beskrivelse = "Uttak minibank Oasen" },
            new Transactions() { transaksjonsID = 2, kategoriID = 4, dato = "2017-03-02T00:00:00", beloep = -722.2, beskrivelse = "Meny Oasen" },
            new Transactions() { transaksjonsID = 3, kategoriID = 7, dato = "2017-03-03T00:00:00", beloep = -300, beskrivelse = "Overføring mellom egne konto" },
            new Transactions() { transaksjonsID = 4, kategoriID = 8, dato = "2017-03-02T00:00:00", beloep = -85.99, beskrivelse = "McDonalds Oasen" },
            new Transactions() { transaksjonsID = 5, kategoriID = 6, dato = "2017-03-05T00:00:00", beloep = -3082.0, beskrivelse = "Fjordkraft" },
            new Transactions() { transaksjonsID = 6, kategoriID = 8, dato = "2017-03-06T00:00:00", beloep = -438.37, beskrivelse = "Egon Lagunen" },
            new Transactions() { transaksjonsID = 7, kategoriID = 6, dato = "2017-03-06T00:00:00", beloep = -1984.0, beskrivelse = "Canal Digital" },
            new Transactions() { transaksjonsID = 8, kategoriID = 6, dato = "2017-03-08T00:00:00", beloep = -299.0, beskrivelse = "Telenor" },
            new Transactions() { transaksjonsID = 9, kategoriID = 5, dato = "2017-03-08T00:00:00", beloep = -2941.58, beskrivelse = "Komplett.no" },
            new Transactions() { transaksjonsID = 10, kategoriID = 7, dato = "2017-03-09T00:00:00", beloep = 500.0, beskrivelse = "Overføring mellom egne konto" },
            new Transactions() { transaksjonsID = 11, kategoriID = 4, dato = "2017-03-10T00:00:00", beloep = -132.0, beskrivelse = "Bunnpris Smiberget" },
            new Transactions() { transaksjonsID = 12, kategoriID = 9, dato = "2017-03-10T00:00:00", beloep = -694.0, beskrivelse = "Skyss" },
            new Transactions() { transaksjonsID = 13, kategoriID = 4, dato = "2017-03-10T00:00:00", beloep = -342.0, beskrivelse = "Coop Extra Bønes" },
            new Transactions() { transaksjonsID = 14, kategoriID = 6, dato = "2017-03-12T00:00:00", beloep = -4553.0, beskrivelse = "Lyshovden Brl" },
            new Transactions() { transaksjonsID = 15, kategoriID = 7, dato = "2017-03-14T00:00:00", beloep = 500.0, beskrivelse = "Overføring mellom egne konto" },
            new Transactions() { transaksjonsID = 16, kategoriID = 5, dato = "2017-03-16T00:00:00", beloep = -1135.62, beskrivelse = "Elkjøp Fyllingsdalen" },
            new Transactions() { transaksjonsID = 17, kategoriID = 4, dato = "2017-03-16T00:00:00", beloep = -746.12, beskrivelse = "Meny Oasen" },
            new Transactions() { transaksjonsID = 18, kategoriID = 9, dato = "2017-03-17T00:00:00", beloep = -492.42, beskrivelse = "Bergen Taxi" }


        };
            //legger kontonavn og saldo i en liste; Accounts
            accounts = new List<Account>
        {
            new Account() { kontonavn = "Brukskonto", saldo = 23254.9 }
        };



            //metoder for å skrive ut "sum inn" og "sum ut". Får ikke lagt de til i index.cshtml. 
            List<double> count = new List<double>();
            double sum = 0;
            Transactions transactions = new Transactions();
            for (int i = 0; i < tran.Count; i++)
            {
                if (transactions.beloep > 0)
                {
                    count.Add(transactions.beloep);
                    sum=sum+transactions.beloep;

                }
                else
                {
                    count.Add(0);
                }

                List<double> count1 = new List<double>();
                double sum1 = 0;
                Transactions transactions1 = new Transactions();
                for (int j = 0; j < tran.Count; j++)
                {
                    if (transactions1.beloep < 0)
                    {
                        count1.Add(transactions1.beloep);
                        sum1= sum1+transactions1.beloep;

                    }
                    else
                    {
                        count1.Add(0);
                    }
                }
            }



        }
        
    }
}