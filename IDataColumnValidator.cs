using System.Data;
using FluentDataTableValidator.ValidatorEngine;
namespace FluentDataTableValidator;
public interface IDataColumnValidator
{
    public DataColumn NotNull();
    
}