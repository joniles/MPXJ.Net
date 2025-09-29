using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class WebServicesProject : IJavaObjectProxy<org.mpxj.primavera.webservices.WebServicesProject>
    {
        public org.mpxj.primavera.webservices.WebServicesProject JavaObject { get; }
        
        internal WebServicesProject(org.mpxj.primavera.webservices.WebServicesProject javaObject)
        {
            JavaObject = javaObject;
        }

        public WebServicesProject()
        {
            JavaObject = new org.mpxj.primavera.webservices.WebServicesProject();
        }
        
        public string Id
        {
            get => JavaObject.getId();
            set => JavaObject.setId(value);
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public int? ObjectId
        {
            get => JavaObject.getObjectId().ConvertType();
            set => JavaObject.setObjectId(value.ConvertType());
        }

        public string DataDate
        {
            get => JavaObject.getDataDate();
            set => JavaObject.setDataDate(value);
        }

        public int? CurrentBaselineProjectObjectId
        {
            get => JavaObject.getCurrentBaselineProjectObjectId().ConvertType();
            set => JavaObject.setCurrentBaselineProjectObjectId(value.ConvertType());
        }
    }
}