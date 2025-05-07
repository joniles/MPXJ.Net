using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Relation : IJavaObjectProxy<org.mpxj.Relation>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.Relation JavaObject { get; }

        internal Relation(ProxyManager proxyManager, org.mpxj.Relation javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public RelationType? Type => JavaObject.getType().ConvertType();

        public Duration Lag => _proxyManager.ProxyObject(JavaObject.getLag());
        
        public Task PredecessorTask => _proxyManager.ProxyObject(JavaObject.getPredecessorTask());

        public Task SuccessorTask => _proxyManager.ProxyObject(JavaObject.getSuccessorTask());

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<org.mpxj.Relation.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public org.mpxj.Relation.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new org.mpxj.Relation.Builder();
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }
            
            public Builder PredecessorTask(Task value)
            {
                JavaObject.predecessorTask(value?.JavaObject);
                return this;
            }

            public Builder SuccessorTask(Task value)
            {
                JavaObject.successorTask(value?.JavaObject);
                return this;
            }

            public Builder Type(RelationType value)
            {
                JavaObject.type(value.ConvertType());
                return this;
            }

            public Builder Lag(Duration value)
            {
                JavaObject.lag(value?.JavaObject);
                return this;
            }

            public Builder Notes(string value)
            {
                JavaObject.notes(value);
                return this;
            }

            public Relation Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}

