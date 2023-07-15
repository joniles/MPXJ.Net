using org.mpxj.proxy;

namespace org.mpxj
{
    public class AbstractFieldContainer : ProjectEntity, IFieldContainer, IJavaObjectProxy<net.sf.mpxj.FieldContainer>
    {
        public net.sf.mpxj.FieldContainer JavaObject { get; }

        internal AbstractFieldContainer(ProxyManager proxyManager, net.sf.mpxj.AbstractFieldContainer javaObject) : base(proxyManager)
        {
            JavaObject = javaObject;
        }

        public void Set(net.sf.mpxj.FieldType field, object value)
        {
            JavaObject.set(field, value);
        }

        public object Get(net.sf.mpxj.FieldType field)
        {
            return JavaObject.get(field);
        }

        public object GetCachedValue(net.sf.mpxj.FieldType field)
        {
            return JavaObject.getCachedValue(field);
        }

        // TODO: implement if required
        // public void AddFieldListener(IFieldListener listener)
        // public void RemoveFieldListener(IFieldListener listener)
    }
}