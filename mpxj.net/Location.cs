using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
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

        public class Builder
        {
            private readonly ProxyManager _proxyManager;
            private readonly net.sf.mpxj.Location.Builder _javaObject;

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                _javaObject = new net.sf.mpxj.Location.Builder(file.JavaObject);
            }

            public Builder AddressLine1(string value)
            {
                _javaObject.addressLine1(value);
                return this;
            }

            public Builder AddressLine2(string value)
            {
                _javaObject.addressLine2(value);
                return this;
            }

            public Builder AddressLine3(string value)
            {
                _javaObject.addressLine3(value);
                return this;
            }

            public Builder City(string value)
            {
                _javaObject.city(value);
                return this;
            }

            public Builder Country(string value)
            {
                _javaObject.country(value);
                return this;
            }

            public Builder CountryCode(string value)
            {
                _javaObject.countryCode(value);
                return this;
            }

            public Builder Latitude(double? value)
            {
                _javaObject.latitude(value.ConvertType());
                return this;
            }

            public Builder Longitude(double? value)
            {
                _javaObject.longitude(value.ConvertType());
                return this;
            }

            public Builder Municipality(string value)
            {
                _javaObject.municipality(value);
                return this;
            }

            public Builder Name(string value)
            {
                _javaObject.name(value);
                return this;
            }

            public Builder UniqueID(int? value)
            {
                _javaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder PostalCode(string value)
            {
                _javaObject.postalCode(value);
                return this;
            }

            public Builder State(string value)
            {
                _javaObject.state(value);
                return this;
            }

            public Builder StateCode(string value)
            {
                _javaObject.stateCode(value);
                return this;
            }

            public Location Build() => _proxyManager.ProxyObject(_javaObject.build());
        }
    }
}
