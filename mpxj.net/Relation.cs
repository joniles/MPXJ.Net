using MPXJ.Net.Proxy;

namespace MPXJ.Net
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

        [System.Obsolete("Use PredecessorTask or SuccessorTask")]
        public Task SourceTask => _proxyManager.ProxyObject(JavaObject.getSourceTask());

        [System.Obsolete("Use PredecessorTask or SuccessorTask")]
        public Task TargetTask => _proxyManager.ProxyObject(JavaObject.getTargetTask());

        public Task PredecessorTask => _proxyManager.ProxyObject(JavaObject.getPredecessorTask());

        public Task SuccessorTask => _proxyManager.ProxyObject(JavaObject.getSuccessorTask());

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.Relation.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.Relation.Builder JavaObject { get; set; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.Relation.Builder();
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            [System.Obsolete("Use PredecessorTask or SuccessorTask")]
            public Builder SourceTask(Task value)
            {
                JavaObject.sourceTask(value?.JavaObject);
                return this;
            }

            [System.Obsolete("Use PredecessorTask or SuccessorTask")]
            public Builder TargetTask(Task value)
            {
                JavaObject.targetTask(value?.JavaObject);
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

