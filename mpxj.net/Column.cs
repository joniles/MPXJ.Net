using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Column : IJavaObjectProxy<net.sf.mpxj.Column>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Column JavaObject { get; }

        internal Column(ProxyManager proxyManager, net.sf.mpxj.Column javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int AlignData => JavaObject.getAlignData();

        public int AlignTitle => JavaObject.getAlignTitle();

        public IFieldType FieldType => _proxyManager.ProxyObject(JavaObject.getFieldType());

        public string Title => JavaObject.getTitle();

        public int Width => JavaObject.getWidth();

        public override string ToString() => JavaObject.toString();
    }
}
