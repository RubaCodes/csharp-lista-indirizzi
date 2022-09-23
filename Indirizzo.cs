
public class Indirizzo {

    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public int Zip { get; set; }

    public Indirizzo(string street  ,string city ,string province ,int zip) {
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }

    public override string ToString()
    {
        string stringa = "------ Indirizzo ------\n";
        stringa += "Indirizzo:\t" + Street + "\n";
        stringa += "Citta':\t" + City + "\n";
        stringa += "Provincia:\t" + Province + "\n";
        stringa += "Zip:\t" + Zip + "\n";
        stringa += "-------------------";
        return stringa;
    }
}
