namespace org.mpxj
{
    public class ResourceContainer : ProjectEntityWithIDContainer<Resource>
	{
        public new net.sf.mpxj.ResourceContainer JavaObject { get => (net.sf.mpxj.ResourceContainer)base.JavaObject; }

        internal ResourceContainer(ProjectFile projectFile, net.sf.mpxj.ResourceContainer javaObject) : base(projectFile, javaObject) { }

        public Resource Add()
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

        public net.sf.mpxj.FieldType GetFieldTypeByAlias(string alias)
        {
            return JavaObject.getFieldTypeByAlias(alias);
        }
    }
}
