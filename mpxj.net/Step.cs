using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Step : IJavaObjectProxy<org.mpxj.Step>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.Step JavaObject { get; }

        internal Step(ProxyManager proxyManager, org.mpxj.Step javaObject)
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

        public class Builder : IJavaObjectProxy<org.mpxj.Step.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public org.mpxj.Step.Builder JavaObject { get; }

            public Builder(Task task)
            {
                _proxyManager = task._proxyManager;
                JavaObject = new org.mpxj.Step.Builder(task.JavaObject);
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder Name(string value)
            {
                JavaObject.name(value);
                return this;
            }

            public Builder PercentComplete(double? value)
            {
                JavaObject.percentComplete(value.ConvertType());
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                JavaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public Builder Weight(double? value)
            {
                JavaObject.weight(value.ConvertType());
                return this;
            }

            public Builder Description(Notes value)
            {
                JavaObject.description(value?.JavaObject);
                return this;
            }

            public Step Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
