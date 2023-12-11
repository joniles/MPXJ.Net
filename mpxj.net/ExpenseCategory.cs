using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: implement builder
    public class ExpenseCategory : IJavaObjectProxy<net.sf.mpxj.ExpenseCategory>
    {
        public net.sf.mpxj.ExpenseCategory JavaObject { get; }

        internal ExpenseCategory(net.sf.mpxj.ExpenseCategory javaObject)
        {
            JavaObject = javaObject;
        }

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public string Name => JavaObject.getName();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public override string ToString() => JavaObject.toString();
    }
}

