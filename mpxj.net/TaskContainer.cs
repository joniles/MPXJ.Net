using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TaskContainer : ProjectEntityWithIDContainer<org.mpxj.Task, Task>
    {
        private readonly ProxyManager _proxyManager = new ProxyManager();
        
        public new org.mpxj.TaskContainer JavaObject => (org.mpxj.TaskContainer)base.JavaObject;

        internal TaskContainer(ProxyManager proxyManager, org.mpxj.TaskContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public Task Add() => _fromJava(JavaObject.add());

        public ISet<IFieldType> PopulatedFields => _proxyManager.ProxySet<org.mpxj.FieldType, IFieldType>(_proxyManager.ProxyObject, value => (org.mpxj.FieldType)value.GenericJavaObject(), JavaObject.getPopulatedFields());

        public IList<CustomField> CustomFields => _proxyManager.ProxyList<org.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFields());

        public IFieldType GetFieldTypeByAlias(string alias) => _proxyManager.ProxyObject(JavaObject.getFieldTypeByAlias(alias));
    }
}

