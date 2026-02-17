using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public interface IFieldContainer : IJavaObjectProxy<org.mpxj.FieldContainer>
    {
        void Set(IFieldType field, object value);

        object Get(IFieldType field);

        object GetCachedValue(IFieldType field);

        IList<Duration> GetTimephasedDurationValues(IFieldType field, IList<DateTimeRange> ranges, TimeUnit units);
        
        IList<double?> GetTimephasedNumericValues(IFieldType field, IList<DateTimeRange> ranges);

        // TODO: implement if required
        //void AddFieldListener(IFieldListener listener);
        //void RemoveFieldListener(IFieldListener listener);
    }
}