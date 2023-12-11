using System.Collections.Generic;
using System.Drawing;
using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: implement builder
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

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();

        public Color? Color => JavaObject.getColor().ConvertType();

        public ActivityCodeValue Parent => _proxyManager.ProxyObject(JavaObject.getParent());

        public int? ParentUniqueID => JavaObject.getParentUniqueID().ConvertType();

        public IList<ActivityCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public override string ToString() => JavaObject.toString();
    }
}
