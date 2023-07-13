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

        public FontBase(java.lang.Integer index, string name, int size)
        {
            JavaObject = new net.sf.mpxj.mpp.FontBase(index, name, size);
        }

        public string Name => JavaObject.getName();

        public int Size => JavaObject.getSize();

        public java.lang.Integer Index => JavaObject.getIndex();

        public override string ToString() => JavaObject.toString();
    }
}

