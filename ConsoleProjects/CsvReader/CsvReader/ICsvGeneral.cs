namespace CsvReader;

public interface ICsvGeneral
{
    
    public void FileReadByData(Stream stream);
    public void FileReadByData(StreamReader reader);
    
}

public class CsvGeneral : ICsvGeneral
{
    public CsvData data = new CsvData();
    public void FileReadByData(Stream stream)
    {
        using (StreamReader reader = new StreamReader(stream))
        {
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                char c = new[] {',',';'}.FirstOrDefault(c => line.Contains(c));

                if (c == '\0') throw new Exception("Csv file not correct");

                data.AddRow(new CsvRow(line,c));
            }
        }
    }
    public void FileReadByData(StreamReader reader)
    {

    }
}