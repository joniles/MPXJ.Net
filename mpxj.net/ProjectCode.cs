using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectCode : ICode, IJavaObjectProxy<org.mpxj.ProjectCode>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.ProjectCode JavaObject { get; }

        internal ProjectCode(ProxyManager proxyManager, org.mpxj.ProjectCode javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();


        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public bool Secure => JavaObject.getSecure();

        public int? MaxLength => JavaObject.getMaxLength().ConvertType();

        public IList<ProjectCodeValue> Values => _proxyManager.ProxyList<org.mpxj.ProjectCodeValue, ProjectCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getValues());

        public IList<ProjectCodeValue> ChildValues => _proxyManager.ProxyList<org.mpxj.ProjectCodeValue, ProjectCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public void AddValue(ProjectCodeValue value) => JavaObject.addValue(value.JavaObject);

        public ProjectCodeValue GetValueByUniqueID(int? id) => _proxyManager.ProxyObject(JavaObject.getValueByUniqueID(id.ConvertType()));

        public class Builder : IJavaObjectProxy<org.mpxj.ProjectCode.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public org.mpxj.ProjectCode.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new org.mpxj.ProjectCode.Builder(file.JavaObject);
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

            public ProjectCode Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}

