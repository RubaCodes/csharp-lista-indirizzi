//csharp-lista-indirizzi
//Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
using System.Reflection.PortableExecutable;

string csvPath = "../../../addresses.csv";

try
{
    StreamReader reader = new StreamReader(csvPath);
    while (!reader.EndOfStream)
    {
        string riga = reader.ReadLine();
        Console.WriteLine(riga);
    }

    reader.Close();
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e.Message);
}
