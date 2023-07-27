using org.mpxj.proxy;

namespace org.mpxj
{
    public class DataLink : IJavaObjectProxy<net.sf.mpxj.DataLink>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.DataLink JavaObject { get; }

        internal DataLink(ProxyManager proxyManager, net.sf.mpxj.DataLink javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public DataLink(string id)
        {
            JavaObject = new net.sf.mpxj.DataLink(id);
        }

        public string ID => JavaObject.getID();

        public IFieldType SourceField
        {
            get => _proxyManager.ProxyObject(JavaObject.getSourceField());
            set => JavaObject.setSourceField(value.JavaObject);
        }

        public int? SourceUniqueID
        {
            get => JavaObject.getSourceUniqueID().ConvertType();
            set => JavaObject.setSourceUniqueID(value.ConvertType());
        }

        public IFieldType TargetField
        {
            get => _proxyManager.ProxyObject(JavaObject.getTargetField());
            set => JavaObject.setTargetField(value.JavaObject);
        }

        public int? TargetUniqueID
        {
            get => JavaObject.getTargetUniqueID().ConvertType();
            set => JavaObject.setTargetUniqueID(value.ConvertType());
        }

        public override string ToString() => JavaObject.toString();
    }
}

