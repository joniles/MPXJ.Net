﻿using System;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class LocalDateTimeRange : IJavaObjectProxy<net.sf.mpxj.LocalDateTimeRange>
    {
        public net.sf.mpxj.LocalDateTimeRange JavaObject { get; }

        internal LocalDateTimeRange(net.sf.mpxj.LocalDateTimeRange javaObject)
        {
            JavaObject = javaObject;
        }

        public DateTime? Start => JavaObject.getStart().ConvertType();

        public DateTime? End => JavaObject.getEnd().ConvertType();
    }
}

