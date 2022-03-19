using System.Collections;
namespace FluentDataTableValidator;
public interface IDataColumnValidator
{
    public DataColumnValidator NotNull();
    public DataColumnValidator ValueIsOfType(Type type);

    public DataColumnValidator ValueIsInCollection(ArrayList acceptedValues);
    
}