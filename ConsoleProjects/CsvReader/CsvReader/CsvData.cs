namespace CsvReader;

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