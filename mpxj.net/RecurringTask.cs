namespace org.mpxj
{
	public class RecurringTask : RecurringData, IJavaObjectProxy<net.sf.mpxj.RecurringTask>
	{
        public new net.sf.mpxj.RecurringTask JavaObject { get => (net.sf.mpxj.RecurringTask)base.JavaObject; }

        internal RecurringTask(net.sf.mpxj.RecurringTask javaObject) : base(javaObject) { }

        public net.sf.mpxj.Duration Duration
        {
            get => JavaObject.getDuration();
            set => JavaObject.setDuration(value);
        }
    }
}
