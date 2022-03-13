using System.Data;
using FluentDataTableValidator.ValidatorEngine;
using FluentDataTableValidator.Factories;
using FluentDataTableValidator.Helpers;

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

    public DataColumn NotNull()
    {
        var rule = DataColumnValdationRuleFactory.GetDataColumnValidationRule(ColumnValidationRules.NotNullRule);
        if (rule is not null)
        {
            _columnValidationRules.Add(rule);
        }
        return _dataColumn;
    }

    internal List<IDataColumnValidationRule> GetColumnValidationRules()
    {
        return _columnValidationRules;
    }

}