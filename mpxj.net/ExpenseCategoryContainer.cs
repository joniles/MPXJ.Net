using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: ProjectEntityContainer
    public class ExpenseCategoryContainer : ShallowProxyList<net.sf.mpxj.ExpenseCategory>, IJavaObjectProxy<net.sf.mpxj.ExpenseCategoryContainer>
    {
        public new net.sf.mpxj.ExpenseCategoryContainer JavaObject { get => (net.sf.mpxj.ExpenseCategoryContainer)base.JavaObject; }

        internal ExpenseCategoryContainer(net.sf.mpxj.ExpenseCategoryContainer javaObject) : base(javaObject) { }
    }
}
