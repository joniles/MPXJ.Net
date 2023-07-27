using System.Drawing;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class GroupClause : IJavaObjectProxy<net.sf.mpxj.GroupClause>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.GroupClause JavaObject { get; }

        internal GroupClause(ProxyManager proxyManager, net.sf.mpxj.GroupClause javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public GroupClause()
        {
            JavaObject = new net.sf.mpxj.GroupClause();
        }

        public bool Ascending
        {
            get => JavaObject.getAscending();
            set => JavaObject.setAscending(value);
        }

        public Color? CellBackgroundColor
        {
            get => JavaObject.getCellBackgroundColor().ConvertType();
            set => JavaObject.setCellBackgroundColor(value.ConvertType());
        }

        public IFieldType Field
        {
            get => _proxyManager.ProxyObject(JavaObject.getField());
            set => JavaObject.setField(value.JavaObject);
        }

        public FontStyle Font
        {
            get => _proxyManager.ProxyObject(JavaObject.getFont());
            set => JavaObject.setFont(value.JavaObject);
        }

        public object GroupInterval
        {
            get => JavaObject.getGroupInterval();
            set => JavaObject.setGroupInterval(value);
        }

        public int GroupOn
        {
            get => JavaObject.getGroupOn();
            set => JavaObject.setGroupOn(value);
        }

        public BackgroundPattern? Pattern
        {
            get => JavaObject.getPattern().ConvertType();
            set => JavaObject.setPattern(value.ConvertType());
        }

        public object StartAt
        {
            get => JavaObject.getStartAt();
            set => JavaObject.setStartAt(value);
        }

        public override string ToString() => JavaObject.toString();
    }
}

