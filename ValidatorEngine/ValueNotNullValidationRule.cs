
using System.Data;
using FluentDataTableValidator.Models;
namespace FluentDataTableValidator.ValidatorEngine;
public class ValueNotNullValidationRule : IDataColumnValidationRule
{
    public bool IsValid(DataRow row, DataColumn column, int rowNum, int colNum, List<ErrorModel> errorModels)
    {
        // if(!column.GetNotNullRule()) 
        // {
        //     return true;
        // }
        if(row[column] != null)
        {
            return true;
        }
        else
        {
            var errorModel = new ErrorModel(rowNum, colNum, "");
            errorModels.Add(errorModel);
            return false;            
        }
    }
}