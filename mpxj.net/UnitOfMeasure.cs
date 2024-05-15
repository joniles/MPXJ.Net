using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class UnitOfMeasure : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.UnitOfMeasure>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.UnitOfMeasure JavaObject { get; }

        internal UnitOfMeasure(ProxyManager proxyManager, net.sf.mpxj.UnitOfMeasure javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public string Name => JavaObject.getName();

        public string Abbreviation => JavaObject.getAbbreviation();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.UnitOfMeasure.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.UnitOfMeasure.Builder JavaObject { get; set; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.UnitOfMeasure.Builder(file.JavaObject);
            }

            public Builder Name(string value)
            {
                JavaObject.name(value);
                return this;
            }

            public Builder Abbreviation(string value)
            {
                JavaObject.abbreviation(value);
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                JavaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public UnitOfMeasure Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
