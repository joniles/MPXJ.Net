using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class RoleCodeValue : ICodeValue, IJavaObjectProxy<net.sf.mpxj.RoleCodeValue>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.RoleCodeValue JavaObject { get; }

        internal RoleCodeValue(ProxyManager proxyManager, net.sf.mpxj.RoleCodeValue javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public RoleCode ParentCode => _proxyManager.ProxyObject(JavaObject.getParentCode());
        
        public int? ParentCodeUniqueId => JavaObject.getParentCodeUniqueID().ConvertType();
        
        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();
        
        public RoleCodeValue ParentValue => _proxyManager.ProxyObject(JavaObject.getParentValue());
        
        public int? ParentValueUniqueId => JavaObject.getParentValueUniqueID().ConvertType();
        
        public IList<RoleCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.RoleCodeValue, RoleCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.RoleCodeValue.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.RoleCodeValue.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.RoleCodeValue.Builder(file.JavaObject);
            }

            public Builder RoleCode(RoleCode value)
            {
                JavaObject.roleCode(value?.JavaObject);
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

            public Builder ParentValue(RoleCodeValue value)
            {
                JavaObject.parentValue(value?.JavaObject);
                return this;
            }

            public RoleCodeValue Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
