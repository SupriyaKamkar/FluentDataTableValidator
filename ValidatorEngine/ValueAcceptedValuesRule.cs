using System.Data;
using FluentDataTableValidator.Models;
namespace FluentDataTableValidator.ValidatorEngine;
public class ValueAcceptedValuesRule : IDataColumnValidationRule
{
    public bool IsValid(DataRow row, DataColumn column, int rowNum, int colNum, List<ErrorModel> errorModels)
    {
        // if(column.GetAcceptedValuesRule()?.Contains(row[column]) == true)
        // {
        //     return true;
        // }
        // else
        // {
        //     var errorModel = new ErrorModel(rowNum, colNum, column.GetmessageOnAcceptedValuesValidationFail());
        //     errorModels.Add(errorModel);
        //     return false;            
        // }
        return false;
    }
}