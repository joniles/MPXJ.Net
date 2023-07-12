using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ActivityCode : IJavaObjectProxy<net.sf.mpxj.ActivityCode>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ActivityCode JavaObject { get; }

        internal ActivityCode(ProxyManager proxyManager, net.sf.mpxj.ActivityCode javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public java.lang.Integer UniqueID => JavaObject.getUniqueID();

        public ActivityCodeScope? Scope => JavaObject.getScope().ConvertType();

        public java.lang.Integer ScopeProjectUniqueID => JavaObject.getScopeProjectUniqueID();

        public java.lang.Integer ScopeEpsUniqueID => JavaObject.getScopeEpsUniqueID();

        public java.lang.Integer SequenceNumber => JavaObject.getSequenceNumber();

        public string Name => JavaObject.getName();

        public bool Secure => JavaObject.getSecure();

        public java.lang.Integer MaxLength => JavaObject.getMaxLength();

        public ActivityCodeValue AddValue(java.lang.Integer uniqueID, java.lang.Integer sequenceNumber, string name, string description, java.awt.Color color)
        {
            return _proxyManager.ProxyObject(JavaObject.addValue(uniqueID, sequenceNumber, name, description, color));
        }

        public IList<ActivityCodeValue> Values => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getValues());

        public IList<ActivityCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());
    }
}

