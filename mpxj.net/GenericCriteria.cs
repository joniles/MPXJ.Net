﻿using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class GenericCriteria : IJavaObjectProxy<org.mpxj.GenericCriteria>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.GenericCriteria JavaObject { get; }

        internal GenericCriteria(ProxyManager proxyManager, org.mpxj.GenericCriteria javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public IFieldType LeftValue => _proxyManager.ProxyObject(JavaObject.getLeftValue());

        public TestOperator? Operator => JavaObject.getOperator().ConvertType();

        public object GetValue(int index) => _proxyManager.GenericProxyObject(JavaObject.getValue(index));

        // TODO handle map argument
        //public bool Evaluate(FieldContainer container, Map<GenericCriteriaPrompt, Object> promptValues);

        public IList<GenericCriteria> CriteriaList => _proxyManager.ProxyList<org.mpxj.GenericCriteria, GenericCriteria>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getCriteriaList());

        public override string ToString() => JavaObject.toString();
    }
}

