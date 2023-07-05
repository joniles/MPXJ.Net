namespace org.mpxj
{
    public class ProjectCalendar : ProjectCalendarDays, IJavaObjectProxy<net.sf.mpxj.ProjectCalendar>
    {
        public new net.sf.mpxj.ProjectCalendar JavaObject { get => (net.sf.mpxj.ProjectCalendar)base.JavaObject; }

        internal ProjectCalendar(ProjectFile projectFile, net.sf.mpxj.ProjectCalendar javaObject) : base(projectFile, javaObject) { }

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
            return _projectFile.ProxyObject(JavaObject.addWorkWeek());
        }

        public void RemoveWorkWeek(ProjectCalendarWeek week)
        {
            JavaObject.removeWorkWeek(week.JavaObject);
        }

        public void ClearWorkWeeks()
        {
            JavaObject.clearWorkWeeks();
        }

        public java.util.List WorkWeeks
        {
            get => JavaObject.getWorkWeeks();
        }

        public ProjectCalendarException AddCalendarException(java.time.LocalDate date)
        {
            return _projectFile.ProxyObject(JavaObject.addCalendarException(date));
        }

        public ProjectCalendarException AddCalendarException(java.time.LocalDate fromDate, java.time.LocalDate toDate)
        {
            return _projectFile.ProxyObject(JavaObject.addCalendarException(fromDate, toDate));
        }

        public ProjectCalendarException AddCalendarException(RecurringData recurringData)
        {
            return _projectFile.ProxyObject(JavaObject.addCalendarException(recurringData.JavaObject));
        }

        public void RemoveCalendarException(ProjectCalendarException exception)
        {
            JavaObject.removeCalendarException(exception.JavaObject);
        }

        public void ClearCalendarExceptions()
        {
            JavaObject.clearCalendarExceptions();
        }

        public java.util.List CalendarExceptions
        {
            get => JavaObject.getCalendarExceptions();
        }

        public java.util.List ExpandedCalendarExceptions
        {
            get => JavaObject.getExpandedCalendarExceptions();
        }

        public ProjectCalendar Parent
        {
            get => _projectFile.ProxyObject(JavaObject.getParent());
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

        java.time.LocalDateTime GetPreviousWorkFinish(java.time.LocalDateTime date)
        {
            return JavaObject.getPreviousWorkFinish(date);
        }

        public DayType GetDayType(java.time.DayOfWeek day)
        {
            return (DayType)JavaObject.getDayType(day).getValue();
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
            return _projectFile.ProxyObject(JavaObject.getHours(day));
        }

        public ProjectCalendarHours GetHours(java.time.LocalDate date)
        {
            return _projectFile.ProxyObject(JavaObject.getHours(date));
        }

        public ProjectCalendarHours GetHours(java.time.LocalDateTime date)
        {
            return _projectFile.ProxyObject(JavaObject.getHours(date));
        }

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public java.util.List Tasks
        {
            get => JavaObject.getTasks();
        }

        public java.util.List Resources
        {
            get => JavaObject.getResources();
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
            return _projectFile.ProxyObject(JavaObject.getException(date));
        }

        public ProjectCalendarWeek GetWorkWeek(java.time.LocalDate date)
        {
            return _projectFile.ProxyObject(JavaObject.getWorkWeek(date));
        }

        public net.sf.mpxj.Duration GetWork(java.time.DayOfWeek day, TimeUnit format)
        {
            return JavaObject.getWork(day, net.sf.mpxj.TimeUnit.getInstance((int)format));
        }

        public net.sf.mpxj.Duration GetWork(java.time.LocalDate date, TimeUnit format)
        {
            return JavaObject.getWork(date, net.sf.mpxj.TimeUnit.getInstance((int)format));
        }

        public net.sf.mpxj.Duration GetWork(java.time.LocalDateTime startDate, java.time.LocalDateTime endDate, TimeUnit format)
        {
            return JavaObject.getWork(startDate, endDate, net.sf.mpxj.TimeUnit.getInstance((int)format));
        }

        public java.util.List DerivedCalendars
        {
            get => JavaObject.getDerivedCalendars();
        }

        public override string ToString()
        {
            return JavaObject.toString();
        }

        public ProjectFile ParentFile
        {
            get => _projectFile;
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

