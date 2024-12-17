using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceCodeValue : ICodeValue, IJavaObjectProxy<net.sf.mpxj.ResourceCodeValue>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ResourceCodeValue JavaObject { get; }

        internal ResourceCodeValue(ProxyManager proxyManager, net.sf.mpxj.ResourceCodeValue javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public ResourceCode ParentCode => _proxyManager.ProxyObject(JavaObject.getParentCode());
        
        public int? ParentCodeUniqueId => JavaObject.getParentCodeUniqueID().ConvertType();
        
        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();
        
        public ResourceCodeValue ParentValue => _proxyManager.ProxyObject(JavaObject.getParentValue());
        
        public int? ParentValueUniqueId => JavaObject.getParentValueUniqueID().ConvertType();
        
        public IList<ResourceCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ResourceCodeValue, ResourceCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.ResourceCodeValue.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.ResourceCodeValue.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.ResourceCodeValue.Builder(file.JavaObject);
            }

            public Builder ResourceCode(ResourceCode value)
            {
                JavaObject.resourceCode(value?.JavaObject);
                return this;
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

            public Builder Description(string value)
            {
                JavaObject.description(value);
                return this;
            }

            public Builder ParentValue(ResourceCodeValue value)
            {
                JavaObject.parentValue(value?.JavaObject);
                return this;
            }

            public ResourceCodeValue Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
