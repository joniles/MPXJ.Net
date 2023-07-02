namespace org.mpxj
{
    public class RecurringData
    {
        internal readonly net.sf.mpxj.RecurringData _proxy;

        internal RecurringData(net.sf.mpxj.RecurringData proxy)
        {
            _proxy = proxy;
        }

        public RecurringData()
        {
            _proxy = new net.sf.mpxj.RecurringData();
        }

        public java.time.LocalDate StartDate
        {
            get => _proxy.getStartDate();
            set => _proxy.setStartDate(value);
        }

        public java.time.LocalDate FinishDate
        {
            get => _proxy.getFinishDate();
            set => _proxy.setFinishDate(value);
        }

        public java.lang.Integer tOccurrences
        {
            get => _proxy.getOccurrences();
            set => _proxy.setOccurrences(value);
        }

        public net.sf.mpxj.RecurrenceType RecurrenceType
        {
            get => _proxy.getRecurrenceType();
            set => _proxy.setRecurrenceType(value);
        }

        public bool UseEndDate
        {
            get => _proxy.getUseEndDate();
            set => _proxy.setUseEndDate(value);
        }

        public bool WorkingDaysOnly
        {
            get => _proxy.getWorkingDaysOnly();
            set => _proxy.setWorkingDaysOnly(value);
        }

        public bool GetWeeklyDay(java.time.DayOfWeek day)
        {
            return _proxy.getWeeklyDay(day);
        }

        public void SetWeeklyDay(java.time.DayOfWeek day, bool value)
        {
            _proxy.setWeeklyDay(day, value);
        }

        public bool Relative
        {
            get => _proxy.getRelative();
            set => _proxy.setRelative(value);
        }

        public java.lang.Integer Frequency
        {
            get => _proxy.getFrequency();
            set => _proxy.setFrequency(value);
        }

        public java.time.DayOfWeek DayOfWeek
        {
            get => _proxy.getDayOfWeek();
            set => _proxy.setDayOfWeek(value);
        }

        public java.lang.Integer DayNumber
        {
            get => _proxy.getDayNumber();
            set => _proxy.setDayNumber(value);
        }

        public java.lang.Integer MonthNumber
        {
            get => _proxy.getMonthNumber();
            set => _proxy.setMonthNumber(value);
        }

        public java.time.LocalDate[] Dates
        {
            get => _proxy.getDates();
        }

        public bool Valid
        {
            get => _proxy.isValid();
        }

        public java.time.LocalDate CalculatedFirstDate
        {
            get => _proxy.getCalculatedFirstDate();
        }

        public java.time.LocalDate CalculatedLastDate
        {
            get => _proxy.getCalculatedLastDate();
        }

        public void SetYearlyAbsoluteFromDate(java.time.LocalDate date)
        {
            _proxy.setYearlyAbsoluteFromDate(date);
        }

        public override string ToString()
        {
            return _proxy.toString();
        }
    }
}