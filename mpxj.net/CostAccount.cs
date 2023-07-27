using org.mpxj.proxy;

namespace org.mpxj
{
    public class CostAccount : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.CostAccount>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.CostAccount JavaObject { get; }

        internal CostAccount(ProxyManager proxyManager, net.sf.mpxj.CostAccount javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public CostAccount(ProjectFile file, int uniqueID, string id, string name, string description, int sequenceNumber)
        {
            _proxyManager = file._proxyManager;
            JavaObject = new net.sf.mpxj.CostAccount(uniqueID.ConvertType(), id, name, description, sequenceNumber.ConvertType());
        }

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public string ID => JavaObject.getID();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public int? ParentUniqueID => JavaObject.getParentUniqueID().ConvertType();

        public CostAccount Parent
        {
            get => _proxyManager.ProxyObject(JavaObject.getParent());
            set => JavaObject.setParent(value.JavaObject);
        }

        public override string ToString() => JavaObject.toString();
    }
}

