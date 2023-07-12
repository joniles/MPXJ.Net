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

        public net.sf.mpxj.RelationType Type
        {
            get => JavaObject.getType();
        }

        public net.sf.mpxj.Duration Lag
        {
            get => JavaObject.getLag();
        }

        public Task SourceTask
        {
            get => _proxyManager.ProxyObject(JavaObject.getSourceTask());
        }

        public Task TargetTask
        {
            get => _proxyManager.ProxyObject(JavaObject.getTargetTask());
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public override string ToString() => JavaObject.toString();
    }
}

