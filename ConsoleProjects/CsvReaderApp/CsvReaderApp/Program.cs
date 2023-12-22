namespace CsvReaderApp;


class Program
{
    static void Main()
    {
        string path = "../../../data/test1.csv";

        CsvData csv = new CsvData();
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                csv.AddRow(new CsvRow(line,','));
            }
        }

        foreach (CsvRow row in csv.Rows)
        {
            Console.WriteLine(string.Join(',',row.Cells));
        }
    }
}