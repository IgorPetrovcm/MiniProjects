namespace CsvReader;

public class CsvRow 
{
    private NullReferenceException nullExc = new NullReferenceException("Строка пуста при создании конструктора");
    private string[] cells;

    private int count;

    public int Count {get => cells.Count();}
    
    public CsvRow(string line)
    {
        if (line == null) throw nullExc;
        if (line.Contains(','))
            cells = line.Split(',');
        else
            cells = line.Split(';');
    }
    public CsvRow(string line, char splitVal)
    {
        if (line == null) throw nullExc;
        cells = line.Split(splitVal);
    }
    public CsvRow()
    {

    }

    public void AddElement(string element)
    {
        Array.Resize(ref cells, cells.Length + 1);

        cells[cells.Length - 1] = element;
    }
    public string[] Cells {get => cells;}
}