using org.mpxj.proxy;

namespace org.mpxj
{
    public interface IFieldContainer : IJavaObjectProxy<net.sf.mpxj.FieldContainer>
    {
        void Set(net.sf.mpxj.FieldType field, object value);

        object Get(net.sf.mpxj.FieldType field);

        object GetCachedValue(net.sf.mpxj.FieldType field);

        void AddFieldListener(net.sf.mpxj.listener.FieldListener listener);

        void RemoveFieldListener(net.sf.mpxj.listener.FieldListener listener);
    }
}