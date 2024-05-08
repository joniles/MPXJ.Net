using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
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

        public class Builder
        {
            private readonly ProxyManager _proxyManager;
            private readonly net.sf.mpxj.ActivityCode.Builder _javaObject;

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                _javaObject = new net.sf.mpxj.ActivityCode.Builder(file.JavaObject);
            }

            public Builder UniqueID(int? value)
            {
                _javaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder Scope(ActivityCodeScope value)
            {
                _javaObject.scope(value.ConvertType());
                return this;
            }

            public Builder ScopeEpsUniqueID(int? value)
            {
                _javaObject.scopeEpsUniqueID(value.ConvertType());
                return this;
            }

            public Builder ScopeProjectUniqueID(int? value)
            {
                _javaObject.scopeProjectUniqueID(value.ConvertType());
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                _javaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public Builder Name(string value)
            {
                _javaObject.name(value);
                return this;
            }

            public Builder Secure(bool value)
            {
                _javaObject.secure(value);
                return this;
            }

            public Builder MaxLength(int? value)
            {
                _javaObject.maxLength(value.ConvertType());
                return this;
            }

            public ActivityCode Build() => _proxyManager.ProxyObject(_javaObject.build());
        }
    }
}

