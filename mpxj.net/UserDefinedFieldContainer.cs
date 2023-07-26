using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class UserDefinedFieldContainer : ProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>, IJavaObjectProxy<net.sf.mpxj.UserDefinedFieldContainer>
    {
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.UserDefinedFieldContainer JavaObject => (net.sf.mpxj.UserDefinedFieldContainer)base.JavaObject;

        internal UserDefinedFieldContainer(ProxyManager proxyManager, net.sf.mpxj.UserDefinedFieldContainer javaObject) : base(proxyManager.ProxyObject, (value) => (net.sf.mpxj.UserDefinedField)value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public ICollection<UserDefinedField> TaskFields => _proxyManager.ProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>(_proxyManager.ProxyObject, value => (net.sf.mpxj.UserDefinedField)value.JavaObject, JavaObject.getTaskFields());

        public ICollection<UserDefinedField> ResourceFields => _proxyManager.ProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>(_proxyManager.ProxyObject, value => (net.sf.mpxj.UserDefinedField)value.JavaObject, JavaObject.getResourceFields());

        public ICollection<UserDefinedField> AssignmentFields => _proxyManager.ProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>(_proxyManager.ProxyObject, value => (net.sf.mpxj.UserDefinedField)value.JavaObject, JavaObject.getAssignmentFields());

        public ICollection<UserDefinedField> ProjectFields => _proxyManager.ProxyCollection<net.sf.mpxj.UserDefinedField, UserDefinedField>(_proxyManager.ProxyObject, value => (net.sf.mpxj.UserDefinedField)value.JavaObject, JavaObject.getProjectFields());
    }
}
