using org.mpxj.proxy;

namespace org.mpxj
{
    public class Column : IJavaObjectProxy<net.sf.mpxj.Column>
    {
        public net.sf.mpxj.Column JavaObject { get; }

        internal Column(net.sf.mpxj.Column javaObject)
        {
            JavaObject = javaObject;
        }

        public Column(ProjectFile project)
        {
            JavaObject = new net.sf.mpxj.Column(project.JavaObject);
        }

        public int AlignData
        {
            get => JavaObject.getAlignData();
            set => JavaObject.setAlignData(value);
        }

        public int AlignTitle
        {
            get => JavaObject.getAlignTitle();
            set => JavaObject.setAlignTitle(value);
        }

        public net.sf.mpxj.FieldType FieldType
        {
            get => JavaObject.getFieldType();
            set => JavaObject.setFieldType(value);
        }

        public string Title
        {
            get => JavaObject.getTitle();
            set => JavaObject.setTitle(value);
        }

        public int Width
        {
            get => JavaObject.getWidth();
            set => JavaObject.setWidth(value);
        }

        public override string ToString() => JavaObject.toString();
    }
}
