using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ExpenseItem : IJavaObjectProxy<net.sf.mpxj.ExpenseItem>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ExpenseItem JavaObject { get; }

        internal ExpenseItem(ProxyManager proxyManager, net.sf.mpxj.ExpenseItem javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public string Name => JavaObject.getName();

        public int? AccountUniqueID => JavaObject.getAccountUniqueID().ConvertType();

        public CostAccount Account => _proxyManager.ProxyObject(JavaObject.getAccount());

        public int? CategoryUniqueID => JavaObject.getCategoryUniqueID().ConvertType();

        public ExpenseCategory Category => _proxyManager.ProxyObject(JavaObject.getCategory());

        public Task Task => _proxyManager.ProxyObject(JavaObject.getTask());

        public string Description => JavaObject.getDescription();

        public string DocumentNumber => JavaObject.getDocumentNumber();

        public string Vendor => JavaObject.getVendor();

        public double? AtCompletionCost => JavaObject.getAtCompletionCost().ConvertType();

        public double? AtCompletionUnits => JavaObject.getAtCompletionUnits().ConvertType();

        public double? ActualCost => JavaObject.getActualCost().ConvertType();

        public double? ActualUnits => JavaObject.getActualUnits().ConvertType();

        public double? PricePerUnit => JavaObject.getPricePerUnit().ConvertType();

        public double? RemainingCost => JavaObject.getRemainingCost().ConvertType();

        public double? RemainingUnits => JavaObject.getRemainingUnits().ConvertType();

        public double? PlannedCost => JavaObject.getPlannedCost().ConvertType();

        public double? PlannedUnits => JavaObject.getPlannedUnits().ConvertType();

        public AccrueType? AccrueType => JavaObject.getAccrueType().ConvertType();

        public bool AutoComputeActuals => JavaObject.getAutoComputeActuals();

        public string UnitOfMeasure => JavaObject.getUnitOfMeasure();

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.ExpenseItem.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.ExpenseItem.Builder JavaObject { get; set; }

            public Builder(Task task)
            {
                _proxyManager = task._proxyManager;
                JavaObject = new net.sf.mpxj.ExpenseItem.Builder(task.JavaObject);
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

            public Builder Account(CostAccount value)
            {
                JavaObject.account(value.JavaObject);
                return this;
            }

            public Builder Category(ExpenseCategory value)
            {
                JavaObject.category(value.JavaObject);
                return this;
            }

            public Builder Description(string value)
            {
                JavaObject.description(value);
                return this;
            }

            public Builder DocumentNumber(string value)
            {
                JavaObject.documentNumber(value);
                return this;
            }

            public Builder Vendor(string value)
            {
                JavaObject.vendor(value);
                return this;
            }

            public Builder AtCompletionCost(double? value)
            {
                JavaObject.atCompletionCost(value.ConvertType());
                return this;
            }

            public Builder AtCompletionUnits(double? value)
            {
                JavaObject.atCompletionUnits(value.ConvertType());
                return this;
            }

            public Builder ActualCost(double? value)
            {
                JavaObject.actualCost(value.ConvertType());
                return this;
            }

            public Builder ActualUnits(double? value)
            {
                JavaObject.actualUnits(value.ConvertType());
                return this;
            }

            public Builder PricePerUnit(double? value)
            {
                JavaObject.pricePerUnit(value.ConvertType());
                return this;
            }

            public Builder RemainingCost(double? value)
            {
                JavaObject.remainingCost(value.ConvertType());
                return this;
            }

            public Builder RemainingUnits(double? value)
            {
                JavaObject.remainingUnits(value.ConvertType());
                return this;
            }

            public Builder PlannedCost(double? value)
            {
                JavaObject.plannedCost(value.ConvertType());
                return this;
            }

            public Builder PlannedUnits(double? value)
            {
                JavaObject.plannedUnits(value.ConvertType());
                return this;
            }

            public Builder AccrueType(AccrueType value)
            {
                JavaObject.accrueType(value.ConvertType());
                return this;
            }

            public Builder AutoComputeActuals(bool value)
            {
                JavaObject.autoComputeActuals(value);
                return this;
            }

            public Builder UnitOfMeasure(string value)
            {
                JavaObject.unitOfMeasure(value);
                return this;
            }

            public ExpenseItem Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
