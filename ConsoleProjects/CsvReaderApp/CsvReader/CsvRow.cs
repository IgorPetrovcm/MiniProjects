namespace CsvReader;

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