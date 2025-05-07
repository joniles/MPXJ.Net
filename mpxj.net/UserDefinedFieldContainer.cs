using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class UserDefinedFieldContainer : ProxyCollection<org.mpxj.UserDefinedField, UserDefinedField>, IJavaObjectProxy<org.mpxj.UserDefinedFieldContainer>
    {
        private readonly ProxyManager _proxyManager;
        public new org.mpxj.UserDefinedFieldContainer JavaObject => (org.mpxj.UserDefinedFieldContainer)base.JavaObject;

        internal UserDefinedFieldContainer(ProxyManager proxyManager, org.mpxj.UserDefinedFieldContainer javaObject) : base(proxyManager.ProxyObject, value => (org.mpxj.UserDefinedField)value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public override void Add(UserDefinedField item)
        {
            base.Add(item);
            _proxyManager.UnProxyObject(item);
        }

        public ICollection<UserDefinedField> TaskFields => _proxyManager.ProxyCollection<org.mpxj.UserDefinedField, UserDefinedField>(_proxyManager.ProxyObject, value => (org.mpxj.UserDefinedField)value.JavaObject, JavaObject.getTaskFields());

        public ICollection<UserDefinedField> ResourceFields => _proxyManager.ProxyCollection<org.mpxj.UserDefinedField, UserDefinedField>(_proxyManager.ProxyObject, value => (org.mpxj.UserDefinedField)value.JavaObject, JavaObject.getResourceFields());

        public ICollection<UserDefinedField> AssignmentFields => _proxyManager.ProxyCollection<org.mpxj.UserDefinedField, UserDefinedField>(_proxyManager.ProxyObject, value => (org.mpxj.UserDefinedField)value.JavaObject, JavaObject.getAssignmentFields());

        public ICollection<UserDefinedField> ProjectFields => _proxyManager.ProxyCollection<org.mpxj.UserDefinedField, UserDefinedField>(_proxyManager.ProxyObject, value => (org.mpxj.UserDefinedField)value.JavaObject, JavaObject.getProjectFields());

        public UserDefinedField GetByUniqueID(int? id) => _proxyManager.ProxyObject(JavaObject.getByUniqueID(id.ConvertType()));
    }
}
