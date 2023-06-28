namespace org.mpxj;

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

    public java.util.Date StartDate
    {
        get => _proxy.getStartDate();
        set => _proxy.setStartDate(value);
    }

    public java.util.Date FinishDate
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
        get => _proxy.isWorkingDaysOnly();
        set => _proxy.setWorkingDaysOnly(value);
    }

    public bool GetWeeklyDay(net.sf.mpxj.Day day)
    {
        return _proxy.getWeeklyDay(day);
    }

    public void SetWeeklyDay(net.sf.mpxj.Day day, bool value)
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

    public net.sf.mpxj.Day DayOfWeek
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

    public java.util.Date[] Dates
    {
        get => _proxy.getDates();
    }

    public bool Valid
    {
        get => _proxy.isValid();
    }

    public java.util.Date CalculatedFirstDate
    {
        get => _proxy.getCalculatedFirstDate();
    }

    public java.util.Date CalculatedLastDate
    {
        get => _proxy.getCalculatedLastDate();
    }

    public void SetYearlyAbsoluteFromDate(java.util.Date date)
    {
        _proxy.setYearlyAbsoluteFromDate(date);
    }

    public override string ToString()
    {
        return _proxy.toString();
    }
}
