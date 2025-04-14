using System;
using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ProjectCalendarException : ProjectCalendarHours, IJavaObjectProxy<org.mpxj.ProjectCalendarException>
    {
        private readonly ProxyManager _proxyManager;
        public new org.mpxj.ProjectCalendarException JavaObject => (org.mpxj.ProjectCalendarException)base.JavaObject;

        internal ProjectCalendarException(ProxyManager proxyManager, org.mpxj.ProjectCalendarException javaObject) : base(proxyManager, javaObject)
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

        public IList<ProjectCalendarException> ExpandedExceptions => _proxyManager.ProxyList<org.mpxj.ProjectCalendarException, ProjectCalendarException>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getExpandedExceptions());

        public bool Contains(DateOnly date) => JavaObject.contains(date);

        public bool Contains(DateTime date) => JavaObject.contains(date);

        public bool Contains(ProjectCalendarException exception) => JavaObject.contains(exception.JavaObject);

        public override string ToString() => JavaObject.toString();
    }
}