using org.mpxj.proxy;

namespace org.mpxj
{
	public interface ITimeUnitDefaultsContainer<M> : IJavaObjectProxy<M> where M : net.sf.mpxj.TimeUnitDefaultsContainer
    {
        java.lang.Integer MinutesPerDay { get; }

        java.lang.Integer MinutesPerWeek { get; }

        java.lang.Integer MinutesPerMonth { get; }

        java.lang.Integer MinutesPerYear { get; }

        java.lang.Integer DaysPerMonth { get; }
    }
}
