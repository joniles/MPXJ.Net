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

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
        }

        public net.sf.mpxj.ActivityCodeScope Scope
        {
            get => JavaObject.getScope();
        }

        public java.lang.Integer ScopeProjectUniqueID
        {
            get => JavaObject.getScopeProjectUniqueID();
        }

        public java.lang.Integer ScopeEpsUniqueID
        {
            get => JavaObject.getScopeEpsUniqueID();
        }

        public java.lang.Integer SequenceNumber
        {
            get => JavaObject.getSequenceNumber();
        }

        public string Name
        {
            get => JavaObject.getName();
        }

        public bool Secure
        {
            get => JavaObject.getSecure();
        }

        public java.lang.Integer MaxLength
        {
            get => JavaObject.getMaxLength();
        }

        public ActivityCodeValue AddValue(java.lang.Integer uniqueID, java.lang.Integer sequenceNumber, string name, string description, java.awt.Color color)
        {
            return _proxyManager.ProxyObject(JavaObject.addValue(uniqueID, sequenceNumber, name, description, color));
        }

        public IList<ActivityCodeValue> Values
        {
            get => _proxyManager.ProxyActivityCodeValueList(JavaObject.getValues());
        }

        public IList<ActivityCodeValue> ChildValues
        {
            get => _proxyManager.ProxyActivityCodeValueList(JavaObject.getChildValues());
        }
    }
}

