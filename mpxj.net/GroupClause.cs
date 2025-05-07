using System.Drawing;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class GroupClause : IJavaObjectProxy<org.mpxj.GroupClause>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.GroupClause JavaObject { get; }

        internal GroupClause(ProxyManager proxyManager, org.mpxj.GroupClause javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public bool Ascending => JavaObject.getAscending();

        public Color? CellBackgroundColor => JavaObject.getCellBackgroundColor().ConvertType();

        public IFieldType Field => _proxyManager.ProxyObject(JavaObject.getField());

        public FontStyle Font => _proxyManager.ProxyObject(JavaObject.getFont());

        public object GroupInterval => _proxyManager.GenericProxyObject(JavaObject.getGroupInterval());

        public int GroupOn => JavaObject.getGroupOn();

        public BackgroundPattern? Pattern => JavaObject.getPattern().ConvertType();

        public object StartAt => _proxyManager.GenericProxyObject(JavaObject.getStartAt());

        public override string ToString() => JavaObject.toString();
    }
}

