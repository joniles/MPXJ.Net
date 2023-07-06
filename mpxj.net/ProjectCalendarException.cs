using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectCalendarException : ProjectCalendarHours, IJavaObjectProxy<net.sf.mpxj.ProjectCalendarException>
    {
        internal readonly ProjectFile _projectFile;
        public new net.sf.mpxj.ProjectCalendarException JavaObject { get => (net.sf.mpxj.ProjectCalendarException)base.JavaObject; }

        internal ProjectCalendarException(ProjectFile projectFile, net.sf.mpxj.ProjectCalendarException javaObject) : base(javaObject)
        {
            _projectFile = projectFile;
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
            get => _projectFile.ProxyObject(JavaObject.getRecurring());
        }

        public bool Working
        {
            get => JavaObject.getWorking();
        }

        public java.util.List ExpandedExceptions
        {
            get => JavaObject.getExpandedExceptions();
        }

        public bool Contains(java.util.Date date)
        {
            return JavaObject.contains(date);
        }

        public bool Contains(ProjectCalendarException exception)
        {
            return JavaObject.contains(exception.JavaObject);
        }

        public override string ToString()
        {
            return JavaObject.toString();
        }
    }
}