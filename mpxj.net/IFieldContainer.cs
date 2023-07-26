using org.mpxj.proxy;

namespace org.mpxj
{
    public interface IFieldContainer : IJavaObjectProxy<net.sf.mpxj.FieldContainer>
    {
        void Set(IFieldType field, object value);

        object Get(IFieldType field);

        object GetCachedValue(IFieldType field);

        // TODO: implement if required
        //void AddFieldListener(IFieldListener listener);
        //void RemoveFieldListener(IFieldListener listener);
    }
}