using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
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

        public class Builder
        {
            private readonly ProxyManager _proxyManager;
            private readonly net.sf.mpxj.Step.Builder _javaObject;

            public Builder(Task task)
            {
                _proxyManager = task._proxyManager;
                _javaObject = new net.sf.mpxj.Step.Builder(task.JavaObject);
            }

            public Builder UniqueID(int? value)
            {
                _javaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder Name(string value)
            {
                _javaObject.name(value);
                return this;
            }

            public Builder PercentComplete(double? value)
            {
                _javaObject.percentComplete(value.ConvertType());
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                _javaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public Builder Weight(double? value)
            {
                _javaObject.weight(value.ConvertType());
                return this;
            }

            public Builder Description(Notes value)
            {
                _javaObject.description(value.JavaObject);
                return this;
            }

            public Step Build() => _proxyManager.ProxyObject(_javaObject.build());
        }
    }
}
