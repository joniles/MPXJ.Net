using org.mpxj.proxy;

namespace org.mpxj
{
    public class ExpenseItem : IJavaObjectProxy<net.sf.mpxj.ExpenseItem>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ExpenseItem JavaObject { get; }

        public ExpenseItem(Task task)
        {
            _proxyManager = task._proxyManager;
            JavaObject = new net.sf.mpxj.ExpenseItem(task.JavaObject);
        }

        internal ExpenseItem(ProxyManager proxyManager, net.sf.mpxj.ExpenseItem javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public java.lang.Integer AccountUniqueID
        {
            get => JavaObject.getAccountUniqueID();
        }

        public net.sf.mpxj.CostAccount Account
        {
            get => JavaObject.getAccount();
            set => JavaObject.setAccount(value);
        }

        public java.lang.Integer CategoryUniqueID
        {
            get => JavaObject.getCategoryUniqueID();
        }

        public net.sf.mpxj.ExpenseCategory Category
        {
            get => JavaObject.getCategory();
            set => JavaObject.setCategory(value);
        }

        public Task Task
        {
            get => _proxyManager.ProxyObject(JavaObject.getTask());
        }

        public string Description
        {
            get => JavaObject.getDescription();
            set => JavaObject.setDescription(value);
        }

        public string DocumentNumber
        {
            get => JavaObject.getDocumentNumber();
            set => JavaObject.setDocumentNumber(value);
        }

        public string Vendor
        {
            get => JavaObject.getVendor();
            set => JavaObject.setVendor(value);
        }

        public java.lang.Double AtCompletionCost
        {
            get => JavaObject.getAtCompletionCost();
            set => JavaObject.setAtCompletionCost(value);
        }

        public java.lang.Double AtCompletionUnits
        {
            get => JavaObject.getAtCompletionUnits();
            set => JavaObject.setAtCompletionUnits(value);
        }

        public java.lang.Double ActualCost
        {
            get => JavaObject.getActualCost();
            set => JavaObject.setActualCost(value);
        }

        public java.lang.Double ActualUnits
        {
            get => JavaObject.getActualUnits();
            set => JavaObject.setActualUnits(value);
        }

        public java.lang.Double PricePerUnit
        {
            get => JavaObject.getPricePerUnit();
            set => JavaObject.setPricePerUnit(value);
        }

        public java.lang.Double RemainingCost
        {
            get => JavaObject.getRemainingCost();
            set => JavaObject.setRemainingCost(value);
        }

        public java.lang.Double RemainingUnits
        {
            get => JavaObject.getRemainingUnits();
            set => JavaObject.setRemainingUnits(value);
        }

        public java.lang.Double PlannedCost
        {
            get => JavaObject.getPlannedCost();
            set => JavaObject.setPlannedCost(value);
        }

        public java.lang.Double PlannedUnits
        {
            get => JavaObject.getPlannedUnits();
            set => JavaObject.setPlannedUnits(value);
        }

        public AccrueType? AccrueType
        {
            get => JavaObject.getAccrueType().ConvertType();
            set => JavaObject.setAccrueType(value.ConvertType());
        }

        public bool AutoComputeActuals
        {
            get => JavaObject.getAutoComputeActuals();
            set => JavaObject.setAutoComputeActuals(value);
        }

        public string UnitOfMeasure
        {
            get => JavaObject.getUnitOfMeasure();
            set => JavaObject.setUnitOfMeasure(value);
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}
