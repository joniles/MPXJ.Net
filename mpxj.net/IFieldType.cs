namespace org.mpxj
{
	public interface IFieldType
	{
        FieldTypeClass FieldTypeClass { get; }

        // Note: renamed to avoid clash with, for example, Task.Name
        string FieldName { get; }

        DataType? DataType { get; }

        // TODO: do we need this outside of Java?
        // IFieldType UnitsType { get; }
    }
}

