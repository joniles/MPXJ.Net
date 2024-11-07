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

        public Notes NotesObject => _proxyManager.ProxyObject(JavaObject.getNotesObject());

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public int? ParentUniqueID => JavaObject.getParentUniqueID().ConvertType();

        public CostAccount Parent => _proxyManager.ProxyObject(JavaObject.getParent());

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.CostAccount.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.CostAccount.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.CostAccount.Builder(file.JavaObject);
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder Id(string value)
            {
                JavaObject.id(value);
                return this;
            }

            public Builder Name(string value)
            {
                JavaObject.name(value);
                return this;
            }

            public Builder Notes(Notes value)
            {
                JavaObject.notes(value?.JavaObject);
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                JavaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public Builder Parent(CostAccount value)
            {
                JavaObject.parent(value?.JavaObject);
                return this;
            }


            public CostAccount Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
