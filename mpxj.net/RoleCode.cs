using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class RoleCode : ICode, IJavaObjectProxy<org.mpxj.RoleCode>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.RoleCode JavaObject { get; }

        internal RoleCode(ProxyManager proxyManager, org.mpxj.RoleCode javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();


        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public bool Secure => JavaObject.getSecure();

        public int? MaxLength => JavaObject.getMaxLength().ConvertType();

        public IList<RoleCodeValue> Values => _proxyManager.ProxyList<org.mpxj.RoleCodeValue, RoleCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getValues());

        public IList<RoleCodeValue> ChildValues => _proxyManager.ProxyList<org.mpxj.RoleCodeValue, RoleCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public void AddValue(RoleCodeValue value) => JavaObject.addValue(value.JavaObject);

        public RoleCodeValue GetValueByUniqueID(int? id) => _proxyManager.ProxyObject(JavaObject.getValueByUniqueID(id.ConvertType()));

        public class Builder : IJavaObjectProxy<org.mpxj.RoleCode.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public org.mpxj.RoleCode.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new org.mpxj.RoleCode.Builder(file.JavaObject);
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
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

            public RoleCode Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}

