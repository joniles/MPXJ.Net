using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Location : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.Location>
    {
        public net.sf.mpxj.Location JavaObject { get; }

        internal Location(net.sf.mpxj.Location javaObject)
        {
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

        public class Builder : IJavaObjectProxy<net.sf.mpxj.Location.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.Location.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.Location.Builder(file.JavaObject);
            }

            public Builder AddressLine1(string value)
            {
                JavaObject.addressLine1(value);
                return this;
            }

            public Builder AddressLine2(string value)
            {
                JavaObject.addressLine2(value);
                return this;
            }

            public Builder AddressLine3(string value)
            {
                JavaObject.addressLine3(value);
                return this;
            }

            public Builder City(string value)
            {
                JavaObject.city(value);
                return this;
            }

            public Builder Country(string value)
            {
                JavaObject.country(value);
                return this;
            }

            public Builder CountryCode(string value)
            {
                JavaObject.countryCode(value);
                return this;
            }

            public Builder Latitude(double? value)
            {
                JavaObject.latitude(value.ConvertType());
                return this;
            }

            public Builder Longitude(double? value)
            {
                JavaObject.longitude(value.ConvertType());
                return this;
            }

            public Builder Municipality(string value)
            {
                JavaObject.municipality(value);
                return this;
            }

            public Builder Name(string value)
            {
                JavaObject.name(value);
                return this;
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder PostalCode(string value)
            {
                JavaObject.postalCode(value);
                return this;
            }

            public Builder State(string value)
            {
                JavaObject.state(value);
                return this;
            }

            public Builder StateCode(string value)
            {
                JavaObject.stateCode(value);
                return this;
            }

            public Location Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
