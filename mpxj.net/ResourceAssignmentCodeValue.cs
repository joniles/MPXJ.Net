using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ResourceAssignmentCodeValue : ICodeValue, IJavaObjectProxy<net.sf.mpxj.ResourceAssignmentCodeValue>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ResourceAssignmentCodeValue JavaObject { get; }

        internal ResourceAssignmentCodeValue(ProxyManager proxyManager, net.sf.mpxj.ResourceAssignmentCodeValue javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public ResourceAssignmentCode ParentCode => _proxyManager.ProxyObject(JavaObject.getParentCode());
        
        public int? ParentCodeUniqueId => JavaObject.getParentCodeUniqueID().ConvertType();
        
        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();
        
        public ResourceAssignmentCodeValue ParentValue => _proxyManager.ProxyObject(JavaObject.getParentValue());
        
        public int? ParentValueUniqueId => JavaObject.getParentValueUniqueID().ConvertType();
        
        public IList<ResourceAssignmentCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ResourceAssignmentCodeValue, ResourceAssignmentCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.ResourceAssignmentCodeValue.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.ResourceAssignmentCodeValue.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.ResourceAssignmentCodeValue.Builder(file.JavaObject);
            }

            public Builder ResourceAssignmentCode(ResourceAssignmentCode value)
            {
                JavaObject.resourceAssignmentCode(value?.JavaObject);
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

            public Builder ParentValue(ResourceAssignmentCodeValue value)
            {
                JavaObject.parentValue(value?.JavaObject);
                return this;
            }

            public ResourceAssignmentCodeValue Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
