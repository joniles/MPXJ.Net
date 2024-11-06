using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace MPXJ.Net.Proxy
{
    internal abstract class AbstractProxyManager
    {
        private readonly ObjectIDGenerator _idGenerator = new ObjectIDGenerator();
        protected readonly Dictionary<string, object> _objectCache = new Dictionary<string, object>();

        /// <summary>
        /// Handles the case where a .Net object is created outside
        /// the proxy manager. Calling this method ensures that the 
        /// mapping is included in the proxy manager, and so avoids creating
        /// duplicate .Net objects with later use.
        /// </summary>
        /// <typeparam name="M">MPXJ java type</typeparam>
        /// <param name="o">.Net object</param>
        /// <returns>Java object</returns>
        internal M UnProxyObject<M>(IJavaObjectProxy<M> o)
        {
            if (o == null)
            {
                return default;
            }

            var key = GetKey(o.JavaObject);
            _objectCache.TryAdd(key, o);

            return o.JavaObject;
        }

        protected N ProxyObject<M, N>(M o, Func<M, N> proxyFunction)
        {
            if (o == null)
            {
                return default;
            }

            var key = GetKey(o);
            if (!_objectCache.ContainsKey(key))
            {
                _objectCache[key] = proxyFunction.Invoke(o);
            }

            return (N)_objectCache[key];
        }

        protected string GetKey(object o) => o.GetType().FullName + "." + _idGenerator.GetId(o, out _);
    }
}
