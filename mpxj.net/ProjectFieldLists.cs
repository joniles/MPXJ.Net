using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public static class ProjectFieldLists
    {
        private static IList<ProjectField> ProxyArray(org.mpxj.ProjectField[] array)
        {
            return new ProxyList<org.mpxj.ProjectField, ProjectField>(f => (ProjectField)EnumExtensionMethods.FieldTypeDictionary[f], f => (org.mpxj.ProjectField)f.JavaObject, array);
        }

        public static readonly IList<ProjectField> BaselineDates = ProxyArray(org.mpxj.common.ProjectFieldLists.BASELINE_DATES);
    }
}
