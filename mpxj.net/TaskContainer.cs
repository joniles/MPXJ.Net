using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class TaskContainer : ProjectEntityWithIDContainer<net.sf.mpxj.Task, Task>
    {
        public new net.sf.mpxj.TaskContainer JavaObject { get => (net.sf.mpxj.TaskContainer)base.JavaObject; }

        internal TaskContainer(ProxyManager proxyManager, net.sf.mpxj.TaskContainer javaObject) : base(proxyManager, javaObject) { }

        public Task Add()
        {
            return _proxyManager.ProxyObject(JavaObject.add());
        }

        public void UpdateStructure()
        {
            JavaObject.updateStructure();
        }

        public java.util.Set PopulatedFields
        {
            get => JavaObject.getPopulatedFields();
        }

        public IList<CustomField> CustomFields
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.CustomField, CustomField>(JavaObject.getCustomFields());
        }

        public net.sf.mpxj.FieldType GetFieldTypeByAlias(string alias)
        {
            return JavaObject.getFieldTypeByAlias(alias);
        }
    }
}

