using java.lang;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ExpenseCategory : IJavaObjectProxy<net.sf.mpxj.ExpenseCategory>
    {
        public net.sf.mpxj.ExpenseCategory JavaObject { get; }

        internal ExpenseCategory(net.sf.mpxj.ExpenseCategory javaObject)
        {
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public string Name => JavaObject.getName();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public override string ToString() => JavaObject.toString();

        public class Builder
        {
            private readonly ProxyManager _proxyManager;
            private readonly net.sf.mpxj.ExpenseCategory.Builder _javaObject;

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                _javaObject = new net.sf.mpxj.ExpenseCategory.Builder(file.JavaObject);
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

            public Builder SequenceNumber(int? value)
            {
                _javaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public ExpenseCategory Build() => _proxyManager.ProxyObject(_javaObject.build());
        }
    }
}
