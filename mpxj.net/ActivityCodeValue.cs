using System.Collections.Generic;
using System.Drawing;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ActivityCodeValue : IJavaObjectProxy<net.sf.mpxj.ActivityCodeValue>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.ActivityCodeValue JavaObject { get; }

        internal ActivityCodeValue(ProxyManager proxyManager, net.sf.mpxj.ActivityCodeValue javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public ActivityCode Type => _proxyManager.ProxyObject(JavaObject.getType());

        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();

        public Color? Color => JavaObject.getColor().ConvertType();

        public ActivityCodeValue Parent => _proxyManager.ProxyObject(JavaObject.getParent());

        public int? ParentUniqueID => JavaObject.getParentUniqueID().ConvertType();

        public IList<ActivityCodeValue> ChildValues => _proxyManager.ProxyList<net.sf.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<net.sf.mpxj.ActivityCodeValue.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public net.sf.mpxj.ActivityCodeValue.Builder JavaObject { get; set; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new net.sf.mpxj.ActivityCodeValue.Builder(file.JavaObject);
            }

            public Builder Type(ActivityCode value)
            {
                JavaObject.type(value?.JavaObject);
                return this;
            }

            public Builder UniqueID(int? value)
            {
                JavaObject.uniqueID(value.ConvertType());
                return this;
            }

            public Builder SequenceNumber(int? value)
            {
                JavaObject.sequenceNumber(value.ConvertType());
                return this;
            }

            public Builder Name(string value)
            {
                JavaObject.name(value);
                return this;
            }

            public Builder Description(string value)
            {
                JavaObject.description(value);
                return this;
            }

            public Builder Color(Color value)
            {
                JavaObject.color(value.ConvertType());
                return this;
            }

            public Builder Parent(ActivityCodeValue value)
            {
                JavaObject.parent(value?.JavaObject);
                return this;
            }

            public ActivityCodeValue Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
