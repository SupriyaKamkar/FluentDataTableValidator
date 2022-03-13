namespace FluentDataTableValidator.Models;
public class ErrorModel
{
    public int Row { get; set; }
    public int Column { get; set; }
    public string ErrorMessage {get; set;} = string.Empty;

    public ErrorModel(int row, int column, string errorMessage)
    {
        Row = row;
        Column = column;
        ErrorMessage = errorMessage;
    }
}