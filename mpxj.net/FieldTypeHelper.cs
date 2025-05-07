namespace MPXJ.Net
{
    public static class FieldTypeHelper
   {
        public static int GetFieldID(IFieldType type) => org.mpxj.common.FieldTypeHelper.getFieldID(type.JavaObject);
    }
}
