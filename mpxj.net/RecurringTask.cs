using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class RecurringTask : RecurringData, IJavaObjectProxy<net.sf.mpxj.RecurringTask>
	{
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.RecurringTask JavaObject => (net.sf.mpxj.RecurringTask)base.JavaObject;

        internal RecurringTask(ProxyManager proxyManager, net.sf.mpxj.RecurringTask javaObject) : base(javaObject)
        {
            _proxyManager = proxyManager;
        }

        public Duration Duration
        {
            get => _proxyManager.ProxyObject(JavaObject.getDuration());
            set => JavaObject.setDuration(value?.JavaObject);
        }
    }
}
