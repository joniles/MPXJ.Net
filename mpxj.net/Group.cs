using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Group : IJavaObjectProxy<org.mpxj.Group>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.Group JavaObject { get; }

        internal Group(ProxyManager proxyManager, org.mpxj.Group javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int ID => JavaObject.getID().ConvertType().Value;

        public string Name => JavaObject.getName();

        public bool ShowSummaryTasks => JavaObject.getShowSummaryTasks();

        public IList<GroupClause> GroupClauses => _proxyManager.ProxyList<org.mpxj.GroupClause, GroupClause>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getGroupClauses());

        public override string ToString() => JavaObject.toString();
    }
}

