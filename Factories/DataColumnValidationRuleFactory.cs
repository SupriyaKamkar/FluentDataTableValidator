using FluentDataTableValidator.Helpers;
using FluentDataTableValidator.ValidatorEngine;
namespace FluentDataTableValidator.Factories;

public static class DataColumnValdationRuleFactory
{
    public static IDataColumnValidationRule? GetDataColumnValidationRule(string rule)
    {
        if(rule == ColumnValidationRules.NotNullRule)
        {
            return new ValueNotNullValidationRule();
        }
        else return null;
    }
}