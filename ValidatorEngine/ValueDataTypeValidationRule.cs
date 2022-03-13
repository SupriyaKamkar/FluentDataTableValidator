using System.Data;
using FluentDataTableValidator.Models;
namespace FluentDataTableValidator.ValidatorEngine;
public class ValueDataTypeValidationRule : IDataColumnValidationRule
{
    public bool IsValid(DataRow row, DataColumn column, int rowNum, int colNum, List<ErrorModel> errorModels)
    {
        // if(column.GetDataTypeRule() == null) 
        // {
        //     return true;
        // }
        // if(column.DataType == column.GetDataTypeRule())
        // {
        //     return true;
        // }
        // else
        // {
        //     var errorModel = new ErrorModel(rowNum, colNum, column.GetmessageOnDataTypeValidationFail());
        //     errorModels.Add(errorModel);
        //     return false;            
        // }
        return false;
    }
}
