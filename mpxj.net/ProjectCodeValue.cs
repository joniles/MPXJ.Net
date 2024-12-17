using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectCodeValue : ICodeValue, IJavaObjectProxy<net.sf.mpxj.ProjectCodeValue>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ProjectCodeValue JavaObject { get; }

        internal ProjectCodeValue(ProxyManager proxyManager, net.sf.mpxj.ProjectCodeValue javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public ProjectCode ParentCode => _proxyManager.ProxyObject(JavaObject.getParentCode());
        
        public int? ParentCodeUniqueId => JavaObject.getParentCodeUniqueID().ConvertType();
        
        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();
        
        public ProjectCodeValue ParentValue => _proxyManager.ProxyObject(JavaObject.getParentValue());
        
        public int? ParentValueUniqueId => JavaObject.getParentValueUniqueID().ConvertType();
        
        public IList<ProjectCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ProjectCodeValue, ProjectCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.ProjectCodeValue.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.ProjectCodeValue.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.ProjectCodeValue.Builder(file.JavaObject);
            }

            public Builder ProjectCode(ProjectCode value)
            {
                JavaObject.projectCode(value?.JavaObject);
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

            public Builder ParentValue(ProjectCodeValue value)
            {
                JavaObject.parentValue(value?.JavaObject);
                return this;
            }

            public ProjectCodeValue Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
