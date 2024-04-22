using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    // TODO: implement builder
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
    }
}
