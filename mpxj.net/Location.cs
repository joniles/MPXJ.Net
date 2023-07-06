using org.mpxj.proxy;

namespace org.mpxj
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

        public java.lang.Integer UniqueID
        {
            get => JavaObject.getUniqueID();
            set => JavaObject.setUniqueID(value);
        }

        public string AddressLine1
        {
            get => JavaObject.getAddressLine1();
        }

        public string AddressLine2
        {
            get => JavaObject.getAddressLine2();
        }

        public string AddressLine3
        {
            get => JavaObject.getAddressLine3();
        }

        public string City
        {
            get => JavaObject.getCity();
        }

        public string Country
        {
            get => JavaObject.getCountry();
        }

        public string CountryCode
        {
            get => JavaObject.getCountryCode();
        }

        public java.lang.Double Latitude
        {
            get => JavaObject.getLatitude();
        }

        public java.lang.Double Longitude
        {
            get => JavaObject.getLongitude();
        }

        public string Municipality
        {
            get => JavaObject.getMunicipality();
        }

        public string Name
        {
            get => JavaObject.getName();
        }

        public string PostalCode
        {
            get => JavaObject.getPostalCode();
        }

        public string State
        {
            get => JavaObject.getState();
        }

        public string StateCode
        {
            get => JavaObject.getStateCode();
        }
    }
}

