using System;
using System.Collections;
using System.Collections.Generic;

namespace org.mpxj.proxy
{
    public class ProxyDictionary<MK, MV, NK, NV> : IDictionary<NK, NV>, IJavaObjectProxy<java.util.Map>
    {
        internal readonly ProxyManager _proxyManager;
        internal readonly Func<MK, NK> _keyFromJava;
        internal readonly Func<NK, MK> _keyToJava;
        internal readonly Func<MV, NV> _valueFromJava;
        internal readonly Func<NV, MV> _valueToJava;

        public java.util.Map JavaObject { get; }

        public NV this[NK key]
        {
            get => _valueFromJava((MV)JavaObject.get(_keyToJava(key)));
            set => JavaObject.put(_keyToJava(key), _valueToJava(value));
        }

        public ICollection<NK> Keys => _proxyManager.ProxyCollection(_keyFromJava, _keyToJava, JavaObject.keySet());

        public ICollection<NV> Values => _proxyManager.ProxyCollection(_valueFromJava, _valueToJava, JavaObject.values());

        public int Count => JavaObject.size();

        public bool IsReadOnly => false;

        internal ProxyDictionary(ProxyManager proxyManager, Func<MK, NK> keyFromJava, Func<NK, MK> keyToJava, Func<MV, NV> valueFromJava, Func<NV, MV> valueToJava, java.util.Map javaObject)
        {
            _proxyManager = proxyManager;
            _keyFromJava = keyFromJava;
            _keyToJava = keyToJava;
            _valueFromJava = valueFromJava;
            _valueToJava = valueToJava;
            JavaObject = javaObject;
        }

        public void Add(NK key, NV value)
        {
            JavaObject.put(_keyToJava(key), _valueToJava(value));
        }

        public void Add(KeyValuePair<NK, NV> item)
        {
            JavaObject.put(_keyToJava(item.Key), _valueToJava(item.Value));
        }

        public void Clear()
        {
            JavaObject.clear();
        }

        public bool Contains(KeyValuePair<NK, NV> item)
        {
            var javaKey = _keyToJava(item.Key);
            if (JavaObject.containsKey(javaKey))
            {
                var value = _valueFromJava((MV)JavaObject.get(javaKey));
                return item.Value.Equals(value);
            }
            return false;
        }

        public bool ContainsKey(NK key)
        {
            return JavaObject.containsKey(_keyToJava(key));
        }

        public void CopyTo(KeyValuePair<NK, NV>[] array, int arrayIndex)
        {
            foreach (KeyValuePair<NK, NV> item in _proxyManager.ProxyCollection<java.util.Map.Entry, KeyValuePair<NK, NV>>(v => new KeyValuePair<NK, NV>(_keyFromJava((MK)v.getKey()), _valueFromJava((MV)v.getValue())), v => null, JavaObject.entrySet()))
            {
                array.SetValue(item, arrayIndex++);
            }
        }

        public bool Remove(NK key)
        {
            var javaKey = _keyToJava(key);
            if (JavaObject.containsKey(javaKey))
            {
                JavaObject.remove(javaKey);
                return true;
            }
            return false;
        }

        public bool Remove(KeyValuePair<NK, NV> item)
        {
            if (Contains(item))
            {
                JavaObject.remove(_keyToJava(item.Key));
                return true;
            }
            return false;
        }

        public bool TryGetValue(NK key, out NV value)
        {
            var javaKey = _keyToJava(key);
            if (JavaObject.containsKey(javaKey))
            {
                value = _valueFromJava((MV)JavaObject.get(javaKey));
                return true;
            }
            value = default;
            return false;
        }

        public IEnumerator<KeyValuePair<NK, NV>> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}

