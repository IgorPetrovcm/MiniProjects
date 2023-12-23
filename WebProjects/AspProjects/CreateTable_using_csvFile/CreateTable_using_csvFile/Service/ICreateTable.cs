namespace CreateTable_using_csvFile.Service;

using CsvReader;


public interface ICreateTable
{
    public CsvGeneral GetCsvTable(IFormFile file);
}

public class CreateTable : ICreateTable
{
    public CsvGeneral GetCsvTable(IFormFile file)
    {
        if (!new[] {".csv"}.Any(c => file.FileName.Contains(c))) return null;

        Stream stream = file.OpenReadStream();
        
        CsvGeneral csv = new CsvGeneral();
        csv.FileReadByData(stream);

        stream.Dispose();

        return csv;
    }
}