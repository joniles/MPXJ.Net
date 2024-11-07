﻿using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
	public interface ITimeUnitDefaultsContainer<out M> : IJavaObjectProxy<M> where M : net.sf.mpxj.TimeUnitDefaultsContainer
    {
        int? MinutesPerDay { get; }

        int? MinutesPerWeek { get; }

        int? MinutesPerMonth { get; }

        int? MinutesPerYear { get; }

        int? DaysPerMonth { get; }
    }
}
