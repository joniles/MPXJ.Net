using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    // TODO: implement builder
    public class CostAccount : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.CostAccount>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.CostAccount JavaObject { get; }

        internal CostAccount(ProxyManager proxyManager, net.sf.mpxj.CostAccount javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public string ID => JavaObject.getID();

        public string Name => JavaObject.getName();

        public string Notes => JavaObject.getNotes();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public int? ParentUniqueID => JavaObject.getParentUniqueID().ConvertType();

        public CostAccount Parent => _proxyManager.ProxyObject(JavaObject.getParent());

        public override string ToString() => JavaObject.toString();
    }
}

