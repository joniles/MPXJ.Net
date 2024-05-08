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

        public class Builder : IJavaObjectProxy<net.sf.mpxj.ExpenseCategory.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.ExpenseCategory.Builder JavaObject { get; set; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.ExpenseCategory.Builder(file.JavaObject);
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

            public Builder SequenceNumber(int? value)
            {
                JavaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public ExpenseCategory Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
