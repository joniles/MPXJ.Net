using System;
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

        public DateOnly? FromDate => JavaObject.getFromDate().ConvertType();

        public DateOnly? ToDate => JavaObject.getToDate().ConvertType();

        public RecurringData Recurring => _proxyManager.ProxyObject(JavaObject.getRecurring());

        public bool Working => JavaObject.getWorking();

        public IList<ProjectCalendarException> ExpandedExceptions => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendarException, ProjectCalendarException>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getExpandedExceptions());

        public bool Contains(DateOnly date) => JavaObject.contains(date);

        public bool Contains(DateTime date) => JavaObject.contains(date);

        public bool Contains(ProjectCalendarException exception) => JavaObject.contains(exception.JavaObject);

        public override string ToString() => JavaObject.toString();
    }
}