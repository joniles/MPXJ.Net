using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectCalendarException : ProjectCalendarHours, IJavaObjectProxy<net.sf.mpxj.ProjectCalendarException>
    {
        internal readonly ProxyManager _proxyManager;
        public new net.sf.mpxj.ProjectCalendarException JavaObject { get => (net.sf.mpxj.ProjectCalendarException)base.JavaObject; }

        internal ProjectCalendarException(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendarException javaObject) : base(proxyManager, javaObject)
        {
            _proxyManager = proxyManager;
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public java.time.LocalDate FromDate
        {
            get => JavaObject.getFromDate();
        }

        public java.time.LocalDate ToDate
        {
            get => JavaObject.getToDate();
        }

        public RecurringData Recurring
        {
            get => _proxyManager.ProxyObject(JavaObject.getRecurring());
        }

        public bool Working
        {
            get => JavaObject.getWorking();
        }

        public IList<ProjectCalendarException> ExpandedExceptions
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendarException, ProjectCalendarException>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getExpandedExceptions());
        }

        public bool Contains(java.time.LocalDate date)
        {
            return JavaObject.contains(date);
        }

        public bool Contains(java.time.LocalDateTime date)
        {
            return JavaObject.contains(date);
        }

        public bool Contains(ProjectCalendarException exception)
        {
            return JavaObject.contains(exception.JavaObject);
        }

        public override string ToString() => JavaObject.toString();
    }
}