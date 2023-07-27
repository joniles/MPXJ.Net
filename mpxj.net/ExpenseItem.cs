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

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public int? AccountUniqueID => JavaObject.getAccountUniqueID().ConvertType();

        public CostAccount Account
        {
            get => _proxyManager.ProxyObject(JavaObject.getAccount());
            set => JavaObject.setAccount(value.JavaObject);
        }

        public int? CategoryUniqueID => JavaObject.getCategoryUniqueID().ConvertType();

        public ExpenseCategory Category
        {
            get => _proxyManager.ProxyObject(JavaObject.getCategory());
            set => JavaObject.setCategory(value.JavaObject);
        }

        public Task Task => _proxyManager.ProxyObject(JavaObject.getTask());

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

        public double? AtCompletionCost
        {
            get => JavaObject.getAtCompletionCost().ConvertType();
            set => JavaObject.setAtCompletionCost(value.ConvertType());
        }

        public double? AtCompletionUnits
        {
            get => JavaObject.getAtCompletionUnits().ConvertType();
            set => JavaObject.setAtCompletionUnits(value.ConvertType());
        }

        public double? ActualCost
        {
            get => JavaObject.getActualCost().ConvertType();
            set => JavaObject.setActualCost(value.ConvertType());
        }

        public double? ActualUnits
        {
            get => JavaObject.getActualUnits().ConvertType();
            set => JavaObject.setActualUnits(value.ConvertType());
        }

        public double? PricePerUnit
        {
            get => JavaObject.getPricePerUnit().ConvertType();
            set => JavaObject.setPricePerUnit(value.ConvertType());
        }

        public double? RemainingCost
        {
            get => JavaObject.getRemainingCost().ConvertType();
            set => JavaObject.setRemainingCost(value.ConvertType());
        }

        public double? RemainingUnits
        {
            get => JavaObject.getRemainingUnits().ConvertType();
            set => JavaObject.setRemainingUnits(value.ConvertType());
        }

        public double? PlannedCost
        {
            get => JavaObject.getPlannedCost().ConvertType();
            set => JavaObject.setPlannedCost(value.ConvertType());
        }

        public double? PlannedUnits
        {
            get => JavaObject.getPlannedUnits().ConvertType();
            set => JavaObject.setPlannedUnits(value.ConvertType());
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

        public override string ToString() => JavaObject.toString();
    }
}
