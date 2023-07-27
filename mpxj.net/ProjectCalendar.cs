using System;
using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class ProjectCalendar : ProjectCalendarDays, IProjectEntityWithUniqueID, ITimeUnitDefaultsContainer<net.sf.mpxj.ProjectCalendar>, IJavaObjectProxy<net.sf.mpxj.ProjectCalendar>
    {
        public new net.sf.mpxj.ProjectCalendar JavaObject { get => (net.sf.mpxj.ProjectCalendar)base.JavaObject; }

        internal ProjectCalendar(ProxyManager proxyManager, net.sf.mpxj.ProjectCalendar javaObject) : base(proxyManager, javaObject) { }

        public int? MinutesPerDay => JavaObject.getMinutesPerDay().ConvertType();

        public int? MinutesPerWeek => JavaObject.getMinutesPerWeek().ConvertType();

        public int? MinutesPerMonth => JavaObject.getMinutesPerMonth().ConvertType();

        public int? MinutesPerYear => JavaObject.getMinutesPerYear().ConvertType();

        public int? DaysPerMonth => JavaObject.getDaysPerMonth().ConvertType();

        public int? CalendarMinutesPerDay
        {
            get => JavaObject.getCalendarMinutesPerDay().ConvertType();
            set => JavaObject.setCalendarMinutesPerDay(value.ConvertType());
        }

        public int? CalendarMinutesPerWeek
        {
            get => JavaObject.getCalendarMinutesPerWeek().ConvertType();
            set => JavaObject.setCalendarMinutesPerWeek(value.ConvertType());
        }

        public int? CalendarMinutesPerMonth
        {
            get => JavaObject.getCalendarMinutesPerMonth().ConvertType();
            set => JavaObject.setCalendarMinutesPerMonth(value.ConvertType());
        }

        public int? CalendarMinutesPerYear
        {
            get => JavaObject.getCalendarMinutesPerYear().ConvertType();
            set => JavaObject.setCalendarMinutesPerYear(value.ConvertType());
        }

        public ProjectCalendarWeek AddWorkWeek() => _proxyManager.ProxyObject(JavaObject.addWorkWeek());

        public void RemoveWorkWeek(ProjectCalendarWeek week) => JavaObject.removeWorkWeek(week.JavaObject);

        public void ClearWorkWeeks() => JavaObject.clearWorkWeeks();

        public IList<ProjectCalendarWeek> WorkWeeks => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendarWeek, ProjectCalendarWeek>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getWorkWeeks());

        public ProjectCalendarException AddCalendarException(java.time.LocalDate date) => _proxyManager.ProxyObject(JavaObject.addCalendarException(date));

        public ProjectCalendarException AddCalendarException(java.time.LocalDate fromDate, java.time.LocalDate toDate) => _proxyManager.ProxyObject(JavaObject.addCalendarException(fromDate, toDate));

        public ProjectCalendarException AddCalendarException(RecurringData recurringData) => _proxyManager.ProxyObject(JavaObject.addCalendarException(recurringData.JavaObject));

        public void RemoveCalendarException(ProjectCalendarException exception) => JavaObject.removeCalendarException(exception.JavaObject);

        public void ClearCalendarExceptions() => JavaObject.clearCalendarExceptions();

        public IList<ProjectCalendarException> CalendarExceptions => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendarException, ProjectCalendarException>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCalendarExceptions());

        public IList<ProjectCalendarException> ExpandedCalendarExceptions => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendarException, ProjectCalendarException>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getExpandedCalendarExceptions());

        public ProjectCalendar Parent
        {
            get => _proxyManager.ProxyObject(JavaObject.getParent());
            set => JavaObject.setParent(value.JavaObject);
        }

        public int? ParentUniqueID => JavaObject.getParentUniqueID().ConvertType();

        public Duration GetDuration(DateTime startDate, DateTime endDate) => _proxyManager.ProxyObject(JavaObject.getDuration(startDate.ConvertType(), endDate.ConvertType()));

        public TimeOnly? GetStartTime(java.time.LocalDate date) => JavaObject.getStartTime(date).ConvertType();

        public TimeOnly? GetFinishTime(java.time.LocalDate date) => JavaObject.getFinishTime(date).ConvertType();

        public DateTime? GetDate(DateTime startDate, Duration duration, bool returnNextWorkStart) => JavaObject.getDate(startDate.ConvertType(), duration.JavaObject, returnNextWorkStart).ConvertType();

        public DateTime? GetNextWorkStart(DateTime date) => JavaObject.getNextWorkStart(date.ConvertType()).ConvertType();

        public DateTime? GetPreviousWorkFinish(DateTime date) => JavaObject.getPreviousWorkFinish(date.ConvertType()).ConvertType();

        public DayType? GetDayType(java.time.DayOfWeek day) => JavaObject.getDayType(day).ConvertType();

        public bool IsWorkingDay(java.time.DayOfWeek day) => JavaObject.isWorkingDay(day);

        public bool IsWorkingDate(java.time.LocalDate date) => JavaObject.isWorkingDate(date);

        public ProjectCalendarHours GetHours(java.time.DayOfWeek day) => _proxyManager.ProxyObject(JavaObject.getHours(day));

        public ProjectCalendarHours GetHours(java.time.LocalDate date) => _proxyManager.ProxyObject(JavaObject.getHours(date));

        public ProjectCalendarHours GetHours(DateTime date) => _proxyManager.ProxyObject(JavaObject.getHours(date.ConvertType()));

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public IList<Task> Tasks => _proxyManager.ProxyList<net.sf.mpxj.Task, Task>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getTasks());

        public IList<Resource> Resources => _proxyManager.ProxyList<net.sf.mpxj.Resource, Resource>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getResources());

        public int ResourceCount => JavaObject.getResourceCount();

        public void Remove() => JavaObject.remove();

        public ProjectCalendarException GetException(java.time.LocalDate date) => _proxyManager.ProxyObject(JavaObject.getException(date));

        public ProjectCalendarWeek GetWorkWeek(java.time.LocalDate date) => _proxyManager.ProxyObject(JavaObject.getWorkWeek(date));

        public Duration GetWork(java.time.DayOfWeek day, TimeUnit format) => _proxyManager.ProxyObject(JavaObject.getWork(day, format.ConvertType()));

        public Duration GetWork(java.time.LocalDate date, TimeUnit format) => _proxyManager.ProxyObject(JavaObject.getWork(date, format.ConvertType()));

        public Duration GetWork(DateTime startDate, DateTime endDate, TimeUnit format) => _proxyManager.ProxyObject(JavaObject.getWork(startDate.ConvertType(), endDate.ConvertType(), format.ConvertType()));

        public IList<ProjectCalendar> DerivedCalendars => _proxyManager.ProxyList<net.sf.mpxj.ProjectCalendar, ProjectCalendar>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getDerivedCalendars());

        public override string ToString() => JavaObject.toString();

        public ProjectFile ParentFile => _proxyManager.ProjectFile;

        public bool Derived => JavaObject.isDerived();

        public CalendarType? Type
        {
            get => JavaObject.getType().ConvertType();
            set => JavaObject.setType(value.ConvertType());
        }

        public bool Personal
        {
            get => JavaObject.getPersonal();
            set => JavaObject.setPersonal(value);
        }
    }
}
