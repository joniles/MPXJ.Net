using MPXJ.Net.Proxy;

namespace MPXJ.Net
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

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public string ID => JavaObject.getID();

        public string Name => JavaObject.getName();

        public string Notes => JavaObject.getNotes();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public int? ParentUniqueID => JavaObject.getParentUniqueID().ConvertType();

        public CostAccount Parent => _proxyManager.ProxyObject(JavaObject.getParent());

        public override string ToString() => JavaObject.toString();

        public class Builder
        {
            private readonly ProxyManager _proxyManager;
            private readonly net.sf.mpxj.CostAccount.Builder _javaObject;

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                _javaObject = new net.sf.mpxj.CostAccount.Builder(file.JavaObject);
            }

            public Builder UniqueID(int? value)
            {
                _javaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder Id(string value)
            {
                _javaObject.id(value);
                return this;
            }

            public Builder Name(string value)
            {
                _javaObject.name(value);
                return this;
            }

            public Builder Notes(Notes value)
            {
                _javaObject.notes(value.JavaObject);
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                _javaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public Builder Parent(CostAccount value)
            {
                _javaObject.parent(value.JavaObject);
                return this;
            }


            public CostAccount Build() => _proxyManager.ProxyObject(_javaObject.build());
        }
    }
}
