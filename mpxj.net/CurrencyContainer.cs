using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CurrencyContainer : ProjectEntityContainer<net.sf.mpxj.Currency, Currency>
    {
        public new net.sf.mpxj.CurrencyContainer JavaObject => (net.sf.mpxj.CurrencyContainer)base.JavaObject;

        internal CurrencyContainer(ProxyManager proxyManager, net.sf.mpxj.CurrencyContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}