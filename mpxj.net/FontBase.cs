using org.mpxj.proxy;

namespace org.mpxj
{
    public class FontBase : IJavaObjectProxy<net.sf.mpxj.mpp.FontBase>
    {
        public net.sf.mpxj.mpp.FontBase JavaObject { get; }

        internal FontBase(net.sf.mpxj.mpp.FontBase javaObject)
        {
            JavaObject = javaObject;
        }

        public FontBase(int index, string name, int size)
        {
            JavaObject = new net.sf.mpxj.mpp.FontBase(index.ConvertType(), name, size);
        }

        public string Name => JavaObject.getName();

        public int Size => JavaObject.getSize();

        public int Index => JavaObject.getIndex().ConvertType().Value;

        public override string ToString() => JavaObject.toString();
    }
}

