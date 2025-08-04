using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class OpcProjectBaseline : IJavaObjectProxy<org.mpxj.opc.OpcProjectBaseline>
    {
        public org.mpxj.opc.OpcProjectBaseline JavaObject { get; }
        
        internal OpcProjectBaseline(org.mpxj.opc.OpcProjectBaseline javaObject)
        {
            JavaObject = javaObject;
        }

        public OpcProjectBaseline()
        {
            JavaObject = new org.mpxj.opc.OpcProjectBaseline();
        }

        public long ProjectBaselineId
        {
            get => JavaObject.getProjectBaselineId();
            set => JavaObject.setProjectBaselineId(value);
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }
    }
}