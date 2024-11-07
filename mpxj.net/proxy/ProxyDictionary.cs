using System;
using System.Collections;
using System.Collections.Generic;

namespace MPXJ.Net.Proxy
{
    public class ProxyDictionary<MK, MV, NK, NV> : IDictionary<NK, NV>, IJavaObjectProxy<java.util.Map>
    {
        public struct Enumerator : IEnumerator<KeyValuePair<NK, NV>>
        {
            private readonly ProxyDictionary<MK, MV, NK, NV> _dictionary;
            private java.util.Iterator _iterator;

            public KeyValuePair<NK, NV> Current { get; private set; }

            object IEnumerator.Current => Current;

            internal Enumerator(ProxyDictionary<MK, MV, NK, NV> dictionary)
            {
                _dictionary = dictionary;
                _iterator = _dictionary.JavaObject.entrySet().iterator();
                Current = default;
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if (!_iterator.hasNext())
                {
                    return false;
                }

                var entry = (java.util.Map.Entry)_iterator.next();
                Current = new KeyValuePair<NK, NV>(_dictionary._keyFromJava((MK)entry.getKey()), _dictionary._valueFromJava((MV)entry.getValue()));
                return true;
            }

            public void Reset()
            {
                _iterator = _dictionary.JavaObject.entrySet().iterator();
            }
        }

        private readonly ProxyManager _proxyManager;
        private readonly Func<MK, NK> _keyFromJava;
        private readonly Func<NK, MK> _keyToJava;
        private readonly Func<MV, NV> _valueFromJava;
        private readonly Func<NV, MV> _valueToJava;

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
            foreach (var item in _proxyManager.ProxyCollection<java.util.Map.Entry, KeyValuePair<NK, NV>>(v => new KeyValuePair<NK, NV>(_keyFromJava((MK)v.getKey()), _valueFromJava((MV)v.getValue())), _ => null, JavaObject.entrySet()))
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
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
}

