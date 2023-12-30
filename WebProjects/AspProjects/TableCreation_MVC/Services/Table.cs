namespace TableCreation_MVC;

using System.Text;
using CsvReader;


public interface ITable
{
    public CsvData Data();
    public void AddRow(string[] arr);

    public string GetInnerHtml();
}

public class Table : ITable
{
    public CsvData data = new CsvData();

    public CsvData Data() => data;
    public int DataCount {get => data.Count;}
    public string[] HeaderCells {get => data.header.Cells; }
    public CsvRow Header {get => data.header;}

    public void AddRow(string[] arr)
    {
        data.AddRow(CsvRow.CreateRowUseArray(arr));
    } 

    public string GetInnerHtml()
    {
        StringBuilder html = new StringBuilder();

        html.Append("<br/>");
        html.Append(@"<table id=""tableGeneral"">");
        html.Append("<tr>");

        for (int i = 0; i < HeaderCells.Length; i++)
        {
            html.Append($"<th>{HeaderCells[i]}</th>");
        }
        html.Append("</tr>");

        foreach (CsvRow row in data.Rows)
        {
            if (row == data.header) continue;

            html.Append("<tr>");

            for (int i = 0; i < row.Cells.Length; i++)
            {
                html.Append($"<td>{row.Cells[i]}</td>");
            }
            html.Append("</tr>");
        }

        html.Append("</table>");

        return html.ToString();
    }
}