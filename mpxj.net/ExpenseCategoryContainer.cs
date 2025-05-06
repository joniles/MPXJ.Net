using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ExpenseCategoryContainer : ProjectEntityContainer<org.mpxj.ExpenseCategory, ExpenseCategory>
    {
        public new org.mpxj.ExpenseCategoryContainer JavaObject => (org.mpxj.ExpenseCategoryContainer)base.JavaObject;

        internal ExpenseCategoryContainer(ProxyManager proxyManager, org.mpxj.ExpenseCategoryContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}
