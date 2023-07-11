using System.Collections.Generic;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class GenericCriteria : IJavaObjectProxy<net.sf.mpxj.GenericCriteria>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.GenericCriteria JavaObject { get; }

        internal GenericCriteria(ProxyManager proxyManager, net.sf.mpxj.GenericCriteria javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public GenericCriteria(ProjectProperties properties)
        {
            _proxyManager = properties._proxyManager;
            JavaObject = new net.sf.mpxj.GenericCriteria(properties.JavaObject);
        }

        public net.sf.mpxj.FieldType LeftValue
        {
            get => JavaObject.getLeftValue();
            set => JavaObject.setLeftValue(value);
        }

        public TestOperator? Operator
        {
            get => JavaObject.getOperator().ConvertType();
            set => JavaObject.setOperator(value.ConvertType());
        }

        public object GetValue(int index)
        {
            // TODO: proxy
            return JavaObject.getValue(index);
        }

        public void SetRightValue(int index, object value)
        {
            // TODO: proxy
            JavaObject.setRightValue(index, value);
        }

        // TODO handle map
        //public bool Evaluate(FieldContainer container, Map<GenericCriteriaPrompt, Object> promptValues);

        public IList<GenericCriteria> CriteriaList
        {
            get => _proxyManager.ProxyList<net.sf.mpxj.GenericCriteria, GenericCriteria>(JavaObject.getCriteriaList());
        }

        public void AddCriteria(GenericCriteria criteria)
        {
            JavaObject.addCriteria(criteria.JavaObject);
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}

