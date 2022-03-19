using System.Data;
using FluentDataTableValidator.ValidatorEngine;
using FluentDataTableValidator.Factories;
using FluentDataTableValidator.Helpers;
using System.Collections;

namespace FluentDataTableValidator;
public sealed class DataColumnValidator : IDataColumnValidator
{
    private DataColumn _dataColumn;
    private List<IDataColumnValidationRule> _columnValidationRules;
    internal DataColumnValidator(DataColumn column)
    {
        _dataColumn = column;
        _columnValidationRules = new List<IDataColumnValidationRule>();
    }

    public DataColumnValidator NotNull()
    {
        _columnValidationRules.Add(new ValueNotNullValidationRule());
        return this;
    }

    public DataColumnValidator ValueIsOfType(Type type)
    {
        _columnValidationRules.Add(new ValueDataTypeValidationRule(type));
        return this;
    }

    public DataColumnValidator ValueIsInCollection(ArrayList acceptedValues)
    {
        _columnValidationRules.Add(new ValueAcceptedValuesRule(acceptedValues));
        return this;
    }
    internal List<IDataColumnValidationRule> GetColumnValidationRules()
    {
        return _columnValidationRules;
    }

}