using System.Collections.Generic;
using System.Drawing;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class ActivityCodeValue : ICodeValue, IJavaObjectProxy<org.mpxj.ActivityCodeValue>
    {
        private readonly ProxyManager _proxyManager;
        public org.mpxj.ActivityCodeValue JavaObject { get; }

        internal ActivityCodeValue(ProxyManager proxyManager, org.mpxj.ActivityCodeValue javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }
        
        public ActivityCode ParentCode => _proxyManager.ProxyObject(JavaObject.getParentCode());
        
        public int? ParentCodeUniqueId => JavaObject.getParentCodeUniqueID().ConvertType();
        
        public int? UniqueID => JavaObject.getUniqueID().ConvertType();

        public int? SequenceNumber => JavaObject.getSequenceNumber().ConvertType();

        public string Name => JavaObject.getName();

        public string Description => JavaObject.getDescription();

        public Color? Color => JavaObject.getColor().ConvertType();
        
        public ActivityCodeValue ParentValue => _proxyManager.ProxyObject(JavaObject.getParentValue());
        
        public int? ParentValueUniqueId => JavaObject.getParentValueUniqueID().ConvertType();
        
        public IList<ActivityCodeValue> ChildValues => _proxyManager.ProxyList<org.mpxj.ActivityCodeValue, ActivityCodeValue>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getChildValues());

        public override string ToString() => JavaObject.toString();

        public class Builder : IJavaObjectProxy<org.mpxj.ActivityCodeValue.Builder>
        {
            private readonly ProxyManager _proxyManager;
            public org.mpxj.ActivityCodeValue.Builder JavaObject { get; }

            public Builder(ProjectFile file)
            {
                _proxyManager = file._proxyManager;
                JavaObject = new org.mpxj.ActivityCodeValue.Builder(file.JavaObject);
            }
            
            public Builder ActivityCode(ActivityCode value)
            {
                JavaObject.activityCode(value?.JavaObject);
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
            
            public Builder ParentValue(ActivityCodeValue value)
            {
                JavaObject.parentValue(value?.JavaObject);
                return this;
            }

            public ActivityCodeValue Build() => _proxyManager.ProxyObject(JavaObject.build());
        }
    }
}
