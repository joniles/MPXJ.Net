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

        public class Builder
        {
            private readonly ProxyManager _proxyManager;
            private readonly net.sf.mpxj.ExpenseItem.Builder _javaObject;

            public Builder(Task task)
            {
                _proxyManager = task._proxyManager;
                _javaObject = new net.sf.mpxj.ExpenseItem.Builder(task.JavaObject);
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

            public Builder Account(CostAccount value)
            {
                _javaObject.account(value.JavaObject);
                return this;
            }

            public Builder Category(ExpenseCategory value)
            {
                _javaObject.category(value.JavaObject);
                return this;
            }

            public Builder Description(string value)
            {
                _javaObject.description(value);
                return this;
            }

            public Builder DocumentNumber(string value)
            {
                _javaObject.documentNumber(value);
                return this;
            }

            public Builder Vendor(string value)
            {
                _javaObject.vendor(value);
                return this;
            }

            public Builder AtCompletionCost(double? value)
            {
                _javaObject.atCompletionCost(value.ConvertType());
                return this;
            }

            public Builder AtCompletionUnits(double? value)
            {
                _javaObject.atCompletionUnits(value.ConvertType());
                return this;
            }

            public Builder ActualCost(double? value)
            {
                _javaObject.actualCost(value.ConvertType());
                return this;
            }

            public Builder ActualUnits(double? value)
            {
                _javaObject.actualUnits(value.ConvertType());
                return this;
            }

            public Builder PricePerUnit(double? value)
            {
                _javaObject.pricePerUnit(value.ConvertType());
                return this;
            }

            public Builder RemainingCost(double? value)
            {
                _javaObject.remainingCost(value.ConvertType());
                return this;
            }

            public Builder RemainingUnits(double? value)
            {
                _javaObject.remainingUnits(value.ConvertType());
                return this;
            }

            public Builder PlannedCost(double? value)
            {
                _javaObject.plannedCost(value.ConvertType());
                return this;
            }

            public Builder PlannedUnits(double? value)
            {
                _javaObject.plannedUnits(value.ConvertType());
                return this;
            }

            public Builder AccrueType(AccrueType value)
            {
                _javaObject.accrueType(value.ConvertType());
                return this;
            }

            public Builder AutoComputeActuals(bool value)
            {
                _javaObject.autoComputeActuals(value);
                return this;
            }

            public Builder UnitOfMeasure(string value)
            {
                _javaObject.unitOfMeasure(value);
                return this;
            }

            public ExpenseItem Build() => _proxyManager.ProxyObject(_javaObject.build());
        }
    }
}
