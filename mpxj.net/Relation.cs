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

        public Task SourceTask => _proxyManager.ProxyObject(JavaObject.getSourceTask());

        public Task TargetTask => _proxyManager.ProxyObject(JavaObject.getTargetTask());

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public override string ToString() => JavaObject.toString();

        public class Builder
        {
            private readonly ProxyManager _proxyManager;
            private readonly net.sf.mpxj.Relation.Builder _javaObject;

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                _javaObject = new net.sf.mpxj.Relation.Builder();
            }

            public Builder UniqueID(int? value)
            {
                _javaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder SourceTask(Task value)
            {
                _javaObject.sourceTask(value.JavaObject);
                return this;
            }

            public Builder TargetTask(Task value)
            {
                _javaObject.targetTask(value.JavaObject);
                return this;
            }

            public Builder Type(RelationType value)
            {
                _javaObject.type(value.ConvertType());
                return this;
            }

            public Builder Lag(Duration value)
            {
                _javaObject.lag(value.JavaObject);
                return this;
            }

            public Builder Notes(string value)
            {
                _javaObject.notes(value);
                return this;
            }

            public Relation Build() => _proxyManager.ProxyObject(_javaObject.build());
        }
    }
}

