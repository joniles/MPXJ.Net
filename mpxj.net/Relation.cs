using org.mpxj.proxy;

namespace org.mpxj
{
    public class Relation : IJavaObjectProxy<net.sf.mpxj.Relation>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Relation JavaObject { get; }

        internal Relation(ProxyManager proxyManager, net.sf.mpxj.Relation javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public RelationType? Type => JavaObject.getType().ConvertType();

        public Duration Lag => _proxyManager.ProxyObject(JavaObject.getLag());

        public Task SourceTask => _proxyManager.ProxyObject(JavaObject.getSourceTask());

        public Task TargetTask => _proxyManager.ProxyObject(JavaObject.getTargetTask());

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public override string ToString() => JavaObject.toString();
    }
}

