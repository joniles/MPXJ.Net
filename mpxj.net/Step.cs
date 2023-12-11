using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: implement builder
    public class Step : IJavaObjectProxy<net.sf.mpxj.Step>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Step JavaObject { get; }

        internal Step(ProxyManager proxyManager, net.sf.mpxj.Step javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public Task Task => _proxyManager.ProxyObject(JavaObject.getTask());

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();
        public string Name => JavaObject.getName();
        public double? PercentComplete => JavaObject.getPercentComplete().ConvertType();
        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();
        public double? Weight => JavaObject.getWeight().ConvertType();
        public string Description => JavaObject.getDescription();
        public Notes DescriptionObject => _proxyManager.ProxyObject(JavaObject.getDescriptionObject());
        public bool Complete => JavaObject.getComplete();
    }
}

