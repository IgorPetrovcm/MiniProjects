namespace TableCreation.Services;
using CsvReader;


public interface ITable
{
    public void AddRow(string[] arr);
}

public class Table : ITable
{
    public CsvData data = new CsvData();
    
    public int Count
    {
        get => data.Count;
    }
    public void AddRow(string[] arr)
    {
        data.AddRow(CsvRow.CreateRowUseArray(arr));
    }
}