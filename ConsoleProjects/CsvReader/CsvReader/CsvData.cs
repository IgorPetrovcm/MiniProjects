namespace CsvReader;

public class CsvData
{
    private List<CsvRow> rows = new List<CsvRow>();

    public CsvRow header;

    public int Count {get => rows.Count;}

    public void AddRow(CsvRow row)
    {
        if (row.Cells == null || row == null) return;
        if (header == null)
        {
            header = row;

            return;
        }
        rows.Add(row);

        return;
    }

    public List<CsvRow> Rows {get => rows;}
}