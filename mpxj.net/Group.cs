using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class Group : IJavaObjectProxy<net.sf.mpxj.Group>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Group JavaObject { get; }

        internal Group(ProxyManager proxyManager, net.sf.mpxj.Group javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public Group(java.lang.Integer id, string name, bool showSummaryTasks)
        {
            JavaObject = new net.sf.mpxj.Group(id, name, showSummaryTasks);
        }

        public java.lang.Integer ID
        {
            get => JavaObject.getID();
        }

        public string Name
        {
            get => JavaObject.getName();
        }

        public bool ShowSummaryTasks
        {
            get => JavaObject.getShowSummaryTasks();
        }

        public void AddGroupClause(GroupClause clause)
        {
            JavaObject.addGroupClause(clause.JavaObject);
        }

        public IList<GroupClause> GroupClauses
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.GroupClause, GroupClause>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getGroupClauses());
        }

        public override string ToString() => JavaObject.toString();
    }
}

