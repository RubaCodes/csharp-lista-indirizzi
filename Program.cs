//csharp-lista-indirizzi
//Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
string csvPath = "../../../addresses.csv";
List<Indirizzo> Indirizzi = new List<Indirizzo>();


try
{
    StreamReader reader = new StreamReader(csvPath);
    //leggo prima linea per skipparla
    reader.ReadLine();
    while (!reader.EndOfStream)
    {
        string riga = reader.ReadLine();
        string[] rigaEsplosa = riga.Split(',');
        //assegnazione per costruttore
        string street = rigaEsplosa[2].Trim();
        string city = rigaEsplosa[3].Trim();
        string province = rigaEsplosa[4].Trim();
       // int zip = Convert.ToInt32(rigaEsplosa[5]);
        //nuovo indirizzo
        Indirizzo newAddress = new Indirizzo(street, city, province, 1111);
        //aggiunta indirizzo
        Indirizzi.Add(newAddress);
    }

    reader.Close();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
