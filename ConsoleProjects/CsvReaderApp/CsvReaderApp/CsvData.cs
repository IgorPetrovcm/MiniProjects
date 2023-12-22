namespace CsvReaderApp;


public class CsvRow
{
    private string[] cells;

    public CsvRow(string line)
    {
        if (line == null) throw new NullReferenceException("Строка пуста при создании конструктора");
        if (line.Contains(','))
            cells = line.Split(',');
        else
            cells = line.Split(';');
    }
    public CsvRow(string line, char splitVal)
    {
        if (line == null) throw new NullReferenceException("Строка пуста при создании конструктора");
        cells = line.Split(splitVal);
    }
    public CsvRow()
    {

    }

    public string[] Cells {get => cells;}
    
}

public class CsvData
{
    private List<CsvRow> rows = new List<CsvRow>();

    public CsvRow header;

    public void AddRow(CsvRow row)
    {
        if (row.Cells == null || row == null) return;
        if (header == null)
        {
            header = row;
            rows.Add(row);
            return;
        }
        rows.Add(row);

        return;
    }
    
    public List<CsvRow> Rows {get => rows;}

}