namespace org.mpxj
{
	public interface IFieldType
	{
        FieldTypeClass FieldTypeClass { get; }

        string Name { get; }

        net.sf.mpxj.DataType DataType { get; }

        IFieldType UnitsType { get; }
    }
}

