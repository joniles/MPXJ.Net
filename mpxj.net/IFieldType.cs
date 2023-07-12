namespace org.mpxj
{
	public interface IFieldType
	{
        FieldTypeClass FieldTypeClass { get; }

        string Name { get; }

        DataType? DataType { get; }

        IFieldType UnitsType { get; }
    }
}

