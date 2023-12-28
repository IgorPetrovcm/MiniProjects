using System.Data;

namespace CsvReader;

public interface ICsvGeneral
{
    public CsvRow ArrayReadByData(string[] arr);
    public CsvData FileReadByData(Stream stream);
    public void FileReadByData(StreamReader reader);
    
}

/*public class CsvGeneral : ICsvGeneral
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
}*/

public class Csv : ICsvGeneral
{
    public CsvRow ArrayReadByData(string[] arr)
    {
        CsvRow row = new CsvRow();

        foreach (string str in arr)
        {
            row.AddElement(str);
        }

        return row;
    }

    public CsvData FileReadByData(Stream stream)
    {
        CsvData data = new CsvData();

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

        return data;
    }

    public void FileReadByData(StreamReader reader)
    {
        throw new NotImplementedException();
    }
}