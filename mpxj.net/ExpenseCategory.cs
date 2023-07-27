using org.mpxj.proxy;

namespace org.mpxj
{
    public class ExpenseCategory : IJavaObjectProxy<net.sf.mpxj.ExpenseCategory>
    {
        public net.sf.mpxj.ExpenseCategory JavaObject { get; }

        internal ExpenseCategory(net.sf.mpxj.ExpenseCategory javaObject)
        {
            JavaObject = javaObject;
        }

        public ExpenseCategory(int uniqueID, string name, int sequenceNumber)
        {
            JavaObject = new net.sf.mpxj.ExpenseCategory(uniqueID.ConvertType(), name, sequenceNumber.ConvertType());
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

