using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ActivityCodeValue : IJavaObjectProxy<net.sf.mpxj.ActivityCodeValue>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ActivityCodeValue JavaObject { get; }

        internal ActivityCodeValue(ProxyManager proxyManager, net.sf.mpxj.ActivityCodeValue javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public ActivityCode Type => _proxyManager.ProxyObject(JavaObject.getType());

        public java.lang.Integer UniqueID => JavaObject.getUniqueID();

        public java.lang.Integer SequenceNumber => JavaObject.getSequenceNumber();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();

        public java.awt.Color Color => JavaObject.getColor();

        public ActivityCodeValue Parent
        {
            get => _proxyManager.ProxyObject(JavaObject.getParent());
            set => JavaObject.setParent(value.JavaObject);
        }

        public java.lang.Integer ParentUniqueID => JavaObject.getParentUniqueID();

        public IList<ActivityCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}
