using org.mpxj.proxy;

namespace org.mpxj
{
    public class Step : IJavaObjectProxy<net.sf.mpxj.Step>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Step JavaObject { get; }

        public Step(Task task)
        {
            _proxyManager = task._proxyManager;
            JavaObject = new net.sf.mpxj.Step(task.JavaObject);
        }

        internal Step(ProxyManager proxyManager, net.sf.mpxj.Step javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public Task Task => _proxyManager.ProxyObject(JavaObject.getTask());

        public int? UniqueID
        {
            get => JavaObject.getUniqueID().ConvertType();
            set => JavaObject.setUniqueID(value.ConvertType());
        }

        public string Name
        {
            get => JavaObject.getName();
            set => JavaObject.setName(value);
        }

        public double? PercentComplete
        {
            get => JavaObject.getPercentComplete().ConvertType();
            set => JavaObject.setPercentComplete(value.ConvertType());
        }

        public int? SequenceNumber
        {
            get => JavaObject.getSequenceNumber().ConvertType();
            set => JavaObject.setSequenceNumber(value.ConvertType());
        }

        public double? Weight
        {
            get => JavaObject.getWeight().ConvertType();
            set => JavaObject.setWeight(value.ConvertType());
        }

        public string Description
        {
            get => JavaObject.getDescription();
            set => JavaObject.setDescription(value);
        }

        public Notes DescriptionObject
        {
            get => _proxyManager.ProxyObject(JavaObject.getDescriptionObject());
            set => JavaObject.setDescriptionObject(value.JavaObject);
        }

        public bool Complete => JavaObject.getComplete();
    }
}

