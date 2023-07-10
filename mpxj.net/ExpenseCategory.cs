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

        public ExpenseCategory(java.lang.Integer uniqueID, string name, java.lang.Integer sequenceNumber)
        {
            JavaObject = new net.sf.mpxj.ExpenseCategory(uniqueID, name, sequenceNumber);
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public string Name
        {
            get => JavaObject.getName();
        }

        public java.lang.Integer SequenceNumber
        {
            get => JavaObject.getSequenceNumber();
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

