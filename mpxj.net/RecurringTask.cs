using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public class RecurringTask : RecurringData, IJavaObjectProxy<org.mpxj.RecurringTask>
	{
        private readonly ProxyManager _proxyManager;
        public new org.mpxj.RecurringTask JavaObject => (org.mpxj.RecurringTask)base.JavaObject;

        internal RecurringTask(ProxyManager proxyManager, org.mpxj.RecurringTask javaObject) : base(javaObject)
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
