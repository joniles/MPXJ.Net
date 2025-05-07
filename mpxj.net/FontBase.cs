using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class FontBase : IJavaObjectProxy<org.mpxj.mpp.FontBase>
    {
        public org.mpxj.mpp.FontBase JavaObject { get; }

        internal FontBase(org.mpxj.mpp.FontBase javaObject)
        {
            JavaObject = javaObject;
        }

        public string Name => JavaObject.getName();

        public int Size => JavaObject.getSize();

        public int Index => JavaObject.getIndex().ConvertType().Value;

        public override string ToString() => JavaObject.toString();
    }
}

