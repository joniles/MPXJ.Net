using net.sf.mpxj;

namespace org.mpxj
{
    public class TaskContainer : ProjectEntityWithIDContainer<net.sf.mpxj.Task, Task>
    {
        public new net.sf.mpxj.TaskContainer JavaObject { get => (net.sf.mpxj.TaskContainer)base.JavaObject; }

        internal TaskContainer(ProjectFile projectFile, net.sf.mpxj.TaskContainer javaObject) : base(projectFile, javaObject) { }

        public Task Add()
        {
            return _projectFile.ProxyObject(JavaObject.add());
        }

        public void UpdateStructure()
        {
            JavaObject.updateStructure();
        }

        public java.util.Set PopulatedFields
        {
            get => JavaObject.getPopulatedFields();
        }

        public java.util.List CustomFields
        {
            get => JavaObject.getCustomFields();
        }

        public FieldType GetFieldTypeByAlias(string alias)
        {
            return JavaObject.getFieldTypeByAlias(alias);
        }
    }
}

