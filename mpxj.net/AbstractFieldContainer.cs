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

        public void Set(IFieldType field, object value)
        {
            JavaObject.set(field.JavaObject, value);
        }

        public object Get(IFieldType field)
        {
            return JavaObject.get(field.JavaObject);
        }

        public object GetCachedValue(IFieldType field)
        {
            return JavaObject.getCachedValue(field.JavaObject);
        }

        // TODO: implement if required
        // public void AddFieldListener(IFieldListener listener)
        // public void RemoveFieldListener(IFieldListener listener)
    }
}