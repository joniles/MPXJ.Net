namespace org.mpxj;

public interface IFieldContainer
{
    public void Set(net.sf.mpxj.FieldType field, object value);

    public object Get(net.sf.mpxj.FieldType field);

    public object GetCachedValue(net.sf.mpxj.FieldType field);

    public void AddFieldListener(net.sf.mpxj.listener.FieldListener listener);

    public void RemoveFieldListener(net.sf.mpxj.listener.FieldListener listener);
}
