﻿using System.Collections.Generic;
using System.Linq;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class StructuredTextRecord : IJavaObjectProxy<org.mpxj.primavera.StructuredTextRecord>
    {
        public org.mpxj.primavera.StructuredTextRecord JavaObject { get; }

        internal StructuredTextRecord(org.mpxj.primavera.StructuredTextRecord javaObject)
        {
            JavaObject = javaObject;
        }

        public StructuredTextRecord()
        {
            JavaObject = new org.mpxj.primavera.StructuredTextRecord();
        }

        public StructuredTextRecord(Dictionary<string, string> attributes, List<StructuredTextRecord> children)
        {
            JavaObject = new org.mpxj.primavera.StructuredTextRecord(attributes.ConvertType(), children.ConvertType());
        }

        public string RecordName => JavaObject.getRecordName();

        public string RecordNumber => JavaObject.getRecordNumber();

        public string GetAttribute(string name) => JavaObject.getAttribute(name);

        public Dictionary<string, string> Attributes
        {
            get
            {
                return new ProxyEnumerable<java.util.Map.Entry, java.util.Map.Entry>(m => m, m => m, JavaObject.getAttributes().entrySet()).ToDictionary(e => (string)e.getKey(), e => (string)e.getValue());
            }
        }

        public IList<StructuredTextRecord> Children => new ProxyList<org.mpxj.primavera.StructuredTextRecord, StructuredTextRecord>(v => new StructuredTextRecord(v), v => v.JavaObject, JavaObject.getChildren());

        public StructuredTextRecord GetChild(string name)
        {
            var result = JavaObject.getChild(name);
            return result == null ? null : new StructuredTextRecord(result);
        }

        public void AddAttribute(string name, string value) => JavaObject.addAttribute(name, value);

        public void AddChild(StructuredTextRecord child) => JavaObject.addChild(child.JavaObject);
    }
}
