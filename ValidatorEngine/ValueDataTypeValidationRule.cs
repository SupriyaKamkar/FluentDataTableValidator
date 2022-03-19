using System.Data;
using FluentDataTableValidator.Models;
namespace FluentDataTableValidator.ValidatorEngine;
public class ValueDataTypeValidationRule : IDataColumnValidationRule
{
    private Type _expectedDataType;
    public ValueDataTypeValidationRule(Type dataType)
    {
        _expectedDataType = dataType;
    }
    public bool IsValid(DataRow row,
    DataColumn column, int rowNum, int colNum, List<ErrorModel> errorModels)
    {
        if (column.DataType == _expectedDataType)
        {
            return true;
        }
        else
        {
            var errorModel = new ErrorModel(rowNum, colNum, "Data type check failed");
            errorModels.Add(errorModel);
            return false;
        }
    }
}
