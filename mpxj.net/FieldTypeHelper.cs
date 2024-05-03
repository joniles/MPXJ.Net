namespace MPXJ.Net
{
    public static class FieldTypeHelper
   {
        public static int GetFieldID(IFieldType type) => net.sf.mpxj.common.FieldTypeHelper.getFieldID(type.JavaObject);
    }
}
