namespace CsvReaderApp;


public class CsvRow
{
    public string[] cells;

    public CsvRow(string line)
    {
        if (line.Contains(','))
            cells = line.Split(',');
        else
            cells = line.Split(';');
    }
}

public class CsvData
{
    public List<CsvRow> rows = new List<CsvRow>();

    public CsvRow header;

    public void AddRow(CsvRow row)
    {
        if (header == null)
        {
            header = row;
            rows.Add(row);
            return;
        }
        rows.Add(row);
        return;
    }
    
}