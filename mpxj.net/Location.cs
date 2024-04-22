﻿using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    // TODO: implement builder
    public class Location : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.Location>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Location JavaObject { get; }

        internal Location(ProxyManager proxyManager, net.sf.mpxj.Location javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public string AddressLine1 => JavaObject.getAddressLine1();

        public string AddressLine2 => JavaObject.getAddressLine2();

        public string AddressLine3 => JavaObject.getAddressLine3();

        public string City => JavaObject.getCity();

        public string Country => JavaObject.getCountry();

        public string CountryCode => JavaObject.getCountryCode();

        public double? Latitude => JavaObject.getLatitude().ConvertType();

        public double? Longitude => JavaObject.getLongitude().ConvertType();

        public string Municipality => JavaObject.getMunicipality();

        public string Name => JavaObject.getName();

        public string PostalCode => JavaObject.getPostalCode();

        public string State => JavaObject.getState();

        public string StateCode => JavaObject.getStateCode();
    }
}

