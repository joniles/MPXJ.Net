using org.mpxj.proxy;

namespace org.mpxj
{
	public class Table : IJavaObjectProxy<net.sf.mpxj.Table>
    {
        public net.sf.mpxj.Table JavaObject { get; }

        internal Table(net.sf.mpxj.Table javaObject)
        {
            JavaObject = javaObject;
        }

        public int ID
        {
            get => JavaObject.getID();
            set => JavaObject.setID(value);
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public bool ResourceFlag
        {
            get => JavaObject.getResourceFlag();
            set => JavaObject.setResourceFlag(value);
        }

        public void AddColumn(net.sf.mpxj.Column column)
        {
            JavaObject.addColumn(column);
        }

        public java.util.List Columns
        {
            get => JavaObject.getColumns();
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

