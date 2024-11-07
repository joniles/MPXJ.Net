using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ActivityCode : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.ActivityCode>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ActivityCode JavaObject { get; }

        internal ActivityCode(ProxyManager proxyManager, net.sf.mpxj.ActivityCode javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public ActivityCodeScope? Scope => JavaObject.getScope().ConvertType();

        public int? ScopeProjectUniqueID => JavaObject.getScopeProjectUniqueID().ConvertType();

        public int? ScopeEpsUniqueID => JavaObject.getScopeEpsUniqueID().ConvertType();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public bool Secure => JavaObject.getSecure();

        public int? MaxLength => JavaObject.getMaxLength().ConvertType();

        public IList<ActivityCodeValue> Values => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getValues());

        public IList<ActivityCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public void AddValue(ActivityCodeValue value) => JavaObject.addValue(value.JavaObject);

        public ActivityCodeValue GetValueByUniqueID(int? id) => _proxyManager.ProxyObject(JavaObject.getValueByUniqueID(id.ConvertType()));

        public class Builder : IJavaObjectProxy<net.sf.mpxj.ActivityCode.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.ActivityCode.Builder JavaObject { get; set; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.ActivityCode.Builder(file.JavaObject);
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder Scope(ActivityCodeScope value)
            {
                JavaObject.scope(value.ConvertType());
                return this;
            }

            public Builder ScopeEpsUniqueID(int? value)
            {
                JavaObject.scopeEpsUniqueID(value.ConvertType());
                return this;
            }

            public Builder ScopeProjectUniqueID(int? value)
            {
                JavaObject.scopeProjectUniqueID(value.ConvertType());
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                JavaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public Builder Name(string value)
            {
                JavaObject.name(value);
                return this;
            }

            public Builder Secure(bool value)
            {
                JavaObject.secure(value);
                return this;
            }

            public Builder MaxLength(int? value)
            {
                JavaObject.maxLength(value.ConvertType());
                return this;
            }

            public ActivityCode Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}

