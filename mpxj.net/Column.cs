using org.mpxj.proxy;

namespace org.mpxj
{
    public class Column : IJavaObjectProxy<net.sf.mpxj.Column>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Column JavaObject { get; }

        internal Column(ProxyManager proxyManager, net.sf.mpxj.Column javaObject)
        {
            _proxyManager = proxyManager;
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

        public IFieldType FieldType
        {
            get => _proxyManager.ProxyObject(JavaObject.getFieldType());
            set => JavaObject.setFieldType(value.JavaObject);
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
