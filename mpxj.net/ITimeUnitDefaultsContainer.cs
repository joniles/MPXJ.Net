using org.mpxj.proxy;

namespace org.mpxj
{
	public interface ITimeUnitDefaultsContainer<M> : IJavaObjectProxy<M> where M : net.sf.mpxj.TimeUnitDefaultsContainer
    {
        int? MinutesPerDay { get; }

        int? MinutesPerWeek { get; }

        int? MinutesPerMonth { get; }

        int? MinutesPerYear { get; }

        int? DaysPerMonth { get; }
    }
}
