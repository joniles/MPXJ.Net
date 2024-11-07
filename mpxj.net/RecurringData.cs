using System;
using System.Linq;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
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

        public DateOnly? StartDate
        {
            get => JavaObject.getStartDate().ConvertType();
            set => JavaObject.setStartDate(value.ConvertType());
        }

        public DateOnly? FinishDate
        {
            get => JavaObject.getFinishDate().ConvertType();
            set => JavaObject.setFinishDate(value.ConvertType());
        }

        public int? Occurrences
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

        public bool GetWeeklyDay(DayOfWeek day) => JavaObject.getWeeklyDay(day.ConvertType());

        public void SetWeeklyDay(DayOfWeek day, bool value) => JavaObject.setWeeklyDay(day.ConvertType(), value);

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

        public DayOfWeek? DayOfWeek
        {
            get => JavaObject.getDayOfWeek().ConvertType();
            set => JavaObject.setDayOfWeek(value.ConvertType());
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

        public DateOnly[] Dates
        {
            get
            {
                return JavaObject.getDates().Select(date => date.ConvertType().Value).ToArray();
            }
        }
            
        public bool Valid => JavaObject.isValid();

        public DateOnly? CalculatedFirstDate => JavaObject.getCalculatedFirstDate().ConvertType();

        public DateOnly? CalculatedLastDate => JavaObject.getCalculatedLastDate().ConvertType();

        public void SetYearlyAbsoluteFromDate(DateOnly date) => JavaObject.setYearlyAbsoluteFromDate(date.ConvertType());

        public override string ToString() => JavaObject.toString();
    }
}