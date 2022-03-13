using System.Data;
using FluentDataTableValidator.Factories;
using FluentDataTableValidator.Models;
namespace FluentDataTableValidator;
public sealed class DataTableValidator
{
    private Dictionary<int, DataColumnValidator> _columnValidatorDict;
    private DataTable _dataTable;

    public DataTableValidator(DataTable dataTable)
    {
        _dataTable = dataTable;
        _columnValidatorDict = new Dictionary<int, DataColumnValidator>();
    }
    public DataColumnValidator RuleForColumn(int columnIndex)
    {
        if(_columnValidatorDict.ContainsKey(columnIndex))
        {
            return _columnValidatorDict[columnIndex];
        }
        var columnValidator = DataColumnValidatorFactory.GetDataColumnValidator(_dataTable.Columns[columnIndex]);
        _columnValidatorDict.Add(columnIndex, columnValidator);
        return columnValidator;
    }

    public List<ErrorModel> Validate()
    {
        var errorModels = new List<ErrorModel>();
        int rowIndex = 0, colIndex = 0;
        foreach (DataRow row in _dataTable.Rows)
        {
            foreach (DataColumn col in _dataTable.Columns)
            {
                var rules = _columnValidatorDict[colIndex].GetColumnValidationRules();

                rules.ForEach(rule => rule.IsValid(row, col, rowIndex, colIndex, errorModels));

                colIndex++;
            }
            rowIndex++;
        }
        return errorModels;
    }

}
