using System.Data;
namespace FluentDataTableValidator.Models;
public class ColumnValueRules<R,T>
{
    public DataColumn? Column { get; set; }
    public R? ExpectedColumnValue { get; set; }
    public DataColumn? CompareToColumn { get; set; }
    public T? CompareToColumnExpectedValue { get; set; }

    public ColumnValueRules(DataColumn column, R ExpectedColumnValue)
    {
        this.Column = column;
        this.ExpectedColumnValue = ExpectedColumnValue;
    }
}