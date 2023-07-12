using org.mpxj.proxy;

namespace org.mpxj
{
    public class DataLink : IJavaObjectProxy<net.sf.mpxj.DataLink>
    {
        public net.sf.mpxj.DataLink JavaObject { get; }

        internal DataLink(net.sf.mpxj.DataLink javaObject)
        {
            JavaObject = javaObject;
        }

        public DataLink(string id)
        {
            JavaObject = new net.sf.mpxj.DataLink(id);
        }

        public string ID => JavaObject.getID();

        public net.sf.mpxj.FieldType SourceField
        {
            get => JavaObject.getSourceField();
            set => JavaObject.setSourceField(value);
        }

        public java.lang.Integer SourceUniqueID
        {
            get => JavaObject.getSourceUniqueID();
            set => JavaObject.setSourceUniqueID(value);
        }

        public net.sf.mpxj.FieldType TargetField
        {
            get => JavaObject.getTargetField();
            set => JavaObject.setTargetField(value);
        }

        public java.lang.Integer TargetUniqueID
        {
            get => JavaObject.getTargetUniqueID();
            set => JavaObject.setTargetUniqueID(value);
        }

        public override string ToString() => JavaObject.toString();
    }
}

