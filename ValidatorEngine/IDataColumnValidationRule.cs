using System.Data;
using FluentDataTableValidator.Models;
namespace FluentDataTableValidator.ValidatorEngine;

public interface IDataColumnValidationRule
{
    bool IsValid(DataRow row, DataColumn column, int rowNum, int colNum, List<ErrorModel> errorModels);
}
