namespace MPXJ.Net
{
	public interface IFieldType
	{
        org.mpxj.FieldType JavaObject { get; }

        FieldTypeClass FieldTypeClass { get; }

        // Note: renamed to avoid clash with, for example, Task.Name
        string FieldName { get; }

        string ObjectName { get; }

        DataType? DataType { get; }
    }
}

