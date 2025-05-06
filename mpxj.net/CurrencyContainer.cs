using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CurrencyContainer : ProjectEntityContainer<org.mpxj.Currency, Currency>
    {
        public new org.mpxj.CurrencyContainer JavaObject => (org.mpxj.CurrencyContainer)base.JavaObject;

        internal CurrencyContainer(ProxyManager proxyManager, org.mpxj.CurrencyContainer javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }
    }
}