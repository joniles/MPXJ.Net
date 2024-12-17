using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceCode : ICode, IJavaObjectProxy<net.sf.mpxj.ResourceCode>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ResourceCode JavaObject { get; }

        internal ResourceCode(ProxyManager proxyManager, net.sf.mpxj.ResourceCode javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();


        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public bool Secure => JavaObject.getSecure();

        public int? MaxLength => JavaObject.getMaxLength().ConvertType();

        public IList<ResourceCodeValue> Values => _proxyManager.ProxyList<net.sf.mpxj.ResourceCodeValue, ResourceCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getValues());

        public IList<ResourceCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ResourceCodeValue, ResourceCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public void AddValue(ResourceCodeValue value) => JavaObject.addValue(value.JavaObject);

        public ResourceCodeValue GetValueByUniqueID(int? id) => _proxyManager.ProxyObject(JavaObject.getValueByUniqueID(id.ConvertType()));

        public class Builder : IJavaObjectProxy<net.sf.mpxj.ResourceCode.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.ResourceCode.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.ResourceCode.Builder(file.JavaObject);
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

            public ResourceCode Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}

