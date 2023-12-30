namespace TableCreation_MVC;

using System.Text;
using CsvReader;


public interface ITable
{
    public void AddRow(string[] arr);

    public string GetInnerHtml();
}

public class Table : ITable
{
    public CsvData data = new CsvData();

    public string[] HeaderCells {get => data.header.Cells;}

    public void AddRow(string[] arr)
    {
        data.AddRow(CsvRow.CreateRowUseArray(arr));
    } 

    public string GetInnerHtml()
    {
        StringBuilder html = new StringBuilder();

        html.Append("<br/>");
        html.Append("<table>");
        html.Append("<tr>");

        for (int i = 0; i < HeaderCells.Length; i++)
        {
            html.Append($"<th>{HeaderCells[i]}</th>");
        }
        html.Append("</tr>");

        foreach (CsvRow row in data.Rows)
        {
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