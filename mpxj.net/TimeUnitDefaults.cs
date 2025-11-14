namespace MPXJ.Net
{
    public class TimeUnitDefaults : ITimeUnitDefaultsContainer<org.mpxj.TimeUnitDefaults>
    {
        public org.mpxj.TimeUnitDefaults JavaObject { get; }

        internal TimeUnitDefaults(org.mpxj.TimeUnitDefaults javaObject)
        {
            JavaObject = javaObject;
        }

        public int? MinutesPerDay
        {
            get => JavaObject.getMinutesPerDay().ConvertType();
            set => JavaObject.setMinutesPerDay(value.ConvertType());
        }

        public int? MinutesPerWeek
        {
            get => JavaObject.getMinutesPerWeek().ConvertType();
            set => JavaObject.setMinutesPerWeek(value.ConvertType());
        }

        public int? MinutesPerMonth
        {
            get => JavaObject.getMinutesPerMonth().ConvertType();
            set => JavaObject.setMinutesPerMonth(value.ConvertType());
        }

        public int? MinutesPerYear
        {
            get => JavaObject.getMinutesPerYear().ConvertType();
            set => JavaObject.setMinutesPerYear(value.ConvertType());
        }

        public int? DaysPerMonth
        {
            get => JavaObject.getDaysPerMonth().ConvertType();
            set => JavaObject.setDaysPerMonth(value.ConvertType());
        }
    }
}