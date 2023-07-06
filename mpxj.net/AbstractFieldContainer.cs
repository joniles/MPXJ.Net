using org.mpxj.proxy;

namespace org.mpxj
{
    public class AbstractFieldContainer : ProjectEntity, IFieldContainer, IJavaObjectProxy<net.sf.mpxj.AbstractFieldContainer>
    {
        public net.sf.mpxj.AbstractFieldContainer JavaObject { get; }

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

        public void AddFieldListener(net.sf.mpxj.listener.FieldListener listener)
        {
            JavaObject.addFieldListener(listener);
        }

        public void RemoveFieldListener(net.sf.mpxj.listener.FieldListener listener)
        {
            JavaObject.removeFieldListener(listener);
        }
    }
}