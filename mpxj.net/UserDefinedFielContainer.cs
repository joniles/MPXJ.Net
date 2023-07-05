namespace org.mpxj
{
    public class UserDefinedFieldContainer : ShallowProxyCollection<net.sf.mpxj.UserDefinedField>, IJavaObjectProxy<net.sf.mpxj.UserDefinedFieldContainer>
    {
        public new net.sf.mpxj.UserDefinedFieldContainer JavaObject { get => (net.sf.mpxj.UserDefinedFieldContainer)base.JavaObject; }

        internal UserDefinedFieldContainer(net.sf.mpxj.UserDefinedFieldContainer javaObject) : base(javaObject) { }

        public java.util.Collection TaskFields
        {
            get => JavaObject.getTaskFields();
        }

        public java.util.Collection ResourceFields
        {
            get => JavaObject.getResourceFields();
        }

        public java.util.Collection AssignmentFields
        {
            get => JavaObject.getAssignmentFields();
        }

        public java.util.Collection ProjectFields
        {
            get => JavaObject.getProjectFields();
        }
    }
}
