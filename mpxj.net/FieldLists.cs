using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public static class FieldLists
    {        
        public static readonly IList<IFieldType> CustomFields = new ProxyList<org.mpxj.FieldType, IFieldType>(f => EnumExtensionMethods.FieldTypeDictionary[f], f=> f.JavaObject, org.mpxj.common.FieldLists.CUSTOM_FIELDS);

        public static readonly ISet<IFieldType> CustomFieldsSet = new ProxySet<org.mpxj.FieldType, IFieldType>(f => EnumExtensionMethods.FieldTypeDictionary[f], f => f.JavaObject, org.mpxj.common.FieldLists.CUSTOM_FIELDS_SET);
    }
}
