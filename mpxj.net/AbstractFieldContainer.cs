namespace org.mpxj
{
    public class AbstractFieldContainer : ProjectEntity, IFieldContainer
    {
        internal readonly net.sf.mpxj.AbstractFieldContainer _proxy;

        internal AbstractFieldContainer(ProjectFile file, net.sf.mpxj.AbstractFieldContainer proxy) : base(file)
        {
            _proxy = proxy;
        }

        public void Set(net.sf.mpxj.FieldType field, object value)
        {
            _proxy.set(field, value);
        }

        public object Get(net.sf.mpxj.FieldType field)
        {
            return _proxy.get(field);
        }

        public object GetCachedValue(net.sf.mpxj.FieldType field)
        {
            return _proxy.getCachedValue(field);
        }

        public void AddFieldListener(net.sf.mpxj.listener.FieldListener listener)
        {
            _proxy.addFieldListener(listener);
        }

        public void RemoveFieldListener(net.sf.mpxj.listener.FieldListener listener)
        {
            _proxy.removeFieldListener(listener);
        }
    }
}