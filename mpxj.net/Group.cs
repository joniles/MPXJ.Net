using org.mpxj.proxy;

namespace org.mpxj
{
    public class Group : IJavaObjectProxy<net.sf.mpxj.Group>
    {
        public net.sf.mpxj.Group JavaObject { get; }

        internal Group(net.sf.mpxj.Group javaObject)
        {
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

        public void AddGroupClause(net.sf.mpxj.GroupClause clause)
        {
            JavaObject.addGroupClause(clause);
        }

        public java.util.List GroupClauses
        {
            get => JavaObject.getGroupClauses();
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

