using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class TaskContainer : ProjectEntityWithIDContainer<net.sf.mpxj.Task, Task>
    {
        private readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.TaskContainer JavaObject => (net.sf.mpxj.TaskContainer)base.JavaObject;

        internal TaskContainer(ProxyManager proxyManager, net.sf.mpxj.TaskContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public Task Add() => _fromJava(JavaObject.add());

        public ISet<IFieldType> PopulatedFields => _proxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(_proxyManager.ProxyObject, value => (net.sf.mpxj.FieldType)value.GenericJavaObject(), JavaObject.getPopulatedFields());

        public IList<CustomField> CustomFields => _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFields());

        public IFieldType GetFieldTypeByAlias(string alias) => _proxyManager.ProxyObject(JavaObject.getFieldTypeByAlias(alias));
    }
}

