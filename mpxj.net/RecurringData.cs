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

        public int? tOccurrences
        {
            get => JavaObject.getOccurrences().ConvertType();
            set => JavaObject.setOccurrences(value.ConvertType());
        }

        public RecurrenceType? RecurrenceType
        {
            get => JavaObject.getRecurrenceType().ConvertType();
            set => JavaObject.setRecurrenceType(value.ConvertType());
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

        public bool GetWeeklyDay(java.time.DayOfWeek day) => JavaObject.getWeeklyDay(day);

        public void SetWeeklyDay(java.time.DayOfWeek day, bool value) => JavaObject.setWeeklyDay(day, value);

        public bool Relative
        {
            get => JavaObject.getRelative();
            set => JavaObject.setRelative(value);
        }

        public int? Frequency
        {
            get => JavaObject.getFrequency().ConvertType();
            set => JavaObject.setFrequency(value.ConvertType());
        }

        public java.time.DayOfWeek DayOfWeek
        {
            get => JavaObject.getDayOfWeek();
            set => JavaObject.setDayOfWeek(value);
        }

        public int? DayNumber
        {
            get => JavaObject.getDayNumber().ConvertType();
            set => JavaObject.setDayNumber(value.ConvertType());
        }

        public int? MonthNumber
        {
            get => JavaObject.getMonthNumber().ConvertType();
            set => JavaObject.setMonthNumber(value.ConvertType());
        }

        public java.time.LocalDate[] Dates => JavaObject.getDates();

        public bool Valid => JavaObject.isValid();

        public java.time.LocalDate CalculatedFirstDate => JavaObject.getCalculatedFirstDate();

        public java.time.LocalDate CalculatedLastDate => JavaObject.getCalculatedLastDate();

        public void SetYearlyAbsoluteFromDate(java.time.LocalDate date) => JavaObject.setYearlyAbsoluteFromDate(date);

        public override string ToString() => JavaObject.toString();
    }
}