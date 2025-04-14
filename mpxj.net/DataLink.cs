using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class DataLink : IJavaObjectProxy<org.mpxj.DataLink>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.DataLink JavaObject { get; }

        internal DataLink(ProxyManager proxyManager, org.mpxj.DataLink javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public string ID => JavaObject.getID();

        public IFieldType SourceField => _proxyManager.ProxyObject(JavaObject.getSourceField());

        public int? SourceUniqueID => JavaObject.getSourceUniqueID().ConvertType();

        public IFieldType TargetField => _proxyManager.ProxyObject(JavaObject.getTargetField());

        public int? TargetUniqueID => JavaObject.getTargetUniqueID().ConvertType();

        public override string ToString() => JavaObject.toString();
    }
}

