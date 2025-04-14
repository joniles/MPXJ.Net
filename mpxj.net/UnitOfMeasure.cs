using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class UnitOfMeasure : IProjectEntityWithUniqueID, IJavaObjectProxy<org.mpxj.UnitOfMeasure>
    {
        public org.mpxj.UnitOfMeasure JavaObject { get; }

        internal UnitOfMeasure(org.mpxj.UnitOfMeasure javaObject)
        {
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public string Name => JavaObject.getName();

        public string Abbreviation => JavaObject.getAbbreviation();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public class Builder : IJavaObjectProxy<org.mpxj.UnitOfMeasure.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public org.mpxj.UnitOfMeasure.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new org.mpxj.UnitOfMeasure.Builder(file.JavaObject);
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
