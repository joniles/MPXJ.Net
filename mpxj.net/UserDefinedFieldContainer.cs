using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class UserDefinedFieldContainer : DeepProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>, IJavaObjectProxy<net.sf.mpxj.UserDefinedFieldContainer>
    {
        public new net.sf.mpxj.UserDefinedFieldContainer JavaObject { get => (net.sf.mpxj.UserDefinedFieldContainer)base.JavaObject; }

        internal UserDefinedFieldContainer(ProxyManager proxyManager, net.sf.mpxj.UserDefinedFieldContainer javaObject) : base(proxyManager, javaObject) { }

        public ICollection<UserDefinedField> TaskFields
        {
            get => _proxyManager.ProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>(JavaObject.getTaskFields());
        }

        public ICollection<UserDefinedField> ResourceFields
        {
            get => _proxyManager.ProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>(JavaObject.getResourceFields());
        }

        public ICollection<UserDefinedField> AssignmentFields
        {
            get => _proxyManager.ProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>(JavaObject.getAssignmentFields());
        }

        public ICollection<UserDefinedField> ProjectFields
        {
            get => _proxyManager.ProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>(JavaObject.getProjectFields());
        }
    }
}
