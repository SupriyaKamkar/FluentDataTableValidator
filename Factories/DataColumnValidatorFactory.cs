using System.Data;

namespace FluentDataTableValidator.Factories;
public static class DataColumnValidatorFactory
{
    public static DataColumnValidator GetDataColumnValidator(DataColumn dataColumn)
    {
        return new DataColumnValidator(dataColumn);
    }
}