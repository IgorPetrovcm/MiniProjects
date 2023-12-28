using System.Data;

namespace CsvReader;

public interface ICsvGeneral
{
    public void ArrayReadByData(string[] arr);
    public void FileReadByData(Stream stream);
    public void FileReadByData(StreamReader reader);
    
}

public class CsvGeneral : ICsvGeneral
{
    public CsvData data = new CsvData();
    
    public void ArrayReadByData(string[] arr)
    {
        CsvRow row = new CsvRow();

        foreach (string str in arr)
        {
            row.AddElement(str);
        }

        data.AddRow(row);
    }
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