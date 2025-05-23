﻿using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    // TODO: implement view class hierarchy
    public interface IView : IJavaObjectProxy<org.mpxj.View>
    {
        int? ID { get; }

        string Name { get; }

        ViewType Type { get; }

        string TableName { get; }

        Table Table { get; }
    }
}
