using org.mpxj.proxy;

namespace org.mpxj
{
    public class RecurringData : IJavaObjectProxy<net.sf.mpxj.RecurringData>
    {
        public net.sf.mpxj.RecurringData JavaObject { get; }

        internal RecurringData(net.sf.mpxj.RecurringData javaObject)
        {
            JavaObject = javaObject;
        }

        public RecurringData()
        {
            JavaObject = new net.sf.mpxj.RecurringData();
        }

        public java.time.LocalDate StartDate
        {
            get => JavaObject.getStartDate();
            set => JavaObject.setStartDate(value);
        }

        public java.time.LocalDate FinishDate
        {
            get => JavaObject.getFinishDate();
            set => JavaObject.setFinishDate(value);
        }

        public java.lang.Integer tOccurrences
        {
            get => JavaObject.getOccurrences();
            set => JavaObject.setOccurrences(value);
        }

        public net.sf.mpxj.RecurrenceType RecurrenceType
        {
            get => JavaObject.getRecurrenceType();
            set => JavaObject.setRecurrenceType(value);
        }

        public bool UseEndDate
        {
            get => JavaObject.getUseEndDate();
            set => JavaObject.setUseEndDate(value);
        }

        public bool WorkingDaysOnly
        {
            get => JavaObject.getWorkingDaysOnly();
            set => JavaObject.setWorkingDaysOnly(value);
        }

        public bool GetWeeklyDay(java.time.DayOfWeek day)
        {
            return JavaObject.getWeeklyDay(day);
        }

        public void SetWeeklyDay(java.time.DayOfWeek day, bool value)
        {
            JavaObject.setWeeklyDay(day, value);
        }

        public bool Relative
        {
            get => JavaObject.getRelative();
            set => JavaObject.setRelative(value);
        }

        public java.lang.Integer Frequency
        {
            get => JavaObject.getFrequency();
            set => JavaObject.setFrequency(value);
        }

        public java.time.DayOfWeek DayOfWeek
        {
            get => JavaObject.getDayOfWeek();
            set => JavaObject.setDayOfWeek(value);
        }

        public java.lang.Integer DayNumber
        {
            get => JavaObject.getDayNumber();
            set => JavaObject.setDayNumber(value);
        }

        public java.lang.Integer MonthNumber
        {
            get => JavaObject.getMonthNumber();
            set => JavaObject.setMonthNumber(value);
        }

        public java.time.LocalDate[] Dates
        {
            get => JavaObject.getDates();
        }

        public bool Valid
        {
            get => JavaObject.isValid();
        }

        public java.time.LocalDate CalculatedFirstDate
        {
            get => JavaObject.getCalculatedFirstDate();
        }

        public java.time.LocalDate CalculatedLastDate
        {
            get => JavaObject.getCalculatedLastDate();
        }

        public void SetYearlyAbsoluteFromDate(java.time.LocalDate date)
        {
            JavaObject.setYearlyAbsoluteFromDate(date);
        }

        public override string ToString()
        {
            return JavaObject.toString();
        }
    }
}