namespace org.mpxj
{
	public class ResourceAssignmentContainer : ProjectEntityContainer<net.sf.mpxj.ResourceAssignment, ResourceAssignment>
    {
        public new net.sf.mpxj.ResourceAssignmentContainer JavaObject { get => (net.sf.mpxj.ResourceAssignmentContainer)base.JavaObject; }

        internal ResourceAssignmentContainer(ProjectFile projectFile, net.sf.mpxj.ResourceAssignmentContainer javaObject) : base(projectFile, javaObject) { }

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

