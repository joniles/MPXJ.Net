using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectCalendar : ProjectCalendarDays, IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.ProjectCalendar>
    {
        public new net.sf.mpxj.ProjectCalendar JavaObject { get => (net.sf.mpxj.ProjectCalendar)base.JavaObject; }

        internal ProjectCalendar(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendar javaObject) : base(proxyManager, javaObject) { }

        public java.lang.Integer MinutesPerDay
        {
            get => JavaObject.getMinutesPerDay();
        }

        public java.lang.Integer MinutesPerWeek
        {
            get => JavaObject.getMinutesPerWeek();
        }

        public java.lang.Integer MinutesPerMonth
        {
            get => JavaObject.getMinutesPerMonth();
        }

        public java.lang.Integer MinutesPerYear
        {
            get => JavaObject.getMinutesPerYear();
        }

        public java.lang.Integer DaysPerMonth
        {
            get => JavaObject.getDaysPerMonth();
        }

        public java.lang.Integer CalendarMinutesPerDay
        {
            get => JavaObject.getCalendarMinutesPerDay();
            set => JavaObject.setCalendarMinutesPerDay(value);
        }

        public java.lang.Integer CalendarMinutesPerWeek
        {
            get => JavaObject.getCalendarMinutesPerWeek();
            set => JavaObject.setCalendarMinutesPerWeek(value);
        }

        public java.lang.Integer CalendarMinutesPerMonth
        {
            get => JavaObject.getCalendarMinutesPerMonth();
            set => JavaObject.setCalendarMinutesPerMonth(value);
        }

        public java.lang.Integer CalendarMinutesPerYear
        {
            get => JavaObject.getCalendarMinutesPerYear();
            set => JavaObject.setCalendarMinutesPerYear(value);
        }

        public ProjectCalendarWeek AddWorkWeek()
        {
            return _proxyManager.ProxyObject(JavaObject.addWorkWeek());
        }

        public void RemoveWorkWeek(ProjectCalendarWeek week)
        {
            JavaObject.removeWorkWeek(week.JavaObject);
        }

        public void ClearWorkWeeks()
        {
            JavaObject.clearWorkWeeks();
        }

        public IList<ProjectCalendarWeek> WorkWeeks
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendarWeek, ProjectCalendarWeek>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getWorkWeeks());
        }

        public ProjectCalendarException AddCalendarException(java.time.LocalDate date)
        {
            return _proxyManager.ProxyObject(JavaObject.addCalendarException(date));
        }

        public ProjectCalendarException AddCalendarException(java.time.LocalDate fromDate, java.time.LocalDate toDate)
        {
            return _proxyManager.ProxyObject(JavaObject.addCalendarException(fromDate, toDate));
        }

        public ProjectCalendarException AddCalendarException(RecurringData recurringData)
        {
            return _proxyManager.ProxyObject(JavaObject.addCalendarException(recurringData.JavaObject));
        }

        public void RemoveCalendarException(ProjectCalendarException exception)
        {
            JavaObject.removeCalendarException(exception.JavaObject);
        }

        public void ClearCalendarExceptions()
        {
            JavaObject.clearCalendarExceptions();
        }

        public IList<ProjectCalendarException> CalendarExceptions
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendarException, ProjectCalendarException>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCalendarExceptions());
        }

        public IList<ProjectCalendarException> ExpandedCalendarExceptions
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendarException, ProjectCalendarException>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getExpandedCalendarExceptions());
        }

        public ProjectCalendar Parent
        {
            get => _proxyManager.ProxyObject(JavaObject.getParent());
            set => JavaObject.setParent(value.JavaObject);
        }

        public java.lang.Integer ParentUniqueID
        {
            get => JavaObject.getParentUniqueID();
        }

        public net.sf.mpxj.Duration GetDuration(java.time.LocalDateTime startDate, java.time.LocalDateTime endDate)
        {
            return JavaObject.getDuration(startDate, endDate);
        }

        public java.time.LocalTime GetStartTime(java.time.LocalDate date)
        {
            return JavaObject.getStartTime(date);
        }

        public java.time.LocalTime GetFinishTime(java.time.LocalDate date)
        {
            return JavaObject.getFinishTime(date);
        }

        public java.time.LocalDateTime GetDate(java.time.LocalDateTime startDate, net.sf.mpxj.Duration duration, bool returnNextWorkStart)
        {
            return JavaObject.getDate(startDate, duration, returnNextWorkStart);
        }

        public java.time.LocalDateTime GetNextWorkStart(java.time.LocalDateTime date)
        {
            return JavaObject.getNextWorkStart(date);
        }

        public java.time.LocalDateTime GetPreviousWorkFinish(java.time.LocalDateTime date)
        {
            return JavaObject.getPreviousWorkFinish(date);
        }

        public DayType? GetDayType(java.time.DayOfWeek day)
        {
            return JavaObject.getDayType(day).ConvertType();
        }

        public bool IsWorkingDay(java.time.DayOfWeek day)
        {
            return JavaObject.isWorkingDay(day);
        }

        public bool IsWorkingDate(java.time.LocalDate date)
        {
            return JavaObject.isWorkingDate(date);
        }

        public ProjectCalendarHours GetHours(java.time.DayOfWeek day)
        {
            return _proxyManager.ProxyObject(JavaObject.getHours(day));
        }

        public ProjectCalendarHours GetHours(java.time.LocalDate date)
        {
            return _proxyManager.ProxyObject(JavaObject.getHours(date));
        }

        public ProjectCalendarHours GetHours(java.time.LocalDateTime date)
        {
            return _proxyManager.ProxyObject(JavaObject.getHours(date));
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public IList<Task> Tasks
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.Task, Task>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTasks());
        }

        public IList<Resource> Resources
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.Resource, Resource>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getResources());
        }

        public int ResourceCount
        {
            get => JavaObject.getResourceCount();
        }

        public void Remove()
        {
            JavaObject.remove();
        }

        public ProjectCalendarException GetException(java.time.LocalDate date)
        {
            return _proxyManager.ProxyObject(JavaObject.getException(date));
        }

        public ProjectCalendarWeek GetWorkWeek(java.time.LocalDate date)
        {
            return _proxyManager.ProxyObject(JavaObject.getWorkWeek(date));
        }

        public net.sf.mpxj.Duration GetWork(java.time.DayOfWeek day, TimeUnit format)
        {
            return JavaObject.getWork(day, format.ConvertType());
        }

        public net.sf.mpxj.Duration GetWork(java.time.LocalDate date, TimeUnit format)
        {
            return JavaObject.getWork(date, format.ConvertType());
        }

        public net.sf.mpxj.Duration GetWork(java.time.LocalDateTime startDate, java.time.LocalDateTime endDate, TimeUnit format)
        {
            return JavaObject.getWork(startDate, endDate, format.ConvertType());
        }

        public IList<ProjectCalendar> DerivedCalendars
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendar, ProjectCalendar>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getDerivedCalendars());
        }

        public override string ToString()
        {
            return JavaObject.toString();
        }

        public ProjectFile ParentFile
        {
            get => _proxyManager.ProjectFile;
        }

        public bool Derived
        {
            get => JavaObject.isDerived();
        }

        public net.sf.mpxj.CalendarType Type
        {
            get => JavaObject.getType();
            set => JavaObject.setType(value);
        }

        public bool Personal
        {
            get => JavaObject.getPersonal();
            set => JavaObject.setPersonal(value);
        }
    }
}

