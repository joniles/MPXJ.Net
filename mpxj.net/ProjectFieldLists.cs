using MPXJ.Net.Proxy;
using System.Collections.Generic;

namespace MPXJ.Net
{
    public static class ProjectFieldLists
    {
        private static IList<ProjectField> ProxyArray(net.sf.mpxj.ProjectField[] array)
        {
            return new ProxyList<net.sf.mpxj.ProjectField, ProjectField>(f => (ProjectField)EnumExtensionMethods.FieldTypeDictionary[f], f => (net.sf.mpxj.ProjectField)f.JavaObject, array);
        }

        public static readonly IList<ProjectField> BaselineDates = ProxyArray(net.sf.mpxj.common.ProjectFieldLists.BASELINE_DATES);
    }
}
