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

        public ActivityCode Type
        {
            get => _proxyManager.ProxyObject(JavaObject.getType());
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
        }

        public java.lang.Integer SequenceNumber
        {
            get => JavaObject.getSequenceNumber();
        }

        public string Name
        {
            get => JavaObject.getName();
        }

        public string Description
        {
            get => JavaObject.getDescription();
        }

        public java.awt.Color Color
        {
            get => JavaObject.getColor();
        }

        public ActivityCodeValue Parent
        {
            get => _proxyManager.ProxyObject(JavaObject.getParent());
            set => JavaObject.setParent(value.JavaObject);
        }

        public java.lang.Integer ParentUniqueID
        {
            get => JavaObject.getParentUniqueID();
        }

        public IList<ActivityCodeValue> ChildValues
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(JavaObject.getChildValues());
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}
