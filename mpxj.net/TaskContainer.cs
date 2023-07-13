using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class TaskContainer : ProjectEntityWithIDContainer<net.sf.mpxj.Task, Task>
    {
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.TaskContainer JavaObject => (net.sf.mpxj.TaskContainer)base.JavaObject;

        internal TaskContainer(ProxyManager proxyManager, net.sf.mpxj.TaskContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public Task Add() => _fromJava(JavaObject.add());

        public void UpdateStructure() => JavaObject.updateStructure();

        // TODO: FieldType implementation
        //public ISet<IFieldType> PopulatedFields => ProxyManager.ProxySet<net.sf.mpxj.FieldType, IFieldType>(JavaObject.getPopulatedFields());

        public IList<CustomField> CustomFields => _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCustomFields());

        public net.sf.mpxj.FieldType GetFieldTypeByAlias(string alias) => JavaObject.getFieldTypeByAlias(alias);
    }
}

