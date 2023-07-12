using org.mpxj.proxy;

namespace org.mpxj
{
    public class ExpenseCategoryContainer : ProjectEntityContainer<net.sf.mpxj.ExpenseCategory, ExpenseCategory>
    {
        public new net.sf.mpxj.ExpenseCategoryContainer JavaObject => (net.sf.mpxj.ExpenseCategoryContainer)base.JavaObject;

        internal ExpenseCategoryContainer(ProxyManager proxyManager, net.sf.mpxj.ExpenseCategoryContainer javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }
    }
}
