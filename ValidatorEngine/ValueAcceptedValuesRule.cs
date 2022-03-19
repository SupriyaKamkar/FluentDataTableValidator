using System.Collections;
using System.Data;
using FluentDataTableValidator.Models;
namespace FluentDataTableValidator.ValidatorEngine;
public class ValueAcceptedValuesRule : IDataColumnValidationRule
{
    private ArrayList _acceptedValues;
    public ValueAcceptedValuesRule(ArrayList acceptedValues)
    {
        _acceptedValues = acceptedValues;
    }
    public bool IsValid(DataRow row, DataColumn column, int rowNum, int colNum, List<ErrorModel> errorModels)
    {
        if(_acceptedValues.Contains(row[column]))
        {
            return true;
        }
        else
        {
            var errorModel = new ErrorModel(rowNum, colNum, "Column value is not accepted");
            errorModels.Add(errorModel);
            return false;            
        }
        
    }
}