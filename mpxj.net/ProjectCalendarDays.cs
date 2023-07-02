namespace org.mpxj
{
    public class ProjectCalendarDays
    {
        internal readonly ProjectFile _projectFile;
        internal readonly net.sf.mpxj.ProjectCalendarDays _proxy;

        internal ProjectCalendarDays(ProjectFile projectFile, net.sf.mpxj.ProjectCalendarDays proxy)
        {
            _projectFile = projectFile;
            _proxy = proxy;
        }

        public readonly net.sf.mpxj.LocalTimeRange DefaultWorkingMorning = net.sf.mpxj.ProjectCalendarDays.DEFAULT_WORKING_MORNING;

        public readonly net.sf.mpxj.LocalTimeRange DefaultWorkingAfternoon = net.sf.mpxj.ProjectCalendarDays.DEFAULT_WORKING_AFTERNOON;

        public string Name
        {
            get => _proxy.getName();
            set => _proxy.setName(value);
        }

        public ProjectCalendarHours GetCalendarHours(java.time.DayOfWeek day)
        {
            return _projectFile.ProxyObject(_proxy.getCalendarHours(day));
        }

        public void AddDefaultCalendarHours()
        {
            _proxy.addDefaultCalendarHours();
        }

        public void AddDefaultCalendarDays()
        {
            _proxy.addDefaultCalendarDays();
        }

        public void AddDefaultCalendarHours(java.time.DayOfWeek day)
        {
            _proxy.addDefaultCalendarHours(day);
        }

        public ProjectCalendarHours AddCalendarHours(java.time.DayOfWeek day)
        {
            return _projectFile.ProxyObject(_proxy.addCalendarHours(day));
        }

        public void RemoveCalendarHours(java.time.DayOfWeek day)
        {
            _proxy.removeCalendarHours(day);
        }

        public net.sf.mpxj.DayType GetCalendarDayType(java.time.DayOfWeek day)
        {
            return _proxy.getCalendarDayType(day);
        }

        public void SetWorkingDay(java.time.DayOfWeek day, bool working)
        {
            _proxy.setWorkingDay(day, working);
        }

        public void SetCalendarDayType(java.time.DayOfWeek day, net.sf.mpxj.DayType type)
        {
            _proxy.setCalendarDayType(day, type);
        }
    }
}