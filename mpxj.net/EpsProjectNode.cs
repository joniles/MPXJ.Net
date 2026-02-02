using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class EpsProjectNode
    {
        public org.mpxj.EpsProjectNode JavaObject { get; }

        internal EpsProjectNode(org.mpxj.EpsProjectNode javaObject)
        {
            JavaObject = javaObject;
        }
        
        public int? UniqueId => JavaObject.getUniqueID().ConvertType();

        public int? ParentEpsUniqueId => JavaObject.getParentEpsUniqueID().ConvertType();

        public string Name => JavaObject.getName();

        public string ShortName => JavaObject.getShortName();
    }
}