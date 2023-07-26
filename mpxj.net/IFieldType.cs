namespace org.mpxj
{
	public interface IFieldType
	{
        net.sf.mpxj.FieldType JavaObject { get; }

        FieldTypeClass FieldTypeClass { get; }

        // Note: renamed to avoid clash with, for example, Task.Name
        string FieldName { get; }

        DataType? DataType { get; }

        // TODO: do we need this outside of Java?
        // IFieldType UnitsType { get; }
    }
}

