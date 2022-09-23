//csharp-lista-indirizzi
//Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
string csvPath = "../../../addresses.csv";
List<Indirizzo> Indirizzi = new List<Indirizzo>();



if (File.Exists(csvPath))
{
    StreamReader reader = new StreamReader(csvPath);
    //leggo prima linea per skipparla
    reader.ReadLine();
    while (!reader.EndOfStream)
    {
        string riga = reader.ReadLine();
        string[] rigaEsplosa = riga.Split(',');
        //assegnazione per costruttore
        try
        {
            string street = rigaEsplosa[2].Trim();
            string city = rigaEsplosa[3].Trim();
            string province = rigaEsplosa[4].Trim();
            int zip = Convert.ToInt32(rigaEsplosa[5]);
            //nuovo indirizzo
            Indirizzo newAddress = new Indirizzo(street, city, province, zip);
            //aggiunta indirizzo
            Indirizzi.Add(newAddress);
            Console.WriteLine("Indirizzo inserito correttamente");
            Console.WriteLine(newAddress.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine("Errore nell'inserimento dell'indirizzo: " + e.Message);
        }
            
    }
    reader.Close();
}

//return;