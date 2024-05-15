using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
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

        public IFieldType LeftValue => _proxyManager.ProxyObject(JavaObject.getLeftValue());

        public TestOperator? Operator => JavaObject.getOperator().ConvertType();

        public object GetValue(int index) => _proxyManager.GenericProxyObject(JavaObject.getValue(index));

        // TODO handle map
        //public bool Evaluate(FieldContainer container, Map<GenericCriteriaPrompt, Object> promptValues);

        public IList<GenericCriteria> CriteriaList => _proxyManager.ProxyList<net.sf.mpxj.GenericCriteria, GenericCriteria>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCriteriaList());

        public override string ToString() => JavaObject.toString();
    }
}

